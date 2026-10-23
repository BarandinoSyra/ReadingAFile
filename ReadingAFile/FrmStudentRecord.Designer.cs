namespace ReadingAFile
{
    partial class FrmStudentRecord
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
            lvShowList = new ListView();
            btnRegister = new Button();
            btnUpload = new Button();
            btnFind = new Button();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 25);
            label1.Name = "label1";
            label1.Size = new Size(123, 21);
            label1.TabIndex = 0;
            label1.Text = "VIEW RECORD";
            // 
            // lvShowList
            // 
            lvShowList.Location = new Point(23, 54);
            lvShowList.Name = "lvShowList";
            lvShowList.Size = new Size(324, 197);
            lvShowList.TabIndex = 1;
            lvShowList.UseCompatibleStateImageBehavior = false;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.DarkGray;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(353, 54);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(95, 28);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnUpload
            // 
            btnUpload.BackColor = Color.DarkGray;
            btnUpload.FlatStyle = FlatStyle.Flat;
            btnUpload.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpload.Location = new Point(353, 122);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(95, 28);
            btnUpload.TabIndex = 3;
            btnUpload.Text = "UPLOAD";
            btnUpload.UseVisualStyleBackColor = false;
            btnUpload.Click += btnUpload_Click;
            // 
            // btnFind
            // 
            btnFind.BackColor = Color.DarkGray;
            btnFind.FlatStyle = FlatStyle.Flat;
            btnFind.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFind.Location = new Point(353, 88);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(95, 28);
            btnFind.TabIndex = 4;
            btnFind.Text = "FIND";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmStudentRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(469, 270);
            Controls.Add(btnFind);
            Controls.Add(btnUpload);
            Controls.Add(btnRegister);
            Controls.Add(lvShowList);
            Controls.Add(label1);
            Name = "FrmStudentRecord";
            Text = "FrmStudentRecord";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView lvShowList;
        private Button btnRegister;
        private Button btnUpload;
        private Button btnFind;
        private OpenFileDialog openFileDialog1;
    }
}