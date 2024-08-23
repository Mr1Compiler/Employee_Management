namespace PresentationLayer.User_Controls
{
    partial class ucSearchEmployee
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSearchEmployee));
            this.tbID = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ResultPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.pbEmployeeImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblBonusPrec = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblMonthlySalary = new System.Windows.Forms.Label();
            this.fff = new System.Windows.Forms.Label();
            this.lblExitDate = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblHireDate = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDepartmentName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCountryName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblGendor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchByID = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSearchByName = new Guna.UI2.WinForms.Guna2GradientButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ucShowAllEmployees1 = new PresentationLayer.User_Controls.ucShowAllEmployees();
            this.ResultPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployeeImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbID
            // 
            this.tbID.Animated = true;
            this.tbID.BorderRadius = 8;
            this.tbID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbID.DefaultText = "";
            this.tbID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbID.DisabledState.Parent = this.tbID;
            this.tbID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbID.FocusedState.Parent = this.tbID;
            this.tbID.ForeColor = System.Drawing.Color.Black;
            this.tbID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbID.HoverState.Parent = this.tbID;
            this.tbID.Location = new System.Drawing.Point(351, 109);
            this.tbID.Margin = new System.Windows.Forms.Padding(4);
            this.tbID.Name = "tbID";
            this.tbID.PasswordChar = '\0';
            this.tbID.PlaceholderText = "Enter Employee ID";
            this.tbID.SelectedText = "";
            this.tbID.ShadowDecoration.Parent = this.tbID;
            this.tbID.Size = new System.Drawing.Size(252, 35);
            this.tbID.TabIndex = 0;
            // 
            // tbName
            // 
            this.tbName.Animated = true;
            this.tbName.BorderRadius = 8;
            this.tbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbName.DefaultText = "";
            this.tbName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbName.DisabledState.Parent = this.tbName;
            this.tbName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbName.FocusedState.Parent = this.tbName;
            this.tbName.ForeColor = System.Drawing.Color.Black;
            this.tbName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbName.HoverState.Parent = this.tbName;
            this.tbName.Location = new System.Drawing.Point(351, 109);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.PasswordChar = '\0';
            this.tbName.PlaceholderText = "Enter Employee Name";
            this.tbName.SelectedText = "";
            this.tbName.ShadowDecoration.Parent = this.tbName;
            this.tbName.Size = new System.Drawing.Size(252, 35);
            this.tbName.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Animated = true;
            this.btnSearch.AutoRoundedCorners = true;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BorderRadius = 16;
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.FillColor = System.Drawing.Color.White;
            this.btnSearch.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(407, 169);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(158, 34);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Find";
            this.btnSearch.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // ResultPanel
            // 
            this.ResultPanel.BackColor = System.Drawing.Color.Transparent;
            this.ResultPanel.Controls.Add(this.pbEmployeeImage);
            this.ResultPanel.Controls.Add(this.lblBonusPrec);
            this.ResultPanel.Controls.Add(this.label11);
            this.ResultPanel.Controls.Add(this.lblMonthlySalary);
            this.ResultPanel.Controls.Add(this.fff);
            this.ResultPanel.Controls.Add(this.lblExitDate);
            this.ResultPanel.Controls.Add(this.label10);
            this.ResultPanel.Controls.Add(this.lblHireDate);
            this.ResultPanel.Controls.Add(this.label9);
            this.ResultPanel.Controls.Add(this.lblDepartmentName);
            this.ResultPanel.Controls.Add(this.label8);
            this.ResultPanel.Controls.Add(this.lblCountryName);
            this.ResultPanel.Controls.Add(this.label7);
            this.ResultPanel.Controls.Add(this.lblDateOfBirth);
            this.ResultPanel.Controls.Add(this.label6);
            this.ResultPanel.Controls.Add(this.lblGendor);
            this.ResultPanel.Controls.Add(this.label4);
            this.ResultPanel.Controls.Add(this.lblLastName);
            this.ResultPanel.Controls.Add(this.label2);
            this.ResultPanel.Controls.Add(this.lblFirstName);
            this.ResultPanel.Controls.Add(this.label3);
            this.ResultPanel.Controls.Add(this.lblEmployeeID);
            this.ResultPanel.Controls.Add(this.label1);
            this.ResultPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ResultPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ResultPanel.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ResultPanel.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ResultPanel.Location = new System.Drawing.Point(3, 250);
            this.ResultPanel.Name = "ResultPanel";
            this.ResultPanel.ShadowDecoration.Parent = this.ResultPanel;
            this.ResultPanel.Size = new System.Drawing.Size(1011, 370);
            this.ResultPanel.TabIndex = 18;
            this.ResultPanel.Visible = false;
            // 
            // pbEmployeeImage
            // 
            this.pbEmployeeImage.Location = new System.Drawing.Point(54, 18);
            this.pbEmployeeImage.Name = "pbEmployeeImage";
            this.pbEmployeeImage.ShadowDecoration.Parent = this.pbEmployeeImage;
            this.pbEmployeeImage.Size = new System.Drawing.Size(153, 141);
            this.pbEmployeeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEmployeeImage.TabIndex = 21;
            this.pbEmployeeImage.TabStop = false;
            // 
            // lblBonusPrec
            // 
            this.lblBonusPrec.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBonusPrec.ForeColor = System.Drawing.Color.White;
            this.lblBonusPrec.Location = new System.Drawing.Point(551, 270);
            this.lblBonusPrec.Name = "lblBonusPrec";
            this.lblBonusPrec.Size = new System.Drawing.Size(158, 22);
            this.lblBonusPrec.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(551, 248);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 22);
            this.label11.TabIndex = 32;
            this.label11.Text = "Bonue Prec:";
            // 
            // lblMonthlySalary
            // 
            this.lblMonthlySalary.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlySalary.ForeColor = System.Drawing.Color.White;
            this.lblMonthlySalary.Location = new System.Drawing.Point(551, 200);
            this.lblMonthlySalary.Name = "lblMonthlySalary";
            this.lblMonthlySalary.Size = new System.Drawing.Size(158, 22);
            this.lblMonthlySalary.TabIndex = 31;
            // 
            // fff
            // 
            this.fff.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fff.ForeColor = System.Drawing.Color.White;
            this.fff.Location = new System.Drawing.Point(551, 178);
            this.fff.Name = "fff";
            this.fff.Size = new System.Drawing.Size(158, 22);
            this.fff.TabIndex = 30;
            this.fff.Text = "Monthly Salary:";
            // 
            // lblExitDate
            // 
            this.lblExitDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExitDate.ForeColor = System.Drawing.Color.White;
            this.lblExitDate.Location = new System.Drawing.Point(551, 137);
            this.lblExitDate.Name = "lblExitDate";
            this.lblExitDate.Size = new System.Drawing.Size(193, 22);
            this.lblExitDate.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(551, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 22);
            this.label10.TabIndex = 28;
            this.label10.Text = "Exit Date:";
            // 
            // lblHireDate
            // 
            this.lblHireDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHireDate.ForeColor = System.Drawing.Color.White;
            this.lblHireDate.Location = new System.Drawing.Point(551, 53);
            this.lblHireDate.Name = "lblHireDate";
            this.lblHireDate.Size = new System.Drawing.Size(193, 22);
            this.lblHireDate.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(551, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 22);
            this.label9.TabIndex = 26;
            this.label9.Text = "Hire Date:";
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentName.ForeColor = System.Drawing.Color.White;
            this.lblDepartmentName.Location = new System.Drawing.Point(352, 270);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(158, 22);
            this.lblDepartmentName.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(352, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 22);
            this.label8.TabIndex = 24;
            this.label8.Text = "Department Name:";
            // 
            // lblCountryName
            // 
            this.lblCountryName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountryName.ForeColor = System.Drawing.Color.White;
            this.lblCountryName.Location = new System.Drawing.Point(352, 200);
            this.lblCountryName.Name = "lblCountryName";
            this.lblCountryName.Size = new System.Drawing.Size(117, 22);
            this.lblCountryName.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(352, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 22);
            this.label7.TabIndex = 22;
            this.label7.Text = "Country Name:";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirth.ForeColor = System.Drawing.Color.White;
            this.lblDateOfBirth.Location = new System.Drawing.Point(352, 137);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(117, 22);
            this.lblDateOfBirth.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(352, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 22);
            this.label6.TabIndex = 20;
            this.label6.Text = "Date Of Birth:";
            // 
            // lblGendor
            // 
            this.lblGendor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGendor.ForeColor = System.Drawing.Color.White;
            this.lblGendor.Location = new System.Drawing.Point(22, 270);
            this.lblGendor.Name = "lblGendor";
            this.lblGendor.Size = new System.Drawing.Size(127, 22);
            this.lblGendor.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 22);
            this.label4.TabIndex = 18;
            this.label4.Text = "Gendor:";
            // 
            // lblLastName
            // 
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.White;
            this.lblLastName.Location = new System.Drawing.Point(145, 200);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(117, 22);
            this.lblLastName.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(146, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.White;
            this.lblFirstName.Location = new System.Drawing.Point(22, 200);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(83, 22);
            this.lblFirstName.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "First Name:";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeID.ForeColor = System.Drawing.Color.White;
            this.lblEmployeeID.Location = new System.Drawing.Point(362, 53);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(83, 22);
            this.lblEmployeeID.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(361, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID:";
            // 
            // btnSearchByID
            // 
            this.btnSearchByID.Animated = true;
            this.btnSearchByID.AutoRoundedCorners = true;
            this.btnSearchByID.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchByID.BorderRadius = 16;
            this.btnSearchByID.CheckedState.Parent = this.btnSearchByID;
            this.btnSearchByID.CustomImages.Parent = this.btnSearchByID;
            this.btnSearchByID.FillColor = System.Drawing.Color.White;
            this.btnSearchByID.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnSearchByID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchByID.ForeColor = System.Drawing.Color.Black;
            this.btnSearchByID.HoverState.Parent = this.btnSearchByID;
            this.btnSearchByID.Location = new System.Drawing.Point(298, 53);
            this.btnSearchByID.Name = "btnSearchByID";
            this.btnSearchByID.ShadowDecoration.Parent = this.btnSearchByID;
            this.btnSearchByID.Size = new System.Drawing.Size(158, 34);
            this.btnSearchByID.TabIndex = 19;
            this.btnSearchByID.Text = "Search by ID";
            this.btnSearchByID.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnSearchByID.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // btnSearchByName
            // 
            this.btnSearchByName.Animated = true;
            this.btnSearchByName.AutoRoundedCorners = true;
            this.btnSearchByName.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchByName.BorderRadius = 16;
            this.btnSearchByName.CheckedState.Parent = this.btnSearchByName;
            this.btnSearchByName.CustomImages.Parent = this.btnSearchByName;
            this.btnSearchByName.FillColor = System.Drawing.Color.White;
            this.btnSearchByName.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnSearchByName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchByName.ForeColor = System.Drawing.Color.Black;
            this.btnSearchByName.HoverState.Parent = this.btnSearchByName;
            this.btnSearchByName.Location = new System.Drawing.Point(508, 53);
            this.btnSearchByName.Name = "btnSearchByName";
            this.btnSearchByName.ShadowDecoration.Parent = this.btnSearchByName;
            this.btnSearchByName.Size = new System.Drawing.Size(158, 34);
            this.btnSearchByName.TabIndex = 20;
            this.btnSearchByName.Text = "Search by Name";
            this.btnSearchByName.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnSearchByName.Click += new System.EventHandler(this.guna2GradientButton2_Click_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this.tbID;
            // 
            // ucShowAllEmployees1
            // 
            this.ucShowAllEmployees1.Location = new System.Drawing.Point(4, 250);
            this.ucShowAllEmployees1.Margin = new System.Windows.Forms.Padding(4);
            this.ucShowAllEmployees1.Name = "ucShowAllEmployees1";
            this.ucShowAllEmployees1.Size = new System.Drawing.Size(1007, 367);
            this.ucShowAllEmployees1.TabIndex = 21;
            this.ucShowAllEmployees1.Load += new System.EventHandler(this.ucShowAllEmployees1_Load);
            // 
            // ucSearchEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.ucShowAllEmployees1);
            this.Controls.Add(this.btnSearchByName);
            this.Controls.Add(this.btnSearchByID);
            this.Controls.Add(this.ResultPanel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbID);
            this.Name = "ucSearchEmployee";
            this.Size = new System.Drawing.Size(1014, 660);
            this.ResultPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployeeImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox tbID;
        private Guna.UI2.WinForms.Guna2TextBox tbName;
        private Guna.UI2.WinForms.Guna2GradientButton btnSearch;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel ResultPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGendor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCountryName;
        private System.Windows.Forms.Label lblBonusPrec;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblMonthlySalary;
        private System.Windows.Forms.Label fff;
        private System.Windows.Forms.Label lblExitDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblHireDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblDepartmentName;
        private Guna.UI2.WinForms.Guna2GradientButton btnSearchByID;
        private Guna.UI2.WinForms.Guna2GradientButton btnSearchByName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2PictureBox pbEmployeeImage;
        private ucShowAllEmployees ucShowAllEmployees1;
        // private User_Controls.ucSearchEmployee searchEmployee1;
    }
}
