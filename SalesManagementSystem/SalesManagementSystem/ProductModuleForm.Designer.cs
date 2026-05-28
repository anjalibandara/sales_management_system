namespace SalesManagementSystem
{
    partial class ProductModuleForm
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
            textPrice = new TextBox();
            label7 = new Label();
            btnClear = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            textDescription = new TextBox();
            textQuantity = new TextBox();
            label6 = new Label();
            label4 = new Label();
            textProductName = new TextBox();
            label3 = new Label();
            pictureBoxClose = new PictureBox();
            label2 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            comboQty = new ComboBox();
            lblPid = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textPrice
            // 
            textPrice.Location = new Point(163, 217);
            textPrice.Name = "textPrice";
            textPrice.Size = new Size(513, 26);
            textPrice.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(98, 220);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 28;
            label7.Text = "Price :";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Red;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(445, 363);
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
            btnUpdate.Location = new Point(346, 363);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 39);
            btnUpdate.TabIndex = 26;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Teal;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(246, 363);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 39);
            btnSave.TabIndex = 25;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // textDescription
            // 
            textDescription.Location = new Point(163, 266);
            textDescription.Name = "textDescription";
            textDescription.Size = new Size(513, 26);
            textDescription.TabIndex = 23;
            // 
            // textQuantity
            // 
            textQuantity.Location = new Point(163, 166);
            textQuantity.Name = "textQuantity";
            textQuantity.Size = new Size(513, 26);
            textQuantity.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(73, 169);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 21;
            label6.Text = "Quantity :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 315);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 19;
            label4.Text = "Category :";
            // 
            // textProductName
            // 
            textProductName.Location = new Point(163, 117);
            textProductName.Name = "textProductName";
            textProductName.Size = new Size(513, 26);
            textProductName.TabIndex = 18;
            textProductName.TextChanged += textProductName_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 123);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 17;
            label3.Text = "Product Name :";
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
            label2.Size = new Size(150, 21);
            label2.TabIndex = 2;
            label2.Text = "Product Module ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 272);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 20;
            label5.Text = "Description :";
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
            label1.Location = new Point(440, 102);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 15;
            // 
            // comboQty
            // 
            comboQty.FormattingEnabled = true;
            comboQty.Location = new Point(163, 312);
            comboQty.Name = "comboQty";
            comboQty.Size = new Size(513, 28);
            comboQty.TabIndex = 30;
            comboQty.SelectedIndexChanged += comboQty_SelectedIndexChanged;
            // 
            // lblPid
            // 
            lblPid.AutoSize = true;
            lblPid.Location = new Point(53, 350);
            lblPid.Name = "lblPid";
            lblPid.Size = new Size(85, 20);
            lblPid.TabIndex = 31;
            lblPid.Text = "product id";
            lblPid.Visible = false;
            // 
            // ProductModuleForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 412);
            Controls.Add(lblPid);
            Controls.Add(comboQty);
            Controls.Add(textPrice);
            Controls.Add(label7);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(textDescription);
            Controls.Add(textQuantity);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(textProductName);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductModuleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductModuleForm";
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox textPrice;
        private Label label7;
        public Button btnClear;
        public Button btnUpdate;
        public Button btnSave;
        public TextBox textDescription;
        public TextBox textQuantity;
        private Label label6;
        private Label label4;
        public TextBox textProductName;
        private Label label3;
        private PictureBox pictureBoxClose;
        private Label label2;
        private Label label5;
        private Panel panel1;
        private Label label1;
        public ComboBox comboQty;
        public Label lblPid;
    }
}