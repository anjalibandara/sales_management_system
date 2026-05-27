namespace SalesManagementSystem
{
    partial class CustomerForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            panel1 = new Panel();
            customerDataGridView1 = new DataGridView();
            Column5 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            dgvCustomer = new Panel();
            label1 = new Label();
            btnAdd = new UserControlButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customerDataGridView1).BeginInit();
            dgvCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnAdd).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(customerDataGridView1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1020, 256);
            panel1.TabIndex = 4;
            // 
            // customerDataGridView1
            // 
            customerDataGridView1.AllowUserToAddRows = false;
            customerDataGridView1.BackgroundColor = Color.White;
            customerDataGridView1.BorderStyle = BorderStyle.None;
            customerDataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 70, 160);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            customerDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            customerDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customerDataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column5, Column1, Column2, Column4, Edit, Delete });
            customerDataGridView1.EnableHeadersVisualStyles = false;
            customerDataGridView1.GridColor = SystemColors.HotTrack;
            customerDataGridView1.Location = new Point(0, 0);
            customerDataGridView1.Name = "customerDataGridView1";
            customerDataGridView1.RowHeadersWidth = 51;
            customerDataGridView1.Size = new Size(1020, 450);
            customerDataGridView1.TabIndex = 0;
            customerDataGridView1.CellContentClick += customerDataGridView1_CellContentClick;
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
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.HeaderText = "Phone";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 85;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.HeaderText = "";
            Edit.Image = (Image)resources.GetObject("Edit.Image");
            Edit.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.Width = 6;
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
            // dgvCustomer
            // 
            dgvCustomer.BackColor = Color.DodgerBlue;
            dgvCustomer.Controls.Add(label1);
            dgvCustomer.Controls.Add(btnAdd);
            dgvCustomer.Dock = DockStyle.Bottom;
            dgvCustomer.ForeColor = Color.Coral;
            dgvCustomer.Location = new Point(0, 323);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.Size = new Size(1020, 127);
            dgvCustomer.TabIndex = 5;
            dgvCustomer.Paint += dgvCustomer_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DodgerBlue;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(46, 63);
            label1.Name = "label1";
            label1.Size = new Size(201, 23);
            label1.TabIndex = 3;
            label1.Text = "Manage Customers";
            label1.Click += label1_Click;
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
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 450);
            Controls.Add(panel1);
            Controls.Add(dgvCustomer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerForm";
            Text = "CustomerForm";
            Load += CustomerForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)customerDataGridView1).EndInit();
            dgvCustomer.ResumeLayout(false);
            dgvCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnAdd).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView customerDataGridView1;
        private Panel dgvCustomer;
        private Label label1;
        private UserControlButton btnAdd;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
    }
}