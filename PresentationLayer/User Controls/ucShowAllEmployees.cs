using BusinessLayer;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.User_Controls
{
    public partial class ucShowAllEmployees : UserControl
    {
        public ucShowAllEmployees()
        {
            InitializeComponent();
            GetEmployeesData();
        }

        public static void dgvRefresh()
        {
              
        }
        public void SearchedName(string FullName)
        {
            
            dgvEmployeesData.Refresh();
            dgvEmployeesData.DataSource = clsEmployee.FindEmployeesByName(FullName);
        }

        public void GetEmployeesData()
        {

            dgvEmployeesData.DataSource = clsEmployee.GetAllEmployees();

            dgvEmployeesData.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            dgvEmployeesData.RowTemplate.Height = 32;
        }

        public void LoadDataAgain()
        {
            GetEmployeesData();
        }
        private void ucShowAllEmployees_Load(object sender, EventArgs e)
        {
        }
    }
}
