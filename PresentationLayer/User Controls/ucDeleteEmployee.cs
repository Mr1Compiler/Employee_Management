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
    public partial class ucDeleteEmployee : UserControl
    {
        public ucDeleteEmployee()
        {
            InitializeComponent();
        }

        private clsEmployee _Employee;
        private int _EmployeeID;

        private void _LoadData()
        {
            lblFirstName.Text = _Employee.FirstName;
            lblLastName.Text = _Employee.LastName;
            lblGendor.Text = _Employee.Gender;
            lblEmployeeID.Text = _Employee.ID.ToString();
            lblDateOfBirth.Text = _Employee.DateOfBirth.ToString();
            lblCountryName.Text = _Employee.CountryName;
            lblDepartmentName.Text = _Employee.DepartmentName;
            lblHireDate.Text = _Employee.HireDate.ToString();
            lblExitDate.Text = _Employee.ExitDate.ToString();
            lblMonthlySalary.Text = _Employee.MonthlySalary.ToString();
            lblBonusPrec.Text = _Employee.BonusPerc.ToString();

            if (_Employee.ImagePath != null)
            {
                pbEmployeeImage.ImageLocation = _Employee.ImagePath;
            }
            else
            {
                pbEmployeeImage = null;

            }

        }
        private bool _CheckIDTextBox()
        {
            if (!int.TryParse(tbID.Text, out _))
            {
                errorProvider1.SetError(tbID, "Pleace enter a number");
                MessageBox.Show("Pleace enter a number!");
                return false;
            }
            else
            {
                errorProvider1.Clear();
                return true;
            }
        }
        private void btnSearchByID_Click(object sender, EventArgs e)
        {
            if (_CheckIDTextBox())
            {
                _EmployeeID = int.Parse(tbID.Text);

                _Employee = clsEmployee.FindEmpolyeeByIDWithIDs(_EmployeeID);

                if (_Employee != null)
                {
                    ResultPanel.Visible = true;
                    _LoadData();
                }
                else
                {
                    MessageBox.Show($"Employees With {tbID.Text} not found!");
                    tbID.Clear();
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                if (clsEmployee.DeleteEmployee(_EmployeeID))
                {
                    MessageBox.Show("Data Deleted Successfully.");
                    ResultPanel.Visible = false;
                }
                else
                    MessageBox.Show("Error: Data is not deleted successfully.");

            }
        }
    }
}
