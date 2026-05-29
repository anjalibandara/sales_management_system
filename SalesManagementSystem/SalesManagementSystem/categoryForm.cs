using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SalesManagementSystem
{
    public partial class categoryForm : Form
    {
        SqlConnection con = new SqlConnection(
           @"Data Source=(LocalDB)\MSSQLLocalDB;
            AttachDbFilename=C:\Users\harsh\Documents\dbMS.mdf;
            Integrated Security=True;
            Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public categoryForm()
        {
            InitializeComponent();
            LoadCategory();
        }
        public void LoadCategory()
        {
            int i = 0;
            categoryDataGridView1.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM tbCategory", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())

            {
                i++;
                categoryDataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void categoryForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CategoryModuleForm formModule = new CategoryModuleForm();
            formModule.btnSave.Enabled = true;
            formModule.btnUpdate.Enabled = false;
            formModule.ShowDialog();
            LoadCategory();
        }

        private void categoryDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = categoryDataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                CategoryModuleForm categoryModule = new CategoryModuleForm();

                categoryModule.textCatId.Text = categoryDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                categoryModule.textCatName.Text = categoryDataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();



                categoryModule.btnSave.Enabled = false;
                categoryModule.btnUpdate.Enabled = true;
                categoryModule.ShowDialog();
                LoadCategory();

            }
            else if (colName == "Delete")
                if (MessageBox.Show("Are you sure you want to delete this category?", "Delete Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    //MessageBox.Show(categoryDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    cmd = new SqlCommand("DELETE FROM tbCategory WHERE catid LIKE'" + categoryDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", con);
                    cmd.Parameters.AddWithValue("@id", categoryDataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record has been successfully deleted.!");
                    LoadCategory();
                }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
