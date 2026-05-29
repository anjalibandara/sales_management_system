namespace SalesManagementSystem
{
    partial class OrderForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            panel1 = new Panel();
            label7 = new Label();
            orderGridView1 = new DataGridView();
            Column5 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Delete = new DataGridViewImageColumn();
            panel2 = new Panel();
            lblQty = new Label();
            lblTotalAmount = new Label();
            lblQty1 = new Label();
            lblOQty = new Label();
            label2 = new Label();
            textSearch = new TextBox();
            label1 = new Label();
            btnAdd = new UserControlButton();
            lblTotal = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)orderGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnAdd).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(orderGridView1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1064, 256);
            panel1.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(885, 201);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 12;
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // orderGridView1
            // 
            orderGridView1.AllowUserToAddRows = false;
            orderGridView1.BackgroundColor = Color.White;
            orderGridView1.BorderStyle = BorderStyle.None;
            orderGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 70, 160);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            orderGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            orderGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderGridView1.Columns.AddRange(new DataGridViewColumn[] { Column5, Column1, Column7, Column2, Column3, Column4, Column6, Column8, Delete });
            orderGridView1.EnableHeadersVisualStyles = false;
            orderGridView1.GridColor = SystemColors.HotTrack;
            orderGridView1.Location = new Point(-4, 0);
            orderGridView1.Name = "orderGridView1";
            orderGridView1.RowHeadersVisible = false;
            orderGridView1.RowHeadersWidth = 51;
            orderGridView1.Size = new Size(1064, 474);
            orderGridView1.TabIndex = 0;
            orderGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column5.HeaderText = "No";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 59;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "Order Id";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column7.HeaderText = "Order Date";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 121;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column2.HeaderText = "Product Id";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 115;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column3.HeaderText = "Customer Id";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 127;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.HeaderText = "Qty";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 64;
            // 
            // Column6
            // 
            Column6.HeaderText = "Price";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column8.HeaderText = "Total Amount";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "";
            Delete.Image = (Image)resources.GetObject("Delete.Image");
            Delete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Width = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Controls.Add(lblTotal);
            panel2.Controls.Add(lblQty);
            panel2.Controls.Add(lblTotalAmount);
            panel2.Controls.Add(lblQty1);
            panel2.Controls.Add(lblOQty);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textSearch);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnAdd);
            panel2.Dock = DockStyle.Bottom;
            panel2.ForeColor = Color.Coral;
            panel2.Location = new Point(0, 347);
            panel2.Name = "panel2";
            panel2.Size = new Size(1064, 127);
            panel2.TabIndex = 5;
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.ForeColor = Color.White;
            lblQty.Location = new Point(647, 85);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(0, 20);
            lblQty.TabIndex = 11;
            lblQty.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalAmount.ForeColor = Color.White;
            lblTotalAmount.Location = new Point(771, 16);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(125, 19);
            lblTotalAmount.TabIndex = 10;
            lblTotalAmount.Text = "Total Amount :";
            // 
            // lblQty1
            // 
            lblQty1.AutoSize = true;
            lblQty1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQty1.ForeColor = Color.White;
            lblQty1.Location = new Point(634, 20);
            lblQty1.Name = "lblQty1";
            lblQty1.Size = new Size(47, 19);
            lblQty1.TabIndex = 9;
            lblQty1.Text = " Qty ";
            // 
            // lblOQty
            // 
            lblOQty.AutoSize = true;
            lblOQty.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOQty.ForeColor = Color.White;
            lblOQty.Location = new Point(481, 82);
            lblOQty.Name = "lblOQty";
            lblOQty.Size = new Size(98, 19);
            lblOQty.TabIndex = 8;
            lblOQty.Text = "Order Qty :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(18, 81);
            label2.Name = "label2";
            label2.Size = new Size(95, 21);
            label2.TabIndex = 7;
            label2.Text = "Search in :";
            // 
            // textSearch
            // 
            textSearch.Location = new Point(119, 79);
            textSearch.Name = "textSearch";
            textSearch.Size = new Size(300, 26);
            textSearch.TabIndex = 6;
            textSearch.TextChanged += textSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DodgerBlue;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(148, 23);
            label1.TabIndex = 3;
            label1.Text = "Manage Users";
            // 
            // btnAdd
            // 
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageHover = (Image)resources.GetObject("btnAdd.ImageHover");
            btnAdd.ImageNormal = (Image)resources.GetObject("btnAdd.ImageNormal");
            btnAdd.Location = new Point(974, 47);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(34, 39);
            btnAdd.SizeMode = PictureBoxSizeMode.Zoom;
            btnAdd.TabIndex = 4;
            btnAdd.TabStop = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(788, 66);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 20);
            lblTotal.TabIndex = 12;
            lblTotal.TextAlign = ContentAlignment.TopCenter;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 474);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OrderForm";
            Text = "OrderForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)orderGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnAdd).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView orderGridView1;
        private Panel panel2;
        private Label label1;
        private UserControlButton btnAdd;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewImageColumn Delete;
        private TextBox textSearch;
        private Label label2;
        private Label lblOQty;
        private Label label7;
        private Label lblQty;
        private Label lblTotalAmount;
        private Label lblQty1;
        private Label lblTotal;
    }
}