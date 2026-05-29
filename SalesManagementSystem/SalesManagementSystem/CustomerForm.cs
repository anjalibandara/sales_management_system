using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace SalesManagementSystem
{
    public partial class CustomerForm : Form
    {
        SqlConnection con = new SqlConnection(
           @"Data Source=(LocalDB)\MSSQLLocalDB;
            AttachDbFilename=C:\Users\harsh\Documents\dbMS.mdf;
            Integrated Security=True;
            Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public CustomerForm()
        {
            InitializeComponent();
            LoadCustomer();
        }
        public void LoadCustomer()
        {
            int i = 0;
            customerDataGridView1.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM tbCustomer", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())

            {
                i += 1;
                customerDataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
            }
            dr.Close();
            con.Close();
        }
        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }


        private void customerDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = customerDataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                var row = customerDataGridView1.Rows[e.RowIndex];

                // 🔥 DEBUG BEFORE ACCESS
                MessageBox.Show(
                    $"Raw Row Info:\n" +
                    $"Cell0: {row.Cells[0].Value}\n" +
                    $"Cell1: {row.Cells[1].Value}\n" +
                    $"Cell2: {row.Cells[2].Value}\n" +
                    $"Cell3: {row.Cells[3].Value}",
                    "Before Reading Values",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                CustomerModuleForm customerModule = new CustomerModuleForm();

                customerModule.lblCId.Text = customerDataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                customerModule.textCName.Text = customerDataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                customerModule.textCPhone.Text = customerDataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();


                customerModule.btnSave.Enabled = false;
                customerModule.btnUpdate.Enabled = true;
                customerModule.ShowDialog();
                LoadCustomer();

            }

            else if (colName == "Delete")
                if (MessageBox.Show("Are you sure you want to delete this user?", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    //MessageBox.Show(customerDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    cmd = new SqlCommand("DELETE FROM tbCustomer WHERE cid LIKE'" + customerDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", con);
                    cmd.Parameters.AddWithValue("@id", customerDataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record has been successfully deleted.!");
                    LoadCustomer();
                }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CustomerModuleForm customerModule = new CustomerModuleForm();
            customerModule.btnSave.Enabled = true;
            customerModule.btnUpdate.Enabled = false;
            customerModule.ShowDialog();
            LoadCustomer();

        }

        private void dgvCustomer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
