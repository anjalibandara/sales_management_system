namespace SalesManagementSystem
{
    partial class OrderModuleForm
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pictureBoxClose = new PictureBox();
            label2 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            lblOid = new Label();
            label7 = new Label();
            textCName = new TextBox();
            label6 = new Label();
            textCId = new TextBox();
            label5 = new Label();
            textSearchCust = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            customerDataGridView1 = new DataGridView();
            Column5 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            productDataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            panel4 = new Panel();
            UDQty = new NumericUpDown();
            btnClear = new Button();
            btnInsert = new Button();
            dtOrder = new DateTimePicker();
            label13 = new Label();
            textPName = new TextBox();
            label12 = new Label();
            textPId = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            textTotal = new TextBox();
            label8 = new Label();
            textPrice = new TextBox();
            label4 = new Label();
            textSearchProd = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customerDataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productDataGridView1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UDQty).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Image = Properties.Resources.cancel;
            pictureBoxClose.Location = new Point(865, 3);
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
            label2.Size = new Size(132, 21);
            label2.TabIndex = 2;
            label2.Text = "Order Module ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(pictureBoxClose);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 88);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lblOid);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(textCName);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(textCId);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textSearchCust);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 88);
            panel2.Name = "panel2";
            panel2.Size = new Size(398, 537);
            panel2.TabIndex = 6;
            panel2.Paint += panel2_Paint;
            // 
            // lblOid
            // 
            lblOid.AutoSize = true;
            lblOid.Location = new Point(28, 449);
            lblOid.Name = "lblOid";
            lblOid.Size = new Size(61, 20);
            lblOid.TabIndex = 11;
            lblOid.Text = "label14";
            lblOid.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(95, 336);
            label7.Name = "label7";
            label7.Size = new Size(135, 20);
            label7.TabIndex = 10;
            label7.Text = "Customer Name :";
            // 
            // textCName
            // 
            textCName.Enabled = false;
            textCName.Location = new Point(104, 359);
            textCName.Name = "textCName";
            textCName.Size = new Size(282, 26);
            textCName.TabIndex = 9;
            textCName.TextChanged += textBox1_TextChanged_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(95, 273);
            label6.Name = "label6";
            label6.Size = new Size(106, 20);
            label6.TabIndex = 8;
            label6.Text = "Customer Id :";
            // 
            // textCId
            // 
            textCId.Enabled = false;
            textCId.Location = new Point(104, 296);
            textCId.Name = "textCId";
            textCId.Size = new Size(282, 26);
            textCId.TabIndex = 7;
            textCId.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(104, 201);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 5;
            label5.Text = "Search box :";
            // 
            // textSearchCust
            // 
            textSearchCust.Location = new Point(207, 195);
            textSearchCust.Name = "textSearchCust";
            textSearchCust.Size = new Size(179, 26);
            textSearchCust.TabIndex = 2;
            textSearchCust.TextChanged += textSearchCust_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(12, 243);
            label1.Name = "label1";
            label1.Size = new Size(108, 22);
            label1.TabIndex = 1;
            label1.Text = "CUSTOMER ";
            // 
            // panel3
            // 
            panel3.Controls.Add(customerDataGridView1);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(399, 189);
            panel3.TabIndex = 0;
            // 
            // customerDataGridView1
            // 
            customerDataGridView1.AllowUserToAddRows = false;
            customerDataGridView1.BackgroundColor = Color.White;
            customerDataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 70, 160);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            customerDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            customerDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customerDataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column5, Column1, Column2 });
            customerDataGridView1.EnableHeadersVisualStyles = false;
            customerDataGridView1.GridColor = SystemColors.HotTrack;
            customerDataGridView1.Location = new Point(3, 0);
            customerDataGridView1.Name = "customerDataGridView1";
            customerDataGridView1.RowHeadersVisible = false;
            customerDataGridView1.RowHeadersWidth = 51;
            customerDataGridView1.Size = new Size(393, 186);
            customerDataGridView1.TabIndex = 2;
            customerDataGridView1.CellContentClick += customerDataGridView1_CellContentClick_1;
            // 
            // Column5
            // 
            Column5.HeaderText = "No";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "Customer Id";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 127;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // productDataGridView1
            // 
            productDataGridView1.AllowUserToAddRows = false;
            productDataGridView1.BackgroundColor = Color.White;
            productDataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(0, 70, 160);
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            productDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            productDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productDataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, Column3, Column4, Column6, Column7 });
            productDataGridView1.Dock = DockStyle.Top;
            productDataGridView1.EnableHeadersVisualStyles = false;
            productDataGridView1.GridColor = SystemColors.HotTrack;
            productDataGridView1.Location = new Point(0, 0);
            productDataGridView1.Name = "productDataGridView1";
            productDataGridView1.RowHeadersVisible = false;
            productDataGridView1.RowHeadersWidth = 51;
            productDataGridView1.Size = new Size(484, 189);
            productDataGridView1.TabIndex = 1;
            productDataGridView1.CellContentClick += productDataGridView1_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn1.HeaderText = "No";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 59;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn2.HeaderText = "P Id";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 66;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn3.HeaderText = "Name";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 82;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column3.HeaderText = "Qty";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 64;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.HeaderText = "Price";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 75;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column6.HeaderText = "Description";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column7.HeaderText = "Categ";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 85;
            // 
            // panel4
            // 
            panel4.Controls.Add(UDQty);
            panel4.Controls.Add(btnClear);
            panel4.Controls.Add(btnInsert);
            panel4.Controls.Add(dtOrder);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(textPName);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(textPId);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(textTotal);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(textPrice);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(textSearchProd);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(productDataGridView1);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(416, 88);
            panel4.Name = "panel4";
            panel4.Size = new Size(484, 537);
            panel4.TabIndex = 3;
            panel4.Paint += panel4_Paint;
            // 
            // UDQty
            // 
            UDQty.Location = new Point(350, 325);
            UDQty.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            UDQty.Name = "UDQty";
            UDQty.Size = new Size(122, 26);
            UDQty.TabIndex = 11;
            UDQty.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Red;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(350, 486);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 39);
            btnClear.TabIndex = 19;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.Teal;
            btnInsert.ForeColor = Color.White;
            btnInsert.Location = new Point(57, 486);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(112, 39);
            btnInsert.TabIndex = 17;
            btnInsert.Text = "Order Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnSave_Click;
            // 
            // dtOrder
            // 
            dtOrder.CustomFormat = "dd/MM/YY";
            dtOrder.Format = DateTimePickerFormat.Custom;
            dtOrder.Location = new Point(17, 428);
            dtOrder.Name = "dtOrder";
            dtOrder.Size = new Size(289, 26);
            dtOrder.TabIndex = 11;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(18, 339);
            label13.Name = "label13";
            label13.Size = new Size(123, 20);
            label13.TabIndex = 16;
            label13.Text = "Product Name :";
            // 
            // textPName
            // 
            textPName.Location = new Point(18, 365);
            textPName.Name = "textPName";
            textPName.Size = new Size(225, 26);
            textPName.TabIndex = 15;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(17, 281);
            label12.Name = "label12";
            label12.Size = new Size(94, 20);
            label12.TabIndex = 14;
            label12.Text = "Product Id :";
            // 
            // textPId
            // 
            textPId.Location = new Point(17, 310);
            textPId.Name = "textPId";
            textPId.Size = new Size(226, 26);
            textPId.TabIndex = 13;
            textPId.TextChanged += textBox3_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(42, 405);
            label11.Name = "label11";
            label11.Size = new Size(100, 20);
            label11.TabIndex = 12;
            label11.Text = "Order Date :";
            label11.Click += label11_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(280, 327);
            label10.Name = "label10";
            label10.Size = new Size(43, 20);
            label10.TabIndex = 10;
            label10.Text = "Qty :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(280, 365);
            label9.Name = "label9";
            label9.Size = new Size(50, 20);
            label9.TabIndex = 8;
            label9.Text = "Total :";
            // 
            // textTotal
            // 
            textTotal.Location = new Point(350, 362);
            textTotal.Name = "textTotal";
            textTotal.Size = new Size(122, 26);
            textTotal.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(280, 284);
            label8.Name = "label8";
            label8.Size = new Size(54, 20);
            label8.TabIndex = 6;
            label8.Text = "Price :";
            // 
            // textPrice
            // 
            textPrice.Location = new Point(350, 281);
            textPrice.Name = "textPrice";
            textPrice.Size = new Size(122, 26);
            textPrice.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(85, 214);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 4;
            label4.Text = "Search box :";
            // 
            // textSearchProd
            // 
            textSearchProd.Location = new Point(190, 211);
            textSearchProd.Name = "textSearchProd";
            textSearchProd.Size = new Size(282, 26);
            textSearchProd.TabIndex = 3;
            textSearchProd.TextChanged += textSearchProd_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(17, 243);
            label3.Name = "label3";
            label3.Size = new Size(92, 22);
            label3.TabIndex = 2;
            label3.Text = "PRODUCT";
            label3.Click += label3_Click;
            // 
            // OrderModuleForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 625);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OrderModuleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrderModuleForm";
            Load += OrderModuleForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)customerDataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productDataGridView1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UDQty).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxClose;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private DataGridView customerDataGridView1;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Panel panel3;
        private DataGridView productDataGridView1;
        private Panel panel4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private Label label1;
        private Label label3;
        private TextBox textSearchCust;
        private TextBox textSearchProd;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label label7;
        private TextBox textCName;
        private Label label10;
        private Label label9;
        private TextBox textTotal;
        private Label label8;
        private Label label12;
        private Label label11;
        private Label label13;
        private TextBox textPName;
        public Button btnClear;
        public Button btnUpdate;
        public Button btnInsert;
        public Label lblOid;
        public TextBox textPrice;
        public TextBox textPId;
        public NumericUpDown UDQty;
        public DateTimePicker dtOrder;
        public TextBox textCId;
    }
}