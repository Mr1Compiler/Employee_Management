namespace PresentationLayer.Main_Form
{
    partial class frmMainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainForm));
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnSignout = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pbAdminImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnAddEmployee = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnDeleteEmployee = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnUpdateEmployee = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSearch = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnShowAdminProfile = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnShowAllEmployees = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.ucAddEmployee1 = new PresentationLayer.User_Controls.ucAddEmployee();
            this.ucDeleteEmployee1 = new PresentationLayer.User_Controls.ucDeleteEmployee();
            this.ucUpdateEmployee1 = new PresentationLayer.User_Controls.ucUpdateEmployee();
            this.ucSearchEmployee1 = new PresentationLayer.User_Controls.ucSearchEmployee();
            this.ucAdminProfile1 = new PresentationLayer.User_Controls.ucAdminProfile();
            this.ucShowAllEmployees1 = new PresentationLayer.User_Controls.ucShowAllEmployees();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdminImage)).BeginInit();
            this.guna2CustomGradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2CustomGradientPanel1.Controls.Add(this.btnSignout);
            this.guna2CustomGradientPanel1.Controls.Add(this.pbAdminImage);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnAddEmployee);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnDeleteEmployee);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnUpdateEmployee);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnSearch);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnShowAdminProfile);
            this.guna2CustomGradientPanel1.Controls.Add(this.lblUsername);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnShowAllEmployees);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(-1, 4);
            this.guna2CustomGradientPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(258, 825);
            this.guna2CustomGradientPanel1.TabIndex = 1;
            // 
            // btnSignout
            // 
            this.btnSignout.Animated = true;
            this.btnSignout.AutoRoundedCorners = true;
            this.btnSignout.BackColor = System.Drawing.Color.Transparent;
            this.btnSignout.BorderRadius = 20;
            this.btnSignout.CheckedState.Parent = this.btnSignout;
            this.btnSignout.CustomImages.Parent = this.btnSignout;
            this.btnSignout.FillColor = System.Drawing.Color.White;
            this.btnSignout.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnSignout.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignout.ForeColor = System.Drawing.Color.Black;
            this.btnSignout.HoverState.Parent = this.btnSignout;
            this.btnSignout.Location = new System.Drawing.Point(13, 770);
            this.btnSignout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSignout.Name = "btnSignout";
            this.btnSignout.ShadowDecoration.Parent = this.btnSignout;
            this.btnSignout.Size = new System.Drawing.Size(230, 42);
            this.btnSignout.TabIndex = 25;
            this.btnSignout.Text = "Sign out";
            this.btnSignout.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnSignout.Click += new System.EventHandler(this.btnSignout_Click);
            // 
            // pbAdminImage
            // 
            this.pbAdminImage.BackColor = System.Drawing.Color.Transparent;
            this.pbAdminImage.Location = new System.Drawing.Point(83, 11);
            this.pbAdminImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbAdminImage.Name = "pbAdminImage";
            this.pbAdminImage.ShadowDecoration.Parent = this.pbAdminImage;
            this.pbAdminImage.Size = new System.Drawing.Size(74, 79);
            this.pbAdminImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAdminImage.TabIndex = 23;
            this.pbAdminImage.TabStop = false;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Animated = true;
            this.btnAddEmployee.AutoRoundedCorners = true;
            this.btnAddEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btnAddEmployee.BorderRadius = 20;
            this.btnAddEmployee.CheckedState.Parent = this.btnAddEmployee;
            this.btnAddEmployee.CustomImages.Parent = this.btnAddEmployee;
            this.btnAddEmployee.FillColor = System.Drawing.Color.White;
            this.btnAddEmployee.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnAddEmployee.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnAddEmployee.HoverState.Parent = this.btnAddEmployee;
            this.btnAddEmployee.Location = new System.Drawing.Point(15, 524);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.ShadowDecoration.Parent = this.btnAddEmployee;
            this.btnAddEmployee.Size = new System.Drawing.Size(230, 42);
            this.btnAddEmployee.TabIndex = 18;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Animated = true;
            this.btnDeleteEmployee.AutoRoundedCorners = true;
            this.btnDeleteEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteEmployee.BorderRadius = 20;
            this.btnDeleteEmployee.CheckedState.Parent = this.btnDeleteEmployee;
            this.btnDeleteEmployee.CustomImages.Parent = this.btnDeleteEmployee;
            this.btnDeleteEmployee.FillColor = System.Drawing.Color.White;
            this.btnDeleteEmployee.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnDeleteEmployee.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteEmployee.HoverState.Parent = this.btnDeleteEmployee;
            this.btnDeleteEmployee.Location = new System.Drawing.Point(13, 457);
            this.btnDeleteEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.ShadowDecoration.Parent = this.btnDeleteEmployee;
            this.btnDeleteEmployee.Size = new System.Drawing.Size(230, 42);
            this.btnDeleteEmployee.TabIndex = 17;
            this.btnDeleteEmployee.Text = "Delete Employee";
            this.btnDeleteEmployee.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.Animated = true;
            this.btnUpdateEmployee.AutoRoundedCorners = true;
            this.btnUpdateEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateEmployee.BorderRadius = 20;
            this.btnUpdateEmployee.CheckedState.Parent = this.btnUpdateEmployee;
            this.btnUpdateEmployee.CustomImages.Parent = this.btnUpdateEmployee;
            this.btnUpdateEmployee.FillColor = System.Drawing.Color.White;
            this.btnUpdateEmployee.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnUpdateEmployee.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateEmployee.HoverState.Parent = this.btnUpdateEmployee;
            this.btnUpdateEmployee.Location = new System.Drawing.Point(13, 389);
            this.btnUpdateEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.ShadowDecoration.Parent = this.btnUpdateEmployee;
            this.btnUpdateEmployee.Size = new System.Drawing.Size(230, 42);
            this.btnUpdateEmployee.TabIndex = 16;
            this.btnUpdateEmployee.Text = "Update Employee";
            this.btnUpdateEmployee.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Animated = true;
            this.btnSearch.AutoRoundedCorners = true;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BorderRadius = 20;
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.FillColor = System.Drawing.Color.White;
            this.btnSearch.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(13, 321);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(230, 42);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnShowAdminProfile
            // 
            this.btnShowAdminProfile.Animated = true;
            this.btnShowAdminProfile.AutoRoundedCorners = true;
            this.btnShowAdminProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnShowAdminProfile.BorderRadius = 20;
            this.btnShowAdminProfile.CheckedState.Parent = this.btnShowAdminProfile;
            this.btnShowAdminProfile.CustomImages.Parent = this.btnShowAdminProfile;
            this.btnShowAdminProfile.FillColor = System.Drawing.Color.White;
            this.btnShowAdminProfile.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnShowAdminProfile.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAdminProfile.ForeColor = System.Drawing.Color.Black;
            this.btnShowAdminProfile.HoverState.Parent = this.btnShowAdminProfile;
            this.btnShowAdminProfile.Location = new System.Drawing.Point(13, 186);
            this.btnShowAdminProfile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowAdminProfile.Name = "btnShowAdminProfile";
            this.btnShowAdminProfile.ShadowDecoration.Parent = this.btnShowAdminProfile;
            this.btnShowAdminProfile.Size = new System.Drawing.Size(230, 42);
            this.btnShowAdminProfile.TabIndex = 14;
            this.btnShowAdminProfile.Text = "Show Profile";
            this.btnShowAdminProfile.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnShowAdminProfile.Click += new System.EventHandler(this.btnShowAdminProfile_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(70, 100);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(134, 22);
            this.lblUsername.TabIndex = 13;
            // 
            // btnShowAllEmployees
            // 
            this.btnShowAllEmployees.Animated = true;
            this.btnShowAllEmployees.AutoRoundedCorners = true;
            this.btnShowAllEmployees.BackColor = System.Drawing.Color.Transparent;
            this.btnShowAllEmployees.BorderRadius = 20;
            this.btnShowAllEmployees.CheckedState.Parent = this.btnShowAllEmployees;
            this.btnShowAllEmployees.CustomImages.Parent = this.btnShowAllEmployees;
            this.btnShowAllEmployees.FillColor = System.Drawing.Color.White;
            this.btnShowAllEmployees.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnShowAllEmployees.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllEmployees.ForeColor = System.Drawing.Color.Black;
            this.btnShowAllEmployees.HoverState.Parent = this.btnShowAllEmployees;
            this.btnShowAllEmployees.Location = new System.Drawing.Point(13, 254);
            this.btnShowAllEmployees.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowAllEmployees.Name = "btnShowAllEmployees";
            this.btnShowAllEmployees.ShadowDecoration.Parent = this.btnShowAllEmployees;
            this.btnShowAllEmployees.Size = new System.Drawing.Size(230, 42);
            this.btnShowAllEmployees.TabIndex = 10;
            this.btnShowAllEmployees.Text = "Show All employees";
            this.btnShowAllEmployees.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnShowAllEmployees.Click += new System.EventHandler(this.btnShowEmployees_Click);
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.Controls.Add(this.ucAddEmployee1);
            this.guna2CustomGradientPanel2.Controls.Add(this.ucDeleteEmployee1);
            this.guna2CustomGradientPanel2.Controls.Add(this.ucUpdateEmployee1);
            this.guna2CustomGradientPanel2.Controls.Add(this.ucSearchEmployee1);
            this.guna2CustomGradientPanel2.Controls.Add(this.ucAdminProfile1);
            this.guna2CustomGradientPanel2.Controls.Add(this.ucShowAllEmployees1);
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(264, 4);
            this.guna2CustomGradientPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.ShadowDecoration.Parent = this.guna2CustomGradientPanel2;
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(1183, 825);
            this.guna2CustomGradientPanel2.TabIndex = 2;
            // 
            // ucAddEmployee1
            // 
            this.ucAddEmployee1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ucAddEmployee1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAddEmployee1.Location = new System.Drawing.Point(0, 0);
            this.ucAddEmployee1.Margin = new System.Windows.Forms.Padding(5);
            this.ucAddEmployee1.Name = "ucAddEmployee1";
            this.ucAddEmployee1.Size = new System.Drawing.Size(1183, 825);
            this.ucAddEmployee1.TabIndex = 5;
            // 
            // ucDeleteEmployee1
            // 
            this.ucDeleteEmployee1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ucDeleteEmployee1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDeleteEmployee1.Location = new System.Drawing.Point(0, 0);
            this.ucDeleteEmployee1.Margin = new System.Windows.Forms.Padding(5);
            this.ucDeleteEmployee1.Name = "ucDeleteEmployee1";
            this.ucDeleteEmployee1.Size = new System.Drawing.Size(1183, 825);
            this.ucDeleteEmployee1.TabIndex = 4;
            // 
            // ucUpdateEmployee1
            // 
            this.ucUpdateEmployee1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ucUpdateEmployee1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucUpdateEmployee1.Location = new System.Drawing.Point(0, 0);
            this.ucUpdateEmployee1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ucUpdateEmployee1.Name = "ucUpdateEmployee1";
            this.ucUpdateEmployee1.Size = new System.Drawing.Size(1183, 825);
            this.ucUpdateEmployee1.TabIndex = 3;
            // 
            // ucSearchEmployee1
            // 
            this.ucSearchEmployee1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ucSearchEmployee1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSearchEmployee1.Location = new System.Drawing.Point(0, 0);
            this.ucSearchEmployee1.Margin = new System.Windows.Forms.Padding(5);
            this.ucSearchEmployee1.Name = "ucSearchEmployee1";
            this.ucSearchEmployee1.Size = new System.Drawing.Size(1183, 825);
            this.ucSearchEmployee1.TabIndex = 2;
            // 
            // ucAdminProfile1
            // 
            this.ucAdminProfile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ucAdminProfile1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAdminProfile1.Location = new System.Drawing.Point(0, 0);
            this.ucAdminProfile1.Margin = new System.Windows.Forms.Padding(5);
            this.ucAdminProfile1.Name = "ucAdminProfile1";
            this.ucAdminProfile1.Size = new System.Drawing.Size(1183, 825);
            this.ucAdminProfile1.TabIndex = 1;
            // 
            // ucShowAllEmployees1
            // 
            this.ucShowAllEmployees1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucShowAllEmployees1.Location = new System.Drawing.Point(0, 0);
            this.ucShowAllEmployees1.Margin = new System.Windows.Forms.Padding(5);
            this.ucShowAllEmployees1.Name = "ucShowAllEmployees1";
            this.ucShowAllEmployees1.Size = new System.Drawing.Size(1183, 825);
            this.ucShowAllEmployees1.TabIndex = 0;
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1448, 831);
            this.Controls.Add(this.guna2CustomGradientPanel2);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Employee Management";
            this.Load += new System.EventHandler(this.frmMainForm_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAdminImage)).EndInit();
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private User_Controls.ucShowAllEmployees ucShowAllEmployees1;
        private Guna.UI2.WinForms.Guna2GradientButton btnShowAllEmployees;
        private User_Controls.ucAdminProfile ucAdminProfile1;
        private System.Windows.Forms.Label lblUsername;
        private Guna.UI2.WinForms.Guna2GradientButton btnShowAdminProfile;
        private Guna.UI2.WinForms.Guna2GradientButton btnSearch;
        private User_Controls.ucSearchEmployee ucSearchEmployee1;
        private Guna.UI2.WinForms.Guna2GradientButton btnUpdateEmployee;
        private User_Controls.ucUpdateEmployee ucUpdateEmployee1;
        private Guna.UI2.WinForms.Guna2GradientButton btnDeleteEmployee;
        private User_Controls.ucDeleteEmployee ucDeleteEmployee1;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddEmployee;
        private User_Controls.ucAddEmployee ucAddEmployee1;
        private Guna.UI2.WinForms.Guna2PictureBox pbAdminImage;
        private Guna.UI2.WinForms.Guna2GradientButton btnSignout;
        //  private User_Controls.ucSearchEmployee searchEmployee1;
    }
}