using BusinessLayer;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.User_Controls
{
    public partial class ucAddEmployee : UserControl
    {
        public ucAddEmployee()
        {
            InitializeComponent();
        }

        private void _FillCountriesComboBox()
        {
            DataTable dtCountries = clsCountry.GetAllCountries();

            foreach (DataRow row in dtCountries.Rows)
            {
                cbCountries.Items.Add(row["Name"]);
            }
        }

        clsEmployee _Employee;
        private void _FillDepartmentsComboBox()
        {
            DataTable dtDepartments = clsDepartment.GetAllCountries();

            foreach (DataRow row in dtDepartments.Rows)
            {
                cbDepartments.Items.Add(row["Name"]);
            }
        }
        private void _Load()
        {
            _Employee = new clsEmployee();
            btnRemovePhoto.Visible = false;
            _FillCountriesComboBox();
            cbCountries.SelectedIndex = 0;
            _FillDepartmentsComboBox();
            cbDepartments.SelectedIndex = 0;
            cbGendor.SelectedIndex = 0;
            tbFirstName.Clear();
            tbLastName.Clear();
            tbMonthlySalary.Clear();
            pbEmployeeImage.Image = null;
        }

        private void ucAddEmployee_Load(object sender, EventArgs e)
        {
            _Load();
        }

        private void btnRemovePhoto_Click(object sender, EventArgs e)
        {
            pbEmployeeImage.ImageLocation = null;
            btnRemovePhoto.Visible = false;
        }

        private void btnSetPhoto_Click(object sender, EventArgs e)
        {
            btnRemovePhoto.Visible = true;
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;
                pbEmployeeImage.Load(selectedFilePath);
            }
        }

        private bool _CheckIsTextBoxNullOrEmpty(Guna2TextBox tb)
        {
            return (string.IsNullOrEmpty(tb.Text) ||
                string.IsNullOrWhiteSpace(tb.Text));

        }

        private bool _IsString(string str)
        {
            return (str.All(char.IsLetter));
        }

        private bool _IsErrorSet(ErrorProvider ep,Guna2TextBox tb)
        {
            return (!string.IsNullOrEmpty(ep.GetError(tb)));
        }
        private bool _CheckEmptyData()
        {
            bool Pass = false;

            if (_CheckIsTextBoxNullOrEmpty(tbFirstName) || !_IsString(tbFirstName.Text))
            {
                epFirstName.SetError(tbFirstName, "Pleace enter name");
            }
            else
            {
                epFirstName.Clear();
            }

            if (_CheckIsTextBoxNullOrEmpty(tbLastName) || !_IsString(tbLastName.Text))
            {
                epLastName.SetError(tbLastName, "Pleace enter name");
            }
            else
            {
                epLastName.Clear();
            }

            if (_CheckIsTextBoxNullOrEmpty(tbMonthlySalary) || !decimal.TryParse(tbMonthlySalary.Text, out _))
            {
                epMonthlySalary.SetError(tbMonthlySalary, "Pleace enter number");
            }
            else
            {
                epMonthlySalary.Clear();
            }


            if (!double.TryParse(tbBonusPrec.Text, out _))
            {
                epBonusPrec.SetError(tbBonusPrec, "Pleace enter number");
                Pass = false;
            }
            else
            {
                epBonusPrec.Clear();
            }


            if (_IsErrorSet(epFirstName, tbFirstName) || _IsErrorSet(epLastName, tbLastName) ||
                _IsErrorSet(epMonthlySalary, tbMonthlySalary) || _IsErrorSet(epBonusPrec, tbBonusPrec))
            {
                return false;
            }
            else
                return true;
        }

        private char CheckGendor()
        {
            if (cbGendor.Text == "Male") return 'M';
            else
                return 'F';
        }
        private void _AssignDataToEmployee()
        {
            _Employee.FirstName = tbFirstName.Text;
            _Employee.LastName = tbLastName.Text;
            _Employee.MonthlySalary = Convert.ToDecimal(tbMonthlySalary.Text);
            _Employee.Gender = CheckGendor().ToString();
            _Employee.DepartmentID = clsDepartment.Find(cbDepartments.Text).ID;
            _Employee.CountryID = clsCountry.Find(cbCountries.Text).ID;
            _Employee.DateOfBirth = DateOfBirth.Value;
            _Employee.HireDate = HireDate.Value;
            _Employee.ExitDate = ExitDate.Value;
            _Employee.BonusPerc = Convert.ToDouble(tbBonusPrec.Text);
            _Employee.FullName = _Employee.FirstName + " " + _Employee.LastName;

            if (pbEmployeeImage.Image != null)
            {
                _Employee.ImagePath = pbEmployeeImage.ImageLocation;
            }
            else
                _Employee.ImagePath = "";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (!_CheckEmptyData())
            {
                MessageBox.Show("Pleace enter all data correctly!");
            }
            else
            {
                if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _AssignDataToEmployee();

                    if (_Employee.Save())
                    {
                        MessageBox.Show("New Employee added Successfully.");
                        _Load();
                    }
                    else
                        MessageBox.Show("Error: Employee not added successfully.");
                }
            }
        }
    }
}
