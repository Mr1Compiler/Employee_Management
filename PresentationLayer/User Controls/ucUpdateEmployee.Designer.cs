namespace PresentationLayer.User_Controls
{
    partial class ucUpdateEmployee
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
            this.btnSearchByID = new Guna.UI2.WinForms.Guna2GradientButton();
            this.tbID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ResultPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnRemovePhoto = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSetPhoto = new Guna.UI2.WinForms.Guna2GradientButton();
            this.DateOfBirth = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnCancel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2GradientButton();
            this.tbBonusPrec = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbMonthlySalary = new Guna.UI2.WinForms.Guna2TextBox();
            this.ExitDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.HireDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cbCountries = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbDepartments = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tbLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.pbEmployeeImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.fff = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.ResultPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployeeImage)).BeginInit();
            this.SuspendLayout();
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
            this.btnSearchByID.Location = new System.Drawing.Point(613, 74);
            this.btnSearchByID.Name = "btnSearchByID";
            this.btnSearchByID.ShadowDecoration.Parent = this.btnSearchByID;
            this.btnSearchByID.Size = new System.Drawing.Size(158, 34);
            this.btnSearchByID.TabIndex = 22;
            this.btnSearchByID.Text = "Search";
            this.btnSearchByID.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnSearchByID.Click += new System.EventHandler(this.btnSearchByID_Click);
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
            this.tbID.Location = new System.Drawing.Point(402, 73);
            this.tbID.Margin = new System.Windows.Forms.Padding(4);
            this.tbID.Name = "tbID";
            this.tbID.PasswordChar = '\0';
            this.tbID.PlaceholderText = "Enter Employee ID";
            this.tbID.SelectedText = "";
            this.tbID.ShadowDecoration.Parent = this.tbID;
            this.tbID.Size = new System.Drawing.Size(177, 35);
            this.tbID.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(150, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 22);
            this.label1.TabIndex = 23;
            this.label1.Text = "You should enter employee id:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ResultPanel
            // 
            this.ResultPanel.BackColor = System.Drawing.Color.Transparent;
            this.ResultPanel.Controls.Add(this.btnRemovePhoto);
            this.ResultPanel.Controls.Add(this.btnSetPhoto);
            this.ResultPanel.Controls.Add(this.DateOfBirth);
            this.ResultPanel.Controls.Add(this.btnCancel);
            this.ResultPanel.Controls.Add(this.btnUpdate);
            this.ResultPanel.Controls.Add(this.tbBonusPrec);
            this.ResultPanel.Controls.Add(this.tbMonthlySalary);
            this.ResultPanel.Controls.Add(this.ExitDate);
            this.ResultPanel.Controls.Add(this.HireDate);
            this.ResultPanel.Controls.Add(this.cbCountries);
            this.ResultPanel.Controls.Add(this.cbDepartments);
            this.ResultPanel.Controls.Add(this.tbLastName);
            this.ResultPanel.Controls.Add(this.tbFirstName);
            this.ResultPanel.Controls.Add(this.pbEmployeeImage);
            this.ResultPanel.Controls.Add(this.label11);
            this.ResultPanel.Controls.Add(this.fff);
            this.ResultPanel.Controls.Add(this.label10);
            this.ResultPanel.Controls.Add(this.label9);
            this.ResultPanel.Controls.Add(this.label8);
            this.ResultPanel.Controls.Add(this.label7);
            this.ResultPanel.Controls.Add(this.label6);
            this.ResultPanel.Controls.Add(this.label2);
            this.ResultPanel.Controls.Add(this.label3);
            this.ResultPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ResultPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ResultPanel.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ResultPanel.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ResultPanel.Location = new System.Drawing.Point(133, 201);
            this.ResultPanel.Name = "ResultPanel";
            this.ResultPanel.ShadowDecoration.Parent = this.ResultPanel;
            this.ResultPanel.Size = new System.Drawing.Size(789, 456);
            this.ResultPanel.TabIndex = 25;
            this.ResultPanel.Visible = false;
            // 
            // btnRemovePhoto
            // 
            this.btnRemovePhoto.Animated = true;
            this.btnRemovePhoto.AutoRoundedCorners = true;
            this.btnRemovePhoto.BackColor = System.Drawing.Color.Transparent;
            this.btnRemovePhoto.BorderRadius = 16;
            this.btnRemovePhoto.CheckedState.Parent = this.btnRemovePhoto;
            this.btnRemovePhoto.CustomImages.Parent = this.btnRemovePhoto;
            this.btnRemovePhoto.FillColor = System.Drawing.Color.White;
            this.btnRemovePhoto.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnRemovePhoto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemovePhoto.ForeColor = System.Drawing.Color.Black;
            this.btnRemovePhoto.HoverState.Parent = this.btnRemovePhoto;
            this.btnRemovePhoto.Location = new System.Drawing.Point(213, 96);
            this.btnRemovePhoto.Name = "btnRemovePhoto";
            this.btnRemovePhoto.ShadowDecoration.Parent = this.btnRemovePhoto;
            this.btnRemovePhoto.Size = new System.Drawing.Size(158, 35);
            this.btnRemovePhoto.TabIndex = 46;
            this.btnRemovePhoto.Text = "Remove Photo";
            this.btnRemovePhoto.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnRemovePhoto.Click += new System.EventHandler(this.btnRemovePhoto_Click);
            // 
            // btnSetPhoto
            // 
            this.btnSetPhoto.Animated = true;
            this.btnSetPhoto.AutoRoundedCorners = true;
            this.btnSetPhoto.BackColor = System.Drawing.Color.Transparent;
            this.btnSetPhoto.BorderRadius = 16;
            this.btnSetPhoto.CheckedState.Parent = this.btnSetPhoto;
            this.btnSetPhoto.CustomImages.Parent = this.btnSetPhoto;
            this.btnSetPhoto.FillColor = System.Drawing.Color.White;
            this.btnSetPhoto.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnSetPhoto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetPhoto.ForeColor = System.Drawing.Color.Black;
            this.btnSetPhoto.HoverState.Parent = this.btnSetPhoto;
            this.btnSetPhoto.Location = new System.Drawing.Point(213, 50);
            this.btnSetPhoto.Name = "btnSetPhoto";
            this.btnSetPhoto.ShadowDecoration.Parent = this.btnSetPhoto;
            this.btnSetPhoto.Size = new System.Drawing.Size(158, 35);
            this.btnSetPhoto.TabIndex = 45;
            this.btnSetPhoto.Text = "Set Photo";
            this.btnSetPhoto.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnSetPhoto.Click += new System.EventHandler(this.btnSetPhoto_Click);
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.CheckedState.Parent = this.DateOfBirth;
            this.DateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateOfBirth.HoverState.Parent = this.DateOfBirth;
            this.DateOfBirth.Location = new System.Drawing.Point(567, 171);
            this.DateOfBirth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DateOfBirth.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateOfBirth.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.ShadowDecoration.Parent = this.DateOfBirth;
            this.DateOfBirth.Size = new System.Drawing.Size(201, 25);
            this.DateOfBirth.TabIndex = 44;
            this.DateOfBirth.Value = new System.DateTime(2024, 8, 22, 13, 54, 48, 413);
            // 
            // btnCancel
            // 
            this.btnCancel.Animated = true;
            this.btnCancel.AutoRoundedCorners = true;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BorderRadius = 16;
            this.btnCancel.CheckedState.Parent = this.btnCancel;
            this.btnCancel.CustomImages.Parent = this.btnCancel;
            this.btnCancel.FillColor = System.Drawing.Color.White;
            this.btnCancel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.HoverState.Parent = this.btnCancel;
            this.btnCancel.Location = new System.Drawing.Point(209, 411);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(158, 34);
            this.btnCancel.TabIndex = 43;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Animated = true;
            this.btnUpdate.AutoRoundedCorners = true;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BorderRadius = 16;
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.btnUpdate.FillColor = System.Drawing.Color.White;
            this.btnUpdate.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Location = new System.Drawing.Point(393, 411);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(158, 34);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbBonusPrec
            // 
            this.tbBonusPrec.Animated = true;
            this.tbBonusPrec.BorderRadius = 8;
            this.tbBonusPrec.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbBonusPrec.DefaultText = "";
            this.tbBonusPrec.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbBonusPrec.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbBonusPrec.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbBonusPrec.DisabledState.Parent = this.tbBonusPrec;
            this.tbBonusPrec.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbBonusPrec.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbBonusPrec.FocusedState.Parent = this.tbBonusPrec;
            this.tbBonusPrec.ForeColor = System.Drawing.Color.Black;
            this.tbBonusPrec.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbBonusPrec.HoverState.Parent = this.tbBonusPrec;
            this.tbBonusPrec.Location = new System.Drawing.Point(567, 340);
            this.tbBonusPrec.Margin = new System.Windows.Forms.Padding(4);
            this.tbBonusPrec.Name = "tbBonusPrec";
            this.tbBonusPrec.PasswordChar = '\0';
            this.tbBonusPrec.PlaceholderText = "";
            this.tbBonusPrec.SelectedText = "";
            this.tbBonusPrec.ShadowDecoration.Parent = this.tbBonusPrec;
            this.tbBonusPrec.Size = new System.Drawing.Size(172, 28);
            this.tbBonusPrec.TabIndex = 42;
            // 
            // tbMonthlySalary
            // 
            this.tbMonthlySalary.Animated = true;
            this.tbMonthlySalary.BorderRadius = 8;
            this.tbMonthlySalary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMonthlySalary.DefaultText = "";
            this.tbMonthlySalary.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbMonthlySalary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbMonthlySalary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMonthlySalary.DisabledState.Parent = this.tbMonthlySalary;
            this.tbMonthlySalary.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMonthlySalary.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMonthlySalary.FocusedState.Parent = this.tbMonthlySalary;
            this.tbMonthlySalary.ForeColor = System.Drawing.Color.Black;
            this.tbMonthlySalary.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMonthlySalary.HoverState.Parent = this.tbMonthlySalary;
            this.tbMonthlySalary.Location = new System.Drawing.Point(183, 337);
            this.tbMonthlySalary.Margin = new System.Windows.Forms.Padding(4);
            this.tbMonthlySalary.Name = "tbMonthlySalary";
            this.tbMonthlySalary.PasswordChar = '\0';
            this.tbMonthlySalary.PlaceholderText = "";
            this.tbMonthlySalary.SelectedText = "";
            this.tbMonthlySalary.ShadowDecoration.Parent = this.tbMonthlySalary;
            this.tbMonthlySalary.Size = new System.Drawing.Size(172, 28);
            this.tbMonthlySalary.TabIndex = 41;
            // 
            // ExitDate
            // 
            this.ExitDate.CheckedState.Parent = this.ExitDate;
            this.ExitDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.ExitDate.HoverState.Parent = this.ExitDate;
            this.ExitDate.Location = new System.Drawing.Point(567, 279);
            this.ExitDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ExitDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ExitDate.Name = "ExitDate";
            this.ExitDate.ShadowDecoration.Parent = this.ExitDate;
            this.ExitDate.Size = new System.Drawing.Size(201, 26);
            this.ExitDate.TabIndex = 40;
            this.ExitDate.Value = new System.DateTime(2024, 8, 22, 13, 54, 48, 413);
            // 
            // HireDate
            // 
            this.HireDate.CheckedState.Parent = this.HireDate;
            this.HireDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.HireDate.HoverState.Parent = this.HireDate;
            this.HireDate.Location = new System.Drawing.Point(567, 218);
            this.HireDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HireDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.HireDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.HireDate.Name = "HireDate";
            this.HireDate.ShadowDecoration.Parent = this.HireDate;
            this.HireDate.Size = new System.Drawing.Size(201, 25);
            this.HireDate.TabIndex = 39;
            this.HireDate.Value = new System.DateTime(2024, 8, 22, 13, 54, 48, 413);
            // 
            // cbCountries
            // 
            this.cbCountries.BackColor = System.Drawing.Color.Transparent;
            this.cbCountries.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCountries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountries.FocusedColor = System.Drawing.Color.Empty;
            this.cbCountries.FocusedState.Parent = this.cbCountries;
            this.cbCountries.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbCountries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.cbCountries.FormattingEnabled = true;
            this.cbCountries.HoverState.Parent = this.cbCountries;
            this.cbCountries.ItemHeight = 30;
            this.cbCountries.ItemsAppearance.Parent = this.cbCountries;
            this.cbCountries.Location = new System.Drawing.Point(567, 105);
            this.cbCountries.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCountries.Name = "cbCountries";
            this.cbCountries.ShadowDecoration.Parent = this.cbCountries;
            this.cbCountries.Size = new System.Drawing.Size(178, 36);
            this.cbCountries.TabIndex = 37;
            // 
            // cbDepartments
            // 
            this.cbDepartments.BackColor = System.Drawing.Color.Transparent;
            this.cbDepartments.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDepartments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartments.FocusedColor = System.Drawing.Color.Empty;
            this.cbDepartments.FocusedState.Parent = this.cbDepartments;
            this.cbDepartments.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbDepartments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.cbDepartments.FormattingEnabled = true;
            this.cbDepartments.HoverState.Parent = this.cbDepartments;
            this.cbDepartments.ItemHeight = 30;
            this.cbDepartments.ItemsAppearance.Parent = this.cbDepartments;
            this.cbDepartments.Location = new System.Drawing.Point(567, 49);
            this.cbDepartments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDepartments.Name = "cbDepartments";
            this.cbDepartments.ShadowDecoration.Parent = this.cbDepartments;
            this.cbDepartments.Size = new System.Drawing.Size(178, 36);
            this.cbDepartments.TabIndex = 36;
            // 
            // tbLastName
            // 
            this.tbLastName.Animated = true;
            this.tbLastName.BorderRadius = 8;
            this.tbLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbLastName.DefaultText = "";
            this.tbLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbLastName.DisabledState.Parent = this.tbLastName;
            this.tbLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbLastName.FocusedState.Parent = this.tbLastName;
            this.tbLastName.ForeColor = System.Drawing.Color.Black;
            this.tbLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbLastName.HoverState.Parent = this.tbLastName;
            this.tbLastName.Location = new System.Drawing.Point(141, 270);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(4);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.PasswordChar = '\0';
            this.tbLastName.PlaceholderText = "";
            this.tbLastName.SelectedText = "";
            this.tbLastName.ShadowDecoration.Parent = this.tbLastName;
            this.tbLastName.Size = new System.Drawing.Size(192, 28);
            this.tbLastName.TabIndex = 35;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Animated = true;
            this.tbFirstName.BorderRadius = 8;
            this.tbFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFirstName.DefaultText = "";
            this.tbFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFirstName.DisabledState.Parent = this.tbFirstName;
            this.tbFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFirstName.FocusedState.Parent = this.tbFirstName;
            this.tbFirstName.ForeColor = System.Drawing.Color.Black;
            this.tbFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFirstName.HoverState.Parent = this.tbFirstName;
            this.tbFirstName.Location = new System.Drawing.Point(143, 213);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.PasswordChar = '\0';
            this.tbFirstName.PlaceholderText = "";
            this.tbFirstName.SelectedText = "";
            this.tbFirstName.ShadowDecoration.Parent = this.tbFirstName;
            this.tbFirstName.Size = new System.Drawing.Size(192, 28);
            this.tbFirstName.TabIndex = 26;
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
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(435, 343);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 22);
            this.label11.TabIndex = 32;
            this.label11.Text = "Bonus Prec:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // fff
            // 
            this.fff.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fff.ForeColor = System.Drawing.Color.White;
            this.fff.Location = new System.Drawing.Point(38, 343);
            this.fff.Name = "fff";
            this.fff.Size = new System.Drawing.Size(158, 22);
            this.fff.TabIndex = 30;
            this.fff.Text = "Monthly Salary:";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(450, 283);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 22);
            this.label10.TabIndex = 28;
            this.label10.Text = "Exit Date:";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(447, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 22);
            this.label9.TabIndex = 26;
            this.label9.Text = "Hire Date:";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(422, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 22);
            this.label8.TabIndex = 24;
            this.label8.Text = "Department";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(442, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 22);
            this.label7.TabIndex = 22;
            this.label7.Text = "Country Name:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(437, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 22);
            this.label6.TabIndex = 20;
            this.label6.Text = "Date Of Birth:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(38, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(39, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "First Name:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ucUpdateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.ResultPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearchByID);
            this.Controls.Add(this.tbID);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucUpdateEmployee";
            this.Size = new System.Drawing.Size(1014, 660);
            this.Load += new System.EventHandler(this.ucUpdateEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResultPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployeeImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btnSearchByID;
        private Guna.UI2.WinForms.Guna2TextBox tbID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel ResultPanel;
        private Guna.UI2.WinForms.Guna2PictureBox pbEmployeeImage;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label fff;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cbDepartments;
        private Guna.UI2.WinForms.Guna2TextBox tbLastName;
        private Guna.UI2.WinForms.Guna2TextBox tbFirstName;
        private Guna.UI2.WinForms.Guna2ComboBox cbCountries;
        private Guna.UI2.WinForms.Guna2TextBox tbBonusPrec;
        private Guna.UI2.WinForms.Guna2TextBox tbMonthlySalary;
        private Guna.UI2.WinForms.Guna2DateTimePicker ExitDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker HireDate;
        private Guna.UI2.WinForms.Guna2GradientButton btnCancel;
        private Guna.UI2.WinForms.Guna2GradientButton btnUpdate;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateOfBirth;
        private Guna.UI2.WinForms.Guna2GradientButton btnRemovePhoto;
        private Guna.UI2.WinForms.Guna2GradientButton btnSetPhoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
