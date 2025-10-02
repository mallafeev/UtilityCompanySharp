using CourseWorkPIPS.Models;
using CourseWorkPIPS.Models.Enums;
using CourseWorkPIPS.Services.IServ;
using CourseWorkPIPS.Services.Serv;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkPIPS
{
    public partial class AddressesForm : Form
    {
        private readonly IAddressService _addressService;
        private readonly BindingSource _bindingSource = new();
        private readonly IServiceProvider _serviceProvider;
        private readonly IPassService _passService;
        private readonly ILogger _logger;

        public AddressesForm(IAddressService addressService, IServiceProvider serviceProvider, IPassService passService, ILogger<AddressesForm> logger)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _addressService = addressService;
            InitializeGrid();
            LoadData();
            _passService = passService;
            _logger = logger;
        }

        private void InitializeGrid()
        {
            dataGridView.DataSource = _bindingSource;
            dataGridView.ReadOnly = true;
            dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AllowUserToAddRows = false;

        }

        private void LoadData()
        {
            try
            {
                var addresses = _addressService.GetAllAddresses();
                _bindingSource.DataSource = addresses;
                dataGridView.SelectionChanged += (s, e) => LoadPassesForAddress();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}");
                
            }
            dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.HeaderCell.Style.BackColor = Color.MediumSeaGreen;
            }
            dataGridView.Columns["Id"].HeaderText = "Номер";
            dataGridView.Columns["Id"].FillWeight = 100;

            dataGridView.Columns["Street"].HeaderText = "Улица";
            dataGridView.Columns["Street"].FillWeight = 200;

            dataGridView.Columns["House"].HeaderText = "Номер дома";
            dataGridView.Columns["House"].FillWeight = 150;

            dataGridView.Columns["Passes"].Visible = false;
            dataGridView.Columns["CountUses"].Visible = false;


        }

        private void LoadPassesForAddress()
        {
            if (dataGridView.CurrentRow?.DataBoundItem is Address selectedAddress)
            {

                labelUse.Text = selectedAddress.CountUses.ToString();
                var allPasses = _passService.GetAllPasses();
                var unboundPasses = allPasses.Where(p => p.AddressId == null).ToList();
                dataGridViewAllPasses.DataSource = unboundPasses;

                var boundPasses = _passService.GetPassesByAddressId(selectedAddress.Id);
                dataGridViewBoundPasses.DataSource = boundPasses;
                dataGridViewAllPasses.EditMode = DataGridViewEditMode.EditProgrammatically;
                foreach (DataGridViewColumn column in dataGridViewAllPasses.Columns)
                {
                    column.HeaderCell.Style.BackColor = Color.MediumSeaGreen;
                }

                dataGridViewAllPasses.Columns["Id"].Visible = false;

                dataGridViewAllPasses.Columns["Code"].HeaderText = "Уникальный код";
                dataGridViewAllPasses.Columns["Code"].FillWeight = 200;

                dataGridViewAllPasses.Columns["PeriodStart"].Visible = false;

                dataGridViewAllPasses.Columns["PeriodEnd"].Visible = false;

                dataGridViewAllPasses.Columns["Type"].Visible = false;

                dataGridViewAllPasses.Columns["Kind"].Visible = false;

                dataGridViewAllPasses.Columns["Status"].Visible = false;

                dataGridViewAllPasses.Columns["Address"].Visible = false;
                dataGridViewAllPasses.Columns["AddressId"].Visible = false;
                dataGridViewAllPasses.Columns["Name"].HeaderText = "Название";
                dataGridViewAllPasses.Columns["Name"].FillWeight = 100;
                dataGridViewAllPasses.ReadOnly = true;
                dataGridViewAllPasses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridViewAllPasses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewAllPasses.AllowUserToAddRows = false;
                dataGridViewBoundPasses.EditMode = DataGridViewEditMode.EditProgrammatically;
                foreach (DataGridViewColumn column in dataGridViewBoundPasses.Columns)
                {
                    column.HeaderCell.Style.BackColor = Color.MediumSeaGreen;
                }
                dataGridViewBoundPasses.Columns["Id"].Visible = false;

                dataGridViewBoundPasses.Columns["Code"].HeaderText = "Уникальный код";
                dataGridViewBoundPasses.Columns["Code"].FillWeight = 150;

                dataGridViewBoundPasses.Columns["PeriodStart"].Visible = false;

                dataGridViewBoundPasses.Columns["PeriodEnd"].Visible = false;

                dataGridViewBoundPasses.Columns["Type"].Visible = false;

                dataGridViewBoundPasses.Columns["Kind"].Visible = false;

                dataGridViewBoundPasses.Columns["Status"].Visible = false;

                dataGridViewBoundPasses.Columns["Address"].Visible = false;
                dataGridViewBoundPasses.Columns["AddressId"].Visible = false;
                dataGridViewBoundPasses.Columns["Name"].HeaderText = "Название";
                dataGridViewBoundPasses.Columns["Name"].FillWeight = 100;
                dataGridViewBoundPasses.ReadOnly = true;
                dataGridViewBoundPasses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridViewBoundPasses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewBoundPasses.AllowUserToAddRows = false;
            }
        }

        private void btnAddAddress_Click(object sender, EventArgs e)
        {
            using (var editForm = new AddressForm(_addressService))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void dataGridViewAddresses_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView.Rows[e.RowIndex].DataBoundItem is Address selectedAddress)
            {
                using (var editForm = new AddressForm(_addressService, selectedAddress))
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadData();
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите адрес для редактирования");
            }
        }
        private void returnMain(object sender, EventArgs e)
        {
            _logger.LogInformation("Возврат на главную");
            this.Close();
        }


        private void BtnAddPass_Click(object sender, EventArgs e)
        {
            _logger.LogInformation("Добавлен пропуск к адресу");
            if (dataGridViewAllPasses.CurrentRow?.DataBoundItem is Pass selectedPass &&
                dataGridView.CurrentRow?.DataBoundItem is Address selectedAddress)
            {
                selectedPass.AddressId = selectedAddress.Id;
                _passService.UpdatePass(selectedPass);

                LoadPassesForAddress();
            }
            else
            {
                MessageBox.Show("Выберите адрес и пропуск");
            }
        }

        private void BtnRemovePass_Click(object sender, EventArgs e)
        {
            if (dataGridViewBoundPasses.CurrentRow?.DataBoundItem is Pass selectedPass)
            {
                selectedPass.AddressId = null;
                _passService.UpdatePass(selectedPass);

                LoadPassesForAddress();
                _logger.LogInformation("Добавлен пропуск к адресу");
            }
            else
            {
                MessageBox.Show("Выберите пропуск для отвязки");
            }
        }


        private void BtnDeleteAddress_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView.CurrentRow?.DataBoundItem is Address selectedAddress)
                {
                    _addressService.DeleteAddress(selectedAddress.Id);
                    _logger.LogInformation("Адрес удален");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Выберите адрес для удаления");
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка удаления: {ex.Message}");
                _logger.LogWarning(ex, "Ошибка удаление адреса");
            }
        }

        private void buttonUsePass_Click(object sender, EventArgs e)
        {
            if (dataGridViewBoundPasses.CurrentRow?.DataBoundItem is Pass selectedPass)
            {
                int currentAddressId = (int)selectedPass.AddressId;
                if (selectedPass.Status != PassStatus.Деактивированный)
                {
                    _addressService.IncrementUses((int)selectedPass.AddressId);
                    int useCount = _addressService.GetUseCount((int)selectedPass.AddressId);
                    if (selectedPass.Kind == PassKind.Одноразовый && selectedPass.Status != PassStatus.Деактивированный)
                    {
                        selectedPass.Status = PassStatus.Деактивированный;
                        _passService.UpdatePass(selectedPass);
                    }
                    labelUse.Text = useCount.ToString();
                    _logger.LogInformation("Использование пропуска на адрес");
                }
                else
                {
                    MessageBox.Show("Нельзя использовать деактивированный пропуск");
                }
            }
            else
            {
                _logger.LogWarning("Ошибка использования пропуска");
                MessageBox.Show($"Ошибка: добавьте пропуск для использования");
            }
        }

    }
}
