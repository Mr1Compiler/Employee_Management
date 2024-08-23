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
    public partial class ucUpdateEmployee : UserControl
    {
        int _EmployeeID;
        clsEmployee _Employee;

        public ucUpdateEmployee()
        {
            InitializeComponent();
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



        private void ucUpdateEmployee_Load(object sender, EventArgs e)
        {

        }

        private void _FillCountriesComboBox()
        {
            cbCountries.Items.Clear();
            DataTable dtCountries = clsCountry.GetAllCountries();

            foreach (DataRow row in dtCountries.Rows)
            {
                cbCountries.Items.Add(row["Name"]);
            }
        }

        private void _FillDepartmentsComboBox()
        {
            cbDepartments.Items.Clear();
            DataTable dtDepartments = clsDepartment.GetAllCountries();

            foreach (DataRow row in dtDepartments.Rows)
            {
                cbDepartments.Items.Add(row["Name"]);
            }
        }

        private void _UpdateEmployee()
        {
            int CountryID = clsCountry.Find(cbCountries.Text).ID;
            int DepartmentID = clsDepartment.Find(cbDepartments.Text).ID;

            _Employee.FirstName = tbFirstName.Text;
            _Employee.LastName = tbLastName.Text;
            _Employee.MonthlySalary = Convert.ToDecimal(tbMonthlySalary.Text);
            _Employee.DateOfBirth = DateOfBirth.Value;
            _Employee.HireDate = HireDate.Value;
            _Employee.ExitDate = ExitDate.Value;
            _Employee.BonusPerc = Convert.ToDouble(tbBonusPrec.Text);
            _Employee.CountryID = CountryID;
            _Employee.DepartmentID = DepartmentID;
            _Employee.FullName = _Employee.FirstName + " " + _Employee.LastName;

            if (pbEmployeeImage.ImageLocation != null)
            {
                _Employee.ImagePath = pbEmployeeImage.ImageLocation;
            }
            else
            {
                _Employee.ImagePath = "";
            }

           

            
        }
        private void _LoadData()
        {
            _FillCountriesComboBox();
            cbCountries.SelectedIndex = 0;
            _FillDepartmentsComboBox();
            cbDepartments.SelectedIndex = 0;
            

            tbFirstName.Text = _Employee.FirstName;
            tbLastName.Text= _Employee.LastName;
            tbMonthlySalary.Text = _Employee.MonthlySalary.ToString();
            DateOfBirth.Value = _Employee.DateOfBirth;
            HireDate.Value = _Employee.HireDate;
            ExitDate.Value = _Employee.ExitDate;
            tbBonusPrec.Text = _Employee.BonusPerc.ToString();

            if (_Employee.ImagePath != null)
            {
                pbEmployeeImage.ImageLocation = _Employee.ImagePath;
            }
            else
                _Employee.ImagePath = "";

            cbCountries.SelectedIndex = cbCountries.FindString(clsCountry.Find(_Employee.CountryID).Name);

            btnRemovePhoto.Visible = (_Employee.ImagePath != null);

            cbDepartments.SelectedIndex = cbDepartments.FindString(clsDepartment.Find(_Employee.DepartmentID).Name);

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

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _UpdateEmployee();

                if (_Employee.Save())
                    MessageBox.Show("Data Sved Successfully.");
                else
                    MessageBox.Show("Error: Data is not saved successfully.");

            }
        }

        private void btnSetPhoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;
                pbEmployeeImage.Load(selectedFilePath);
            }
        }

        private void btnRemovePhoto_Click(object sender, EventArgs e)
        {
            pbEmployeeImage.ImageLocation = null;
            btnRemovePhoto.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _LoadData();
        }
    }
}
