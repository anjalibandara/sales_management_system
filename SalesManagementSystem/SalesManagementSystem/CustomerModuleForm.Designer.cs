namespace SalesManagementSystem
{
    partial class CustomerModuleForm
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
            btnClear = new Button();
            btnUpdate = new Button();
            pictureBoxClose = new PictureBox();
            label2 = new Label();
            btnSave = new Button();
            textCPhone = new TextBox();
            label4 = new Label();
            textCName = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            lblCId = new Label();
            textCId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Red;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(412, 283);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 39);
            btnClear.TabIndex = 27;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(192, 192, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(284, 283);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 39);
            btnUpdate.TabIndex = 26;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
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
            label2.Size = new Size(164, 21);
            label2.TabIndex = 2;
            label2.Text = "Customer Module ";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Teal;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(131, 283);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 39);
            btnSave.TabIndex = 25;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // textCPhone
            // 
            textCPhone.Location = new Point(130, 189);
            textCPhone.Name = "textCPhone";
            textCPhone.Size = new Size(513, 26);
            textCPhone.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 192);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 19;
            label4.Text = "Phone :";
            // 
            // textCName
            // 
            textCName.Location = new Point(131, 129);
            textCName.Name = "textCName";
            textCName.Size = new Size(513, 26);
            textCName.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 135);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 17;
            label3.Text = "Name :";
            label3.Click += label3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(pictureBoxClose);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(697, 88);
            panel1.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(440, 78);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 15;
            // 
            // lblCId
            // 
            lblCId.AutoSize = true;
            lblCId.Location = new Point(43, 246);
            lblCId.Name = "lblCId";
            lblCId.Size = new Size(96, 20);
            lblCId.TabIndex = 28;
            lblCId.Text = "customer Id";
            // 
            // textCId
            // 
            textCId.Location = new Point(145, 246);
            textCId.Name = "textCId";
            textCId.Size = new Size(513, 26);
            textCId.TabIndex = 29;
            // 
            // CustomerModuleForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 358);
            Controls.Add(textCId);
            Controls.Add(lblCId);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(textCPhone);
            Controls.Add(label4);
            Controls.Add(textCName);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerModuleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerModuleForm";
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Button btnClear;
        public Button btnUpdate;
        private PictureBox pictureBoxClose;
        private Label label2;
        public Button btnSave;
        public TextBox textCPhone;
        private Label label4;
        public TextBox textCName;
        private Label label3;
        private Panel panel1;
        private Label label1;
        private Label lblCId;
        public TextBox textCId;
    }
}