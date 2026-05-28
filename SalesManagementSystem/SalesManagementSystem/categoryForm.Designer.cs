namespace SalesManagementSystem
{
    partial class categoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(categoryForm));
            categoryDataGridView1 = new DataGridView();
            Column5 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            panel1 = new Panel();
            dgvCategory = new Panel();
            label1 = new Label();
            btnAdd = new UserControlButton();
            ((System.ComponentModel.ISupportInitialize)categoryDataGridView1).BeginInit();
            panel1.SuspendLayout();
            dgvCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnAdd).BeginInit();
            SuspendLayout();
            // 
            // categoryDataGridView1
            // 
            categoryDataGridView1.AllowUserToAddRows = false;
            categoryDataGridView1.BackgroundColor = Color.White;
            categoryDataGridView1.BorderStyle = BorderStyle.None;
            categoryDataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 70, 160);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            categoryDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            categoryDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            categoryDataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column5, Column1, Column2, Edit, Delete });
            categoryDataGridView1.EnableHeadersVisualStyles = false;
            categoryDataGridView1.GridColor = SystemColors.HotTrack;
            categoryDataGridView1.Location = new Point(0, 0);
            categoryDataGridView1.Name = "categoryDataGridView1";
            categoryDataGridView1.RowHeadersWidth = 51;
            categoryDataGridView1.Size = new Size(1020, 450);
            categoryDataGridView1.TabIndex = 0;
            categoryDataGridView1.CellContentClick += categoryDataGridView1_CellContentClick;
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
            Column1.HeaderText = "Category Id";
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
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(categoryDataGridView1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1020, 256);
            panel1.TabIndex = 6;
            //panel1.Paint += this.panel1_Paint;
            // 
            // dgvCategory
            // 
            dgvCategory.BackColor = Color.DodgerBlue;
            dgvCategory.Controls.Add(label1);
            dgvCategory.Controls.Add(btnAdd);
            dgvCategory.Dock = DockStyle.Bottom;
            dgvCategory.ForeColor = Color.Coral;
            dgvCategory.Location = new Point(0, 323);
            dgvCategory.Name = "dgvCategory";
            dgvCategory.Size = new Size(1020, 127);
            dgvCategory.TabIndex = 7;
            //dgvCategory.Paint += this.dgvCategory_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DodgerBlue;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(46, 63);
            label1.Name = "label1";
            label1.Size = new Size(205, 23);
            label1.TabIndex = 3;
            label1.Text = "Manage Categories";
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
            // categoryForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 450);
            Controls.Add(panel1);
            Controls.Add(dgvCategory);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "categoryForm";
            Text = "categoryForm";
            Load += categoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)categoryDataGridView1).EndInit();
            panel1.ResumeLayout(false);
            dgvCategory.ResumeLayout(false);
            dgvCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnAdd).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private UserControlButton btnAdd;
        private Panel dgvCustomer;
        private Panel panel1;
        private DataGridView categoryDataGridView1;
        private Panel dgvCategory;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
    }
}