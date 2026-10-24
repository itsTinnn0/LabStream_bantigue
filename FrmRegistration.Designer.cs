namespace LabStream
{
    partial class FrmRegistration
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
            lblTitle = new Label();
            lblStudentNo = new Label();
            txtStudentNo = new TextBox();
            lblProgram = new Label();
            cboProgram = new ComboBox();
            lblLastName = new Label();
            lblFirstName = new Label();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            lblMI = new Label();
            txtMI = new TextBox();
            txtAge = new TextBox();
            lblAge = new Label();
            lblGender = new Label();
            cboGender = new ComboBox();
            lblBirthday = new Label();
            dtpBirthday = new DateTimePicker();
            lblContact = new Label();
            txtContact = new TextBox();
            btnRegister = new Button();
            btnRecords = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(25, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(212, 42);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Registration";
            // 
            // lblStudentNo
            // 
            lblStudentNo.AutoSize = true;
            lblStudentNo.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentNo.ForeColor = Color.Black;
            lblStudentNo.Location = new Point(30, 95);
            lblStudentNo.Name = "lblStudentNo";
            lblStudentNo.Size = new Size(70, 15);
            lblStudentNo.TabIndex = 1;
            lblStudentNo.Text = "Student No.";
            // 
            // txtStudentNo
            // 
            txtStudentNo.Location = new Point(140, 92);
            txtStudentNo.MaxLength = 11;
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(140, 25);
            txtStudentNo.TabIndex = 2;
            // 
            // lblProgram
            // 
            lblProgram.AutoSize = true;
            lblProgram.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProgram.ForeColor = Color.Black;
            lblProgram.Location = new Point(330, 95);
            lblProgram.Name = "lblProgram";
            lblProgram.Size = new Size(56, 15);
            lblProgram.TabIndex = 3;
            lblProgram.Text = "Program";
            // 
            // cboProgram
            // 
            cboProgram.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProgram.FlatStyle = FlatStyle.Flat;
            cboProgram.FormattingEnabled = true;
            cboProgram.Items.AddRange(new object[] { "BS Information Technology", "BS Computer Science", "BS Business Administration", "BS Computer Engineering", "BS Criminology", "BS Tourism Management", "BS Hospitality Management" });
            cboProgram.Location = new Point(400, 92);
            cboProgram.Name = "cboProgram";
            cboProgram.Size = new Size(250, 25);
            cboProgram.TabIndex = 4;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLastName.ForeColor = Color.Black;
            lblLastName.Location = new Point(30, 140);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(65, 15);
            lblLastName.TabIndex = 5;
            lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFirstName.ForeColor = Color.Black;
            lblFirstName.Location = new Point(295, 140);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(68, 15);
            lblFirstName.TabIndex = 6;
            lblFirstName.Text = "First Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(140, 137);
            txtLastName.MaxLength = 100;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(140, 25);
            txtLastName.TabIndex = 7;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(385, 137);
            txtFirstName.MaxLength = 100;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(160, 25);
            txtFirstName.TabIndex = 8;
            // 
            // lblMI
            // 
            lblMI.AutoSize = true;
            lblMI.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMI.ForeColor = Color.Black;
            lblMI.Location = new Point(560, 140);
            lblMI.Name = "lblMI";
            lblMI.Size = new Size(28, 15);
            lblMI.TabIndex = 9;
            lblMI.Text = "M.I.";
            // 
            // txtMI
            // 
            txtMI.Location = new Point(600, 137);
            txtMI.MaxLength = 2;
            txtMI.Name = "txtMI";
            txtMI.Size = new Size(50, 25);
            txtMI.TabIndex = 10;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(140, 182);
            txtAge.MaxLength = 3;
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(80, 25);
            txtAge.TabIndex = 11;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAge.ForeColor = Color.Black;
            lblAge.Location = new Point(30, 185);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(29, 15);
            lblAge.TabIndex = 12;
            lblAge.Text = "Age";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGender.ForeColor = Color.Black;
            lblGender.Location = new Point(260, 185);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(47, 15);
            lblGender.TabIndex = 13;
            lblGender.Text = "Gender";
            // 
            // cboGender
            // 
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGender.FlatStyle = FlatStyle.Flat;
            cboGender.FormattingEnabled = true;
            cboGender.Items.AddRange(new object[] { "Male", "Female" });
            cboGender.Location = new Point(330, 182);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(120, 25);
            cboGender.TabIndex = 14;
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBirthday.ForeColor = Color.Black;
            lblBirthday.Location = new Point(30, 235);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(55, 15);
            lblBirthday.TabIndex = 15;
            lblBirthday.Text = "Birthday";
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new Point(140, 232);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(220, 25);
            dtpBirthday.TabIndex = 16;
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContact.ForeColor = Color.Black;
            lblContact.Location = new Point(380, 235);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(70, 15);
            lblContact.TabIndex = 17;
            lblContact.Text = "Contact No.";
            // 
            // txtContact
            // 
            txtContact.Location = new Point(480, 232);
            txtContact.MaxLength = 11;
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(170, 25);
            txtContact.TabIndex = 18;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(192, 0, 0);
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(275, 300);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(130, 40);
            btnRegister.TabIndex = 19;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnRecords
            // 
            btnRecords.BackColor = Color.FromArgb(192, 0, 0);
            btnRecords.Cursor = Cursors.Hand;
            btnRecords.FlatAppearance.BorderSize = 0;
            btnRecords.FlatStyle = FlatStyle.Flat;
            btnRecords.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRecords.ForeColor = Color.White;
            btnRecords.Location = new Point(513, 331);
            btnRecords.Name = "btnRecords";
            btnRecords.Size = new Size(110, 40);
            btnRecords.TabIndex = 20;
            btnRecords.Text = "Records";
            btnRecords.UseVisualStyleBackColor = false;
            btnRecords.Click += btnRecords_Click;
            // 
            // FrmRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(664, 409);
            Controls.Add(btnRecords);
            Controls.Add(btnRegister);
            Controls.Add(txtContact);
            Controls.Add(lblContact);
            Controls.Add(dtpBirthday);
            Controls.Add(lblBirthday);
            Controls.Add(cboGender);
            Controls.Add(lblGender);
            Controls.Add(lblAge);
            Controls.Add(txtAge);
            Controls.Add(txtMI);
            Controls.Add(lblMI);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lblLastName);
            Controls.Add(cboProgram);
            Controls.Add(lblProgram);
            Controls.Add(txtStudentNo);
            Controls.Add(lblStudentNo);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmRegistration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblStudentNo;
        private TextBox txtStudentNo;
        private Label lblProgram;
        private ComboBox cboProgram;
        private Label lblLastName;
        private Label lblFirstName;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label lblMI;
        private TextBox txtMI;
        private TextBox txtAge;
        private Label lblAge;
        private Label lblGender;
        private ComboBox cboGender;
        private Label lblBirthday;
        private DateTimePicker dtpBirthday;
        private Label lblContact;
        private TextBox txtContact;
        private Button btnRegister;
        private Button btnRecords;
    }
}