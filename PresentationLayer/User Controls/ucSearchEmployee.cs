using BusinessLayer;
using Guna.UI2.WinForms;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.User_Controls
{
    public partial class ucSearchEmployee : UserControl
    {

        enum enSearch { ID = 0, Name = 1 }
        enSearch search = enSearch.ID;

        public ucSearchEmployee()
        {
            InitializeComponent();
            ShowSearch();
            ucShowAllEmployees1.Hide();
        }

        private void ShowSearch()
        {
            if (search == enSearch.ID)
            {
                tbID.Visible = true;
                tbName.Visible = false;
            }
            else
            {
                tbName.Visible = true;
                tbID.Visible = false;
            }
        }
        private bool CheckIsTextBoxNullOrEmpty(Guna2TextBox tb)
        {
            return (string.IsNullOrEmpty(tb.Text) ||
                string.IsNullOrWhiteSpace(tb.Text));

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {

        }



        private void tbID_TextChanged(object sender, EventArgs e)
        {
            if (!CheckIsTextBoxNullOrEmpty(tbID))
            {
                tbName.Enabled = false;
            }
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            if (!CheckIsTextBoxNullOrEmpty(tbName))
            {
                tbID.Enabled = false;

            }
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            search = enSearch.Name;
            ShowSearch();
        }

        private bool _CheckIDTextBox()
        {
            if (!int.TryParse(tbID.Text, out _))
            {
                errorProvider1.SetError(tbID, "Pleace enter a number");
                return false;
            }
            else
            {
                errorProvider1.Clear();
                return true;
            }
        }

        private bool _CheckNameTextBox()
        {
            if (int.TryParse(tbName.Text, out _))
            {
                errorProvider1.SetError(tbName, "Pleace enter a name");
                return false;
            }
            else
            {
                errorProvider1.Clear();
                return true;
            }
        }

        private void _AssginEmployeeInfo(clsEmployee Employee)
        {
            lblFirstName.Text = Employee.FirstName;
            lblLastName.Text = Employee.LastName;
            lblGendor.Text = Employee.Gender;
            lblEmployeeID.Text = Employee.ID.ToString();
            lblDateOfBirth.Text = Employee.DateOfBirth.ToString();
            lblCountryName.Text = Employee.CountryName;
            lblDepartmentName.Text = Employee.DepartmentName;
            lblHireDate.Text = Employee.HireDate.ToString();
            lblExitDate.Text = Employee.ExitDate.ToString();
            lblMonthlySalary.Text = Employee.MonthlySalary.ToString();
            lblBonusPrec.Text = Employee.BonusPerc.ToString();

            if (Employee.ImagePath != null)
            {
                pbEmployeeImage.ImageLocation = Employee.ImagePath;
            }
            else
            {
                pbEmployeeImage = null;

            }
        }

        private bool _IsExist(clsEmployee employee)
        {
            return (employee != null);
        }
        private void btnSearch_Click_1(object sender, EventArgs e)
        {


            if (search == enSearch.ID)
            {
                if (CheckIsTextBoxNullOrEmpty(tbID))
                {
                    MessageBox.Show("Can not enter empty value");
                }

                else if (_CheckIDTextBox())
                {
                    //MessageBox.Show($"Entered value is {tbID.Text}");
                    ucShowAllEmployees1.Hide();

                    clsEmployee Employee = clsEmployee.FindEmpolyeeByID(int.Parse(tbID.Text));

                    if (Employee != null)
                    {
                        _AssginEmployeeInfo(Employee);
                    }
                    else
                    {
                        MessageBox.Show($"Employee with {tbID.Text} not exist!");
                        return;
                    }

                    ResultPanel.Visible = true;
                }



            }

            else if (search == enSearch.Name)
            {
                if (CheckIsTextBoxNullOrEmpty(tbName))
                {
                    MessageBox.Show("Can not enter empty value");
                }



                else if (_CheckNameTextBox())
                {
                    ucShowAllEmployees1.SearchedName(tbName.Text.Trim());

                    ucShowAllEmployees1.Show();          

                    ResultPanel.Visible = true;
                }


            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            search = enSearch.ID;
            ShowSearch();
        }

        private void guna2GradientButton2_Click_1(object sender, EventArgs e)
        {
            search = enSearch.Name;
            ShowSearch();
        }

        private void ucShowAllEmployees1_Load(object sender, EventArgs e)
        {
                
        }
    }
}



