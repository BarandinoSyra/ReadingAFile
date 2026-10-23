namespace ReadingAFile
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
            label1 = new Label();
            cmbProgram = new ComboBox();
            txtStudentNo = new TextBox();
            dtpBirthday = new DateTimePicker();
            btnRegister = new Button();
            btnRecords = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtLastName = new TextBox();
            txtMI = new TextBox();
            label7 = new Label();
            txtAge = new TextBox();
            cmbGender = new ComboBox();
            label8 = new Label();
            txtFirstName = new TextBox();
            label9 = new Label();
            label10 = new Label();
            txtContactNo = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 64);
            label1.Name = "label1";
            label1.Size = new Size(88, 17);
            label1.TabIndex = 0;
            label1.Text = "Student No.";
            // 
            // cmbProgram
            // 
            cmbProgram.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbProgram.FormattingEnabled = true;
            cmbProgram.Items.AddRange(new object[] { "BS in Information Technology", "BS in Computer Engineering", "BS in Computer Science", "BS in Information System" });
            cmbProgram.Location = new Point(430, 56);
            cmbProgram.Name = "cmbProgram";
            cmbProgram.Size = new Size(305, 25);
            cmbProgram.TabIndex = 2;
            // 
            // txtStudentNo
            // 
            txtStudentNo.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStudentNo.Location = new Point(117, 56);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(200, 25);
            txtStudentNo.TabIndex = 3;
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new Point(117, 149);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(200, 23);
            dtpBirthday.TabIndex = 4;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.DarkGray;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(269, 195);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(95, 28);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnRecords
            // 
            btnRecords.BackColor = Color.DarkGray;
            btnRecords.FlatStyle = FlatStyle.Flat;
            btnRecords.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRecords.Location = new Point(370, 195);
            btnRecords.Name = "btnRecords";
            btnRecords.Size = new Size(95, 28);
            btnRecords.TabIndex = 6;
            btnRecords.Text = "RECORDS";
            btnRecords.UseVisualStyleBackColor = false;
            btnRecords.Click += btnRecords_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 23);
            label2.Name = "label2";
            label2.Size = new Size(128, 21);
            label2.TabIndex = 7;
            label2.Text = "REGISTRATION";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(358, 64);
            label3.Name = "label3";
            label3.Size = new Size(66, 17);
            label3.TabIndex = 8;
            label3.Text = "Program";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(638, 95);
            label4.Name = "label4";
            label4.Size = new Size(33, 17);
            label4.TabIndex = 9;
            label4.Text = "M.I.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(343, 95);
            label5.Name = "label5";
            label5.Size = new Size(81, 17);
            label5.TabIndex = 10;
            label5.Text = "First Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(32, 95);
            label6.Name = "label6";
            label6.Size = new Size(79, 17);
            label6.TabIndex = 11;
            label6.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(117, 87);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(200, 25);
            txtLastName.TabIndex = 12;
            // 
            // txtMI
            // 
            txtMI.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMI.Location = new Point(673, 87);
            txtMI.Name = "txtMI";
            txtMI.Size = new Size(62, 25);
            txtMI.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(77, 126);
            label7.Name = "label7";
            label7.Size = new Size(34, 17);
            label7.TabIndex = 15;
            label7.Text = "Age";
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAge.Location = new Point(117, 118);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(121, 25);
            txtAge.TabIndex = 16;
            // 
            // cmbGender
            // 
            cmbGender.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(430, 118);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(147, 25);
            cmbGender.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(367, 126);
            label8.Name = "label8";
            label8.Size = new Size(57, 17);
            label8.TabIndex = 18;
            label8.Text = "Gender";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(430, 87);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(200, 25);
            txtFirstName.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(336, 155);
            label9.Name = "label9";
            label9.Size = new Size(88, 17);
            label9.TabIndex = 20;
            label9.Text = "Contact No.";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(48, 155);
            label10.Name = "label10";
            label10.Size = new Size(63, 17);
            label10.TabIndex = 21;
            label10.Text = "Birthday";
            // 
            // txtContactNo
            // 
            txtContactNo.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContactNo.Location = new Point(430, 147);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(200, 25);
            txtContactNo.TabIndex = 22;
            // 
            // FrmRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(764, 242);
            Controls.Add(txtContactNo);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtFirstName);
            Controls.Add(label8);
            Controls.Add(cmbGender);
            Controls.Add(txtAge);
            Controls.Add(label7);
            Controls.Add(txtMI);
            Controls.Add(txtLastName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnRecords);
            Controls.Add(btnRegister);
            Controls.Add(dtpBirthday);
            Controls.Add(txtStudentNo);
            Controls.Add(cmbProgram);
            Controls.Add(label1);
            Name = "FrmRegistration";
            Text = "FrmRegistration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbProgram;
        private TextBox txtStudentNo;
        private DateTimePicker dtpBirthday;
        private Button btnRegister;
        private Button btnRecords;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtLastName;
        private TextBox txtMI;
        private Label label7;
        private TextBox txtAge;
        private ComboBox cmbGender;
        private Label label8;
        private TextBox txtFirstName;
        private Label label9;
        private Label label10;
        private TextBox txtContactNo;
    }
}