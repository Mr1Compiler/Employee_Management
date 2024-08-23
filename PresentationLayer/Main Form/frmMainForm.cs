using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace PresentationLayer.Main_Form
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void _LoadAdminInfo()
        {
            if (clsAdmin.CurrentAdmin.ImagePath != null)
            {
                pbAdminImage.ImageLocation = clsAdmin.CurrentAdmin.ImagePath;
            }
            else
                pbAdminImage = null;

            lblUsername.Text = clsAdmin.CurrentAdmin.Username;
        }
        private void frmMainForm_Load(object sender, EventArgs e)
        {

            _LoadAdminInfo();

            _HideUserContrls();
            ShowUserControl(ucAdminProfile1);
        }

        private void ShowUserControl(UserControl UC)
        {
            UC.Show();
        }

        private void _HideUserContrls()
        {
            ucAdminProfile1.Hide();
            ucSearchEmployee1.Hide();
            ucShowAllEmployees1.Hide();
            ucUpdateEmployee1.Hide();
            ucDeleteEmployee1.Hide();
            ucAddEmployee1.Hide();
        }

        private void btnShowEmployees_Click(object sender, EventArgs e)
        {
            ucShowAllEmployees1.LoadDataAgain();
            _HideUserContrls();
            ShowUserControl(ucShowAllEmployees1);
        }

        private void btnShowAdminProfile_Click(object sender, EventArgs e)
        {
            _HideUserContrls();
            ShowUserControl(ucAdminProfile1);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _HideUserContrls();
            ShowUserControl(ucSearchEmployee1);
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            _HideUserContrls();
            ShowUserControl(ucUpdateEmployee1);
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            _HideUserContrls();
            ShowUserControl(ucDeleteEmployee1);
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            _HideUserContrls();
            ShowUserControl(ucAddEmployee1);
        }

        private void btnSignout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
            this.Close();
        }
    }
}
