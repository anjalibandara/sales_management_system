namespace SalesManagementSystem
{
    partial class UserModuleForm
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
            panel1 = new Panel();
            pictureBoxClose = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            textUserName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textFullName = new TextBox();
            textRePass = new TextBox();
            textPhone = new TextBox();
            btnSave = new Button();
            btnUpdate = new Button();
            btnClear = new Button();
            textBox1 = new TextBox();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(440, 91);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(pictureBoxClose);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(697, 88);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Image = Properties.Resources.cancel;
            pictureBoxClose.Location = new Point(671, 3);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(23, 31);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxClose.TabIndex = 11;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(119, 21);
            label2.TabIndex = 2;
            label2.Text = "User Module ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 113);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 2;
            label3.Text = "User Name :";
            // 
            // textUserName
            // 
            textUserName.Location = new Point(163, 106);
            textUserName.Name = "textUserName";
            textUserName.Size = new Size(513, 27);
            textUserName.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 307);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 4;
            label4.Text = "Phone :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 262);
            label5.Name = "label5";
            label5.Size = new Size(133, 20);
            label5.TabIndex = 5;
            label5.Text = "Re-type Password :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(62, 162);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 6;
            label6.Text = "Full Name :";
            // 
            // textFullName
            // 
            textFullName.Location = new Point(163, 155);
            textFullName.Name = "textFullName";
            textFullName.Size = new Size(513, 27);
            textFullName.TabIndex = 7;
            textFullName.TextChanged += textFullName_TextChanged;
            // 
            // textRePass
            // 
            textRePass.Location = new Point(163, 255);
            textRePass.Name = "textRePass";
            textRePass.Size = new Size(513, 27);
            textRePass.TabIndex = 8;
            // 
            // textPhone
            // 
            textPhone.Location = new Point(163, 304);
            textPhone.Name = "textPhone";
            textPhone.Size = new Size(513, 27);
            textPhone.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Teal;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(246, 352);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 39);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(192, 192, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(346, 352);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 39);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Red;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(445, 352);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 39);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(163, 206);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(513, 27);
            textBox1.TabIndex = 14;
            textBox1.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(68, 213);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 13;
            label7.Text = "Password :";
            label7.Click += label7_Click;
            // 
            // UserModuleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 412);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(textPhone);
            Controls.Add(textRePass);
            Controls.Add(textFullName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textUserName);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserModuleForm";
            StartPosition = FormStartPosition.Manual;
            Text = "UserModuleForm";
            Load += UserModuleForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private PictureBox pictureBoxClose;
        public Button btnSave;
        public Button btnUpdate;
        public Button btnClear;
        public TextBox textUserName;
        public TextBox textFullName;
        public TextBox textRePass;
        public TextBox textPhone;
        public TextBox textBox1;
        private Label label7;
    }
}