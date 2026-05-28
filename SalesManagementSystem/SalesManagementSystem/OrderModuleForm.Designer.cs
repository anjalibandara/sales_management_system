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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pictureBoxClose = new PictureBox();
            label2 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
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
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textSearchCust);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 88);
            panel2.Name = "panel2";
            panel2.Size = new Size(398, 420);
            panel2.TabIndex = 6;
            panel2.Paint += panel2_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(150, 200);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 5;
            label5.Text = "Search box :";
            // 
            // textSearchCust
            // 
            textSearchCust.Location = new Point(261, 195);
            textSearchCust.Name = "textSearchCust";
            textSearchCust.Size = new Size(125, 26);
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 70, 160);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            customerDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 70, 160);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            productDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            panel4.Controls.Add(label4);
            panel4.Controls.Add(textSearchProd);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(productDataGridView1);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(416, 88);
            panel4.Name = "panel4";
            panel4.Size = new Size(484, 420);
            panel4.TabIndex = 3;
            panel4.Paint += panel4_Paint;
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
            textSearchProd.Location = new Point(190, 208);
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
            ClientSize = new Size(900, 508);
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
    }
}