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
    public partial class ProductForm : Form
    {
        SqlConnection con = new SqlConnection(
           @"Data Source=(LocalDB)\MSSQLLocalDB;
            AttachDbFilename=C:\Users\harsh\Documents\dbMS.mdf;
            Integrated Security=True;
            Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public ProductForm()
        {
            InitializeComponent();
            LoadProduct();
        }
        public void LoadProduct()
        {
            productDataGridView1.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM tbProduct WHERE CONCAT(pname, pprice, pdescription, pcategory) LIKE '%" + textSearch.Text + "%'", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                productDataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProductModuleForm formModule = new ProductModuleForm();
            formModule.btnSave.Enabled = true;
            formModule.btnUpdate.Enabled = false;
            formModule.ShowDialog();
            LoadProduct();

        }

        private void productDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = productDataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                ProductModuleForm productModule = new ProductModuleForm();

                productModule.lblPid.Text = productDataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                productModule.textProductName.Text = productDataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                productModule.textQuantity.Text = productDataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                productModule.textPrice.Text = productDataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                productModule.textDescription.Text = productDataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                productModule.comboQty.Text = productDataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

                productModule.btnSave.Enabled = false;
                productModule.btnUpdate.Enabled = true;
                productModule.ShowDialog();

            }
            else if (colName == "Delete")
                if (MessageBox.Show("Are you sure you want to delete this product?", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM tbProduct WHERE pid LIKE'" + productDataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cmd.Parameters.AddWithValue("@id", productDataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record has been successfully deleted.!");
                    LoadProduct();
                }
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }
    }
}
