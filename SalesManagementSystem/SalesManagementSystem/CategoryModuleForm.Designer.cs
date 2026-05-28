namespace SalesManagementSystem
{
    partial class CategoryModuleForm
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
            lblCatId = new Label();
            btnSave = new Button();
            textCatName = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            textCatId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Red;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(500, 224);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 39);
            btnClear.TabIndex = 37;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(192, 192, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(372, 224);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 39);
            btnUpdate.TabIndex = 36;
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
            label2.Size = new Size(163, 21);
            label2.TabIndex = 2;
            label2.Text = "Category Module ";
            // 
            // lblCatId
            // 
            lblCatId.AutoSize = true;
            lblCatId.Location = new Point(27, 183);
            lblCatId.Name = "lblCatId";
            lblCatId.Size = new Size(106, 20);
            lblCatId.TabIndex = 38;
            lblCatId.Text = "Category Id :";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Teal;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(236, 224);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 39);
            btnSave.TabIndex = 35;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // textCatName
            // 
            textCatName.Location = new Point(153, 131);
            textCatName.Name = "textCatName";
            textCatName.Size = new Size(513, 26);
            textCatName.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 134);
            label3.Name = "label3";
            label3.Size = new Size(135, 20);
            label3.TabIndex = 31;
            label3.Text = "Category Name :";
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
            panel1.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(440, 105);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 29;
            // 
            // textCatId
            // 
            textCatId.Location = new Point(153, 180);
            textCatId.Name = "textCatId";
            textCatId.Size = new Size(513, 26);
            textCatId.TabIndex = 39;
            // 
            // CategoryModuleForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 289);
            Controls.Add(textCatId);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(lblCatId);
            Controls.Add(btnSave);
            Controls.Add(textCatName);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CategoryModuleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "v";
            Load += CategoryModuleForm_Load;
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
        private Label lblCId;
        public Button btnSave;
        public TextBox textCName;
        private Label label3;
        private Panel panel1;
        private Label label1;
        private Label lblCatId;
        public TextBox textCatName;
        public TextBox textCatId;
    }
}