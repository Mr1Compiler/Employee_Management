using BusinessLayer;
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
    public partial class ucAdminProfile : UserControl
    {
        public static clsAdmin admin;
        public ucAdminProfile()
        {
            InitializeComponent();
            SetAdminInfo();
            LoadAllAdminInfo();
        }
        public void SetAdminInfo()
        {
            if (clsAdmin.CurrentAdmin == null)
            {
                return;
            }
            admin = clsAdmin.CurrentAdmin;
        }

        public string GetUserName()
        {
            return admin.Username;
        }
        public void LoadAllAdminInfo()
        {
            if (admin == null)
            {
                return;
            }

            if (admin.ImagePath != null)
            {
                pbAdminImage.ImageLocation = admin.ImagePath;
            }
            else
                pbAdminImage.Image = null;

            lblAdminID.Text = admin.AdminID.ToString();
            lblName.Text = admin.Name;
            lblUsername.Text = admin.Username;
            lblEmployeeID.Text = admin.EmployeeID.ToString();
        }

        public void ucAdminProfile_Load(object sender, EventArgs e)
        {
           // LoadAllAdminInfo();
        }
    }
}
