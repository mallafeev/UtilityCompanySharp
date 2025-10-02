using CourseWorkPIPS.Models;
using CourseWorkPIPS.Models.Enums;
using CourseWorkPIPS.Services.IServ;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CourseWorkPIPS
{
    public partial class PassesForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IPassService _passService;
        private readonly ILogger _logger;
        public PassesForm(IPassService passService, IServiceProvider serviceProvider, ILogger<PassesForm> logger)
        {
            InitializeComponent();
            _passService = passService;
            LoadPasses();
            _serviceProvider = serviceProvider;
            LoadEnums();
            _logger = logger;
            comboBoxType.SelectedIndexChanged += (s, e) => ApplyFilter();
            comboBoxKind.SelectedIndexChanged += (s, e) => ApplyFilter();

            dataGridViewPasses.SelectionChanged += (s, e) => UpdateShareInfo();
            _logger = logger;
        }

        private void LoadPasses()
        {
            try
            {
                var passes = _passService.GetAllPasses();
                foreach (var pas in passes)
                {
                    if (pas.PeriodEnd < DateTime.Today) 
                    {
                        pas.Status = PassStatus.Неактивный;
                        _passService.UpdatePass(pas);
                    }
                }
                dataGridViewPasses.DataSource = passes;
                dataGridViewPasses.ReadOnly = true;
                foreach (DataGridViewColumn column in dataGridViewPasses.Columns)
                {
                    column.HeaderCell.Style.BackColor = Color.MediumSeaGreen;
                }
                dataGridViewPasses.EditMode = DataGridViewEditMode.EditProgrammatically;
                dataGridViewPasses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridViewPasses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewPasses.Columns["Id"].HeaderText = "Номер";
                dataGridViewPasses.Columns["Id"].FillWeight = 100;

                dataGridViewPasses.Columns["Name"].HeaderText = "Название";
                dataGridViewPasses.Columns["Name"].FillWeight = 200;

                dataGridViewPasses.Columns["Code"].HeaderText = "Уникальный код";
                dataGridViewPasses.Columns["Code"].FillWeight = 200;

                dataGridViewPasses.Columns["PeriodStart"].HeaderText = "Начало действия";
                dataGridViewPasses.Columns["PeriodStart"].FillWeight = 220;

                dataGridViewPasses.Columns["PeriodEnd"].HeaderText = "Конец действия";
                dataGridViewPasses.Columns["PeriodEnd"].FillWeight = 220;

                dataGridViewPasses.Columns["Type"].HeaderText = "Тип";
                dataGridViewPasses.Columns["Type"].FillWeight = 150;

                dataGridViewPasses.Columns["Kind"].HeaderText = "Вид";
                dataGridViewPasses.Columns["Kind"].FillWeight = 150;

                dataGridViewPasses.Columns["Status"].HeaderText = "Статус";
                dataGridViewPasses.Columns["Status"].FillWeight = 150;

                dataGridViewPasses.Columns["Address"].Visible = false;
                dataGridViewPasses.Columns["AddressId"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}");
            }
        }
        private void dataGridViewPasses_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridViewPasses.Rows[e.RowIndex].DataBoundItem is Pass selectedPass)
            {
                if (selectedPass.Status != PassStatus.Деактивированный && selectedPass.Status != PassStatus.Неактивный)
                {
                    using (var editForm = new PassForm(_passService, selectedPass))
                    {
                        if (editForm.ShowDialog() == DialogResult.OK)
                        {
                            LoadPasses();
                        }
                    }
                }
                else 
                {
                    MessageBox.Show(
                        "Редактирование доступно только для пропусков со статусом 'Активный'. 'Неактивный' сначала нужно продлить.",
                        "Ошибка",
                        MessageBoxButtons.OK
                    );
                }
                
            }
        }

        private void btnCreatePass_Click(object sender, EventArgs e)
        {
            using (var addForm = new PassForm(_passService))
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    LoadPasses();
                }
            }
        }

        private void returnMain(object sender, EventArgs e)
        {
            _logger.LogInformation("Возвращение на главную");
            this.Close();
        }
        private void LoadEnums()
        {
            comboBoxType.DataSource = EnumExtensions.ToListWithAll<PassType>();
            comboBoxKind.DataSource = EnumExtensions.ToListWithAll<PassKind>();
        }

        private void ApplyFilter()
        {
            _logger.LogInformation("Применение фильтра");
            string selectedType = comboBoxType.SelectedItem as string;
            string selectedKind = comboBoxKind.SelectedItem as string;

            var filtered = _passService.FilterPasses(
                selectedKind == "Все" ? null : (PassKind?)Enum.Parse(typeof(PassKind), selectedKind),
                selectedType == "Все" ? null : (PassType?)Enum.Parse(typeof(PassType), selectedType)
            );
            dataGridViewPasses.DataSource = filtered;
        }

        private void BtnDeletePass_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewPasses.CurrentRow?.DataBoundItem is Pass selectedPass)
                {
                    if (selectedPass.AddressId.HasValue)
                    {
                        selectedPass.AddressId = null;
                        _passService.UpdatePass(selectedPass);
                    }
                    _passService.DeletePass(selectedPass.Id);
                    LoadPasses();
                    _logger.LogInformation("Удален пропуск");
                }
                else
                {
                    MessageBox.Show("Выберите пропуск для удаления");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка удаления: {ex.Message}");
                _logger.LogWarning(ex, "Ошибка удаления");
            }
        }

        private void UpdateShareInfo()
        {
            if (dataGridViewPasses.CurrentRow?.DataBoundItem is Pass selectedPass && !string.IsNullOrEmpty(selectedPass.Code))
            {
                string shareLink = $"Делюсь кодом пропуска: {selectedPass.Code}";
                GenerateQRCode(shareLink, pictureBoxQRCode);
                textBoxCodePr.ReadOnly = true;
                textBoxCodePr.Text = selectedPass.Code;
            }
            else
            {
                pictureBoxQRCode.Image = null;
            }
        }

        private void GenerateQRCode(string text, PictureBox pictureBox)
        {
            try
            {
                var generator = new QRCodeGenerator();
                var data = generator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q);
                using (var qrCode = new QRCode(data).GetGraphic(5))
                {
                    pictureBox.Image = new Bitmap(qrCode);
                }
                _logger.LogInformation("Qr готов");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка генерации QR-кода: {ex.Message}");
                _logger.LogWarning(ex, "Ошибка генерации qr-code");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var statick = _serviceProvider.GetRequiredService<Static>();
            statick.Show();
        }

        private void buttonProd_Click(object sender, EventArgs e)
        {
            if (dataGridViewPasses.CurrentRow?.DataBoundItem is Pass selectedPass && !string.IsNullOrEmpty(selectedPass.Code))
            {
                DateTime newEndDate = dateTimePickerDo.Value.ToUniversalTime();
                DateTime currentEndDate = selectedPass.PeriodEnd;

                if (newEndDate <= currentEndDate)
                {
                    MessageBox.Show(
                        "Ошибка: Новая дата окончания должна быть больше текущей даты окончания пропуска!",
                        "Некорректная дата",
                        MessageBoxButtons.OK
                    );
                    return;
                }
                if (selectedPass.Status == PassStatus.Активный || selectedPass.Status == PassStatus.Деактивированный)
                {
                    MessageBox.Show(
                        "Ошибка: Продление доступно только для пропусков со статусом 'Неактивный'!",
                        "Неверный статус",
                        MessageBoxButtons.OK
                    );
                    return;
                }
                var pass = new Pass
                {
                    Name = selectedPass.Name,
                    Type = selectedPass.Type,
                    PeriodStart = selectedPass.PeriodStart,
                    PeriodEnd = newEndDate,
                    Kind = selectedPass.Kind,
                    Status = PassStatus.Активный,
                    Code = selectedPass.Code,
                    Id = selectedPass.Id
                };
                _passService.UpdatePass(pass);
                LoadPasses();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (comboBoxType.Items.Count > 0 && comboBoxType.Items[0] is string firstType && firstType == "Все")
                comboBoxType.SelectedIndex = 0;

            if (comboBoxKind.Items.Count > 0 && comboBoxKind.Items[0] is string firstKind && firstKind == "Все")
                comboBoxKind.SelectedIndex = 0;

            ApplyFilter();
        }
    }
}
