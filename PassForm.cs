using CourseWorkPIPS.Models;
using CourseWorkPIPS.Models.Enums;
using CourseWorkPIPS.Services.IServ;
using CourseWorkPIPS.Services.Serv;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Xml.Linq;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace CourseWorkPIPS
{
    public partial class PassForm : Form
    {
        private readonly IPassService _passService;
        private bool _isEditMode = false;
        private Pass _selectedPass;
        public PassForm(IPassService passService)
        {
            InitializeComponent();
            _passService = passService;
            InitializeForm();
        }

        public PassForm(IPassService passService, Pass pass) : this(passService)
        {
            _selectedPass = pass;
            _isEditMode = true;
            LoadPassData();
        }
        private void InitializeForm()
        {
            textBoxCode.ReadOnly = true;
            LoadEnums();
            LoadDateTimePickers();
            this.Load += PassForm_Load;
        }
        private void LoadDateTimePickers()
        {
            var now = DateTime.Now;
            dateTimePickerStart.Value = now;
            dateTimePickerEnd.Value = now.AddMonths(1);
        }
        private void LoadPassData()
        {

            if (_isEditMode && _selectedPass != null)
            {
                comboBoxTypes.SelectedItem = _selectedPass.Type;
                dateTimePickerStart.Value = _selectedPass.PeriodStart.ToUniversalTime();
                dateTimePickerEnd.Value = _selectedPass.PeriodEnd.ToUniversalTime();
                comboBoxKind.SelectedItem = _selectedPass.Kind;
                comboBoxStatus.SelectedItem = _selectedPass.Status;
                textBoxCode.Text = _selectedPass.Code;
                textBoxName.Text = _selectedPass.Name;

            }
        }

        private void PassForm_Load(object sender, EventArgs e)
        {
            Text = _isEditMode ? "Редактирование пропуска" : "Создание нового пропуска";
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateInputs();

                var pass = new Pass
                {
                    Name = textBoxName.Text,
                    Type = (PassType)comboBoxTypes.SelectedItem,
                    PeriodStart = dateTimePickerStart.Value.ToUniversalTime(),
                    PeriodEnd = dateTimePickerEnd.Value.ToUniversalTime(),
                    Kind = (PassKind)comboBoxKind.SelectedItem,
                    Status = (PassStatus)comboBoxStatus.SelectedItem,
                    Code = textBoxCode.Text
                };

                if (_isEditMode)
                {
                    pass.Id = _selectedPass.Id;
                    _passService.UpdatePass(pass);
                }
                else
                {
                    _passService.CreatePass(pass);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadEnums()
        {
            comboBoxTypes.DataSource = Enum.GetValues(typeof(PassType)).Cast<PassType>().ToList();

            comboBoxKind.DataSource = Enum.GetValues(typeof(PassKind)).Cast<PassKind>().ToList();

            comboBoxStatus.DataSource = Enum.GetValues(typeof(PassStatus)).Cast<PassStatus>().ToList();
        }


        private void ValidateInputs()
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
                throw new Exception("Заполните название");
            if (string.IsNullOrEmpty(textBoxCode.Text))
                throw new Exception("Код пропуска не может быть пустым");

            if (dateTimePickerStart.Value > dateTimePickerEnd.Value)
                throw new Exception("Дата начала действия не может быть позже даты окончания");
            
        }
        private void btnGenerateCode_Click(object sender, EventArgs e)
        {
            var code = $"{DateTime.Now:yyyyMMdd}-{new Random().Next(100000, 999999)}";
            textBoxCode.Text = code;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
