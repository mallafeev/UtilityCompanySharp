using CourseWorkPIPS.Models;
using CourseWorkPIPS.Services.IServ;
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
    public partial class AddressForm : Form
    {
        private readonly IAddressService _addressService;
        private bool _isEditMode = false;
        private Address _selectedAddress;

        // Конструктор для создания нового адреса
        public AddressForm(IAddressService addressService)
        {
            InitializeComponent();
            _addressService = addressService;
            InitializeForm();
        }

        // Конструктор для редактирования существующего адреса
        public AddressForm(IAddressService addressService, Address address)
            : this(addressService)
        {
            _selectedAddress = address;
            _isEditMode = true;
            LoadAddressData();
        }

        private void InitializeForm()
        {
            Text = _isEditMode ? "Редактирование адреса" : "Создание адреса";
        }

        private void LoadAddressData()
        {
            if (_isEditMode && _selectedAddress != null)
            {
                textBoxAddress.Text = _selectedAddress.Street;
                textBoxNumber.Text = _selectedAddress.House.ToString();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateInputs();

                var address = new Address
                {
                    Street = textBoxAddress.Text,
                    House = int.Parse(textBoxNumber.Text)
                };

                if (_isEditMode)
                {
                    address.Id = _selectedAddress.Id;
                    _addressService.UpdateAddress(address);
                }
                else
                {
                    _addressService.CreateAddress(address);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}");
            }
        }

        private void ValidateInputs()
        {
            string input = textBoxNumber.Text;
            if (string.IsNullOrEmpty(textBoxAddress.Text))
                throw new Exception("Улица не может быть пустой");

            if (string.IsNullOrEmpty(textBoxNumber.Text))
                throw new Exception("Номер дома не может быть пустым");

            if (string.IsNullOrEmpty(input) || !input.All(char.IsDigit))
            {
                throw new Exception("Поле должно содержать только цифры");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
