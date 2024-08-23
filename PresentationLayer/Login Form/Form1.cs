using BusinessLayer;
using PresentationLayer.Main_Form;
using PresentationLayer.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PresentationLayer
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }


        clsAdmin Admin;
        frmMainForm frmMainForm;
        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool CheckisNullOrEmply()
        {
            return
              (string.IsNullOrEmpty(tbUsername.Text) ||
               string.IsNullOrWhiteSpace(tbUsername.Text) ||
               string.IsNullOrEmpty(tbPassword.Text) ||
               string.IsNullOrWhiteSpace(tbPassword.Text));
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            Admin = clsAdmin.Find(tbUsername.Text, tbPassword.Text);
            if (!CheckisNullOrEmply())
            {
                if (Admin != null)
                {
                    this.Hide();
                    frmMainForm = new frmMainForm();
                    frmMainForm.ShowDialog();
                    this.Close();
                }
                else
                    MessageBox.Show("Wrong Username or password");
            }
            else
                MessageBox.Show("cannot enter empty Username or password!");
        }
    }
}
