using Microsoft.Extensions.DependencyInjection;
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
    public partial class StartForm : Form
    {
        private readonly IServiceProvider _serviceProvider;

        public StartForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void OpenAddressesForm(object sender, EventArgs e)
        {
            var addressesForm = _serviceProvider.GetRequiredService<AddressesForm>();
            addressesForm.Show();
        }

        private void OpenPassesForm(object sender, EventArgs e)
        {
            var passesForm = _serviceProvider.GetRequiredService<PassesForm>();
            passesForm.Show();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }
    }
}
