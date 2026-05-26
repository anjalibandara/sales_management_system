namespace SalesManagementSystem
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            flowLayoutPanel1 = new Panel();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            btnOrders = new UserControlButton();
            btnUsers = new UserControlButton();
            btnCategory = new UserControlButton();
            btnCustomer = new UserControlButton();
            btnProduct = new UserControlButton();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panelMain = new Panel();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCustomer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnProduct).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(label10);
            flowLayoutPanel1.Controls.Add(label9);
            flowLayoutPanel1.Controls.Add(label8);
            flowLayoutPanel1.Controls.Add(label7);
            flowLayoutPanel1.Controls.Add(label6);
            flowLayoutPanel1.Controls.Add(btnOrders);
            flowLayoutPanel1.Controls.Add(btnUsers);
            flowLayoutPanel1.Controls.Add(btnCategory);
            flowLayoutPanel1.Controls.Add(btnCustomer);
            flowLayoutPanel1.Controls.Add(btnProduct);
            flowLayoutPanel1.Controls.Add(label5);
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1042, 125);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Yellow;
            label10.Location = new Point(743, 87);
            label10.Name = "label10";
            label10.Size = new Size(73, 20);
            label10.TabIndex = 22;
            label10.Text = "OREDERS";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Yellow;
            label9.Location = new Point(662, 87);
            label9.Name = "label9";
            label9.Size = new Size(52, 20);
            label9.TabIndex = 21;
            label9.Text = "USERS";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Yellow;
            label8.Location = new Point(543, 87);
            label8.Name = "label8";
            label8.Size = new Size(93, 20);
            label8.TabIndex = 20;
            label8.Text = "CATEGORIES";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Yellow;
            label7.Location = new Point(442, 87);
            label7.Name = "label7";
            label7.Size = new Size(92, 20);
            label7.TabIndex = 19;
            label7.Text = "CUSTOMERS";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Yellow;
            label6.Location = new Point(345, 87);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 18;
            label6.Text = "PRODUCT";
            // 
            // btnOrders
            // 
            btnOrders.Image = (Image)resources.GetObject("btnOrders.Image");
            btnOrders.ImageHover = (Image)resources.GetObject("btnOrders.ImageHover");
            btnOrders.ImageNormal = (Image)resources.GetObject("btnOrders.ImageNormal");
            btnOrders.Location = new Point(743, 12);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(69, 62);
            btnOrders.SizeMode = PictureBoxSizeMode.Zoom;
            btnOrders.TabIndex = 17;
            btnOrders.TabStop = false;
            // 
            // btnUsers
            // 
            btnUsers.Image = (Image)resources.GetObject("btnUsers.Image");
            btnUsers.ImageHover = (Image)resources.GetObject("btnUsers.ImageHover");
            btnUsers.ImageNormal = (Image)resources.GetObject("btnUsers.ImageNormal");
            btnUsers.Location = new Point(645, 12);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(69, 62);
            btnUsers.SizeMode = PictureBoxSizeMode.Zoom;
            btnUsers.TabIndex = 15;
            btnUsers.TabStop = false;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnCategory
            // 
            btnCategory.Image = (Image)resources.GetObject("btnCategory.Image");
            btnCategory.ImageHover = (Image)resources.GetObject("btnCategory.ImageHover");
            btnCategory.ImageNormal = (Image)resources.GetObject("btnCategory.ImageNormal");
            btnCategory.Location = new Point(543, 12);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(69, 62);
            btnCategory.SizeMode = PictureBoxSizeMode.Zoom;
            btnCategory.TabIndex = 14;
            btnCategory.TabStop = false;
            // 
            // btnCustomer
            // 
            btnCustomer.Image = (Image)resources.GetObject("btnCustomer.Image");
            btnCustomer.ImageHover = (Image)resources.GetObject("btnCustomer.ImageHover");
            btnCustomer.ImageNormal = (Image)resources.GetObject("btnCustomer.ImageNormal");
            btnCustomer.Location = new Point(442, 12);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(69, 62);
            btnCustomer.SizeMode = PictureBoxSizeMode.Zoom;
            btnCustomer.TabIndex = 13;
            btnCustomer.TabStop = false;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnProduct
            // 
            btnProduct.Image = (Image)resources.GetObject("btnProduct.Image");
            btnProduct.ImageHover = (Image)resources.GetObject("btnProduct.ImageHover");
            btnProduct.ImageNormal = (Image)resources.GetObject("btnProduct.ImageNormal");
            btnProduct.Location = new Point(345, 12);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(69, 62);
            btnProduct.SizeMode = PictureBoxSizeMode.Zoom;
            btnProduct.TabIndex = 0;
            btnProduct.TabStop = false;
            btnProduct.Click += btnProduct_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(33, 28);
            label5.Name = "label5";
            label5.Size = new Size(161, 59);
            label5.TabIndex = 0;
            label5.Text = "inter";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(48, 33);
            label4.Name = "label4";
            label4.Size = new Size(0, 54);
            label4.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Brown;
            label3.Location = new Point(0, 87);
            label3.Name = "label3";
            label3.Size = new Size(287, 31);
            label3.TabIndex = 12;
            label3.Text = "Sales Management System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(33, 33);
            label2.Name = "label2";
            label2.Size = new Size(0, 54);
            label2.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Showcard Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 74);
            label1.TabIndex = 10;
            label1.Text = "V";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 482);
            panel2.Name = "panel2";
            panel2.Size = new Size(1042, 24);
            panel2.TabIndex = 1;
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 125);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1042, 357);
            panelMain.TabIndex = 2;
            panelMain.Paint += panelMain_Paint;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1042, 506);
            Controls.Add(panelMain);
            Controls.Add(panel2);
            Controls.Add(flowLayoutPanel1);
            Name = "mainForm";
            Text = "Form2";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCustomer).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel flowLayoutPanel1;
        private Panel panel2;
        private Panel panelMain;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label4;
        private UserControlButton btnProduct;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private UserControlButton btnOrders;
        private UserControlButton btnUsers;
        private UserControlButton btnCategory;
        private UserControlButton btnCustomer;
    }
}