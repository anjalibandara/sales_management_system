using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Quic;
using System.Text;
using System.Windows.Forms;

namespace SalesManagementSystem
{
    public partial class OrderModuleForm : Form
    {
        SqlConnection con = new SqlConnection(
            @"Data Source=(LocalDB)\MSSQLLocalDB;
            AttachDbFilename=C:\Users\harsh\Documents\dbMS.mdf;
            Integrated Security=True;
            Connect Timeout=30");

        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        int qty = 0;
        public OrderModuleForm()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            LoadCustomer();
            LoadProduct();
        }

        public void LoadCustomer()
        {
            int i = 0;
            customerDataGridView1.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbCustomer WHERE CONCAT(cid,cname) LIKE '%" + textSearchCust.Text + "%'", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                customerDataGridView1.Rows.Add(dr[0].ToString(), dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
            }
            dr.Close();
            con.Close();
        }
        public void LoadProduct()
        {
            productDataGridView1.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbProduct WHERE CONCAT(pname, pprice, pdescription, pcategory) LIKE '%" + textSearchProd.Text + "%'", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                productDataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            con.Close();
        }
        private void OrderModuleForm_Load(object sender, EventArgs e)
        {

        }

        private void customerDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void customerDataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            textCId.Text = customerDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textCName.Text = customerDataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void productDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textPId.Text = productDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textPName.Text = productDataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textPrice.Text = productDataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            // qty = Convert.ToInt16(productDataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OrderModuleForm_Load_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textSearchCust_TextChanged(object sender, EventArgs e)
        {
            LoadCustomer();
        }

        private void textSearchProd_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(UDQty.Value) > qty)
            {
                MessageBox.Show("Quantity is not enough!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UDQty.Value = UDQty.Value - 1;
                return;
            }
            if (Convert.ToInt32(UDQty.Value) > 0)
            {
                int total = Convert.ToInt32(textPrice.Text) * Convert.ToInt32(UDQty.Value);
                textTotal.Text = total.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (textCId.Text == "")
                {
                    MessageBox.Show("Please select a customer.",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                if (textPId.Text == "")
                {
                    MessageBox.Show("Please select a product.",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;

                    if (MessageBox.Show(
                   "Are you sure you want to insert this order?",
                   "Save Order",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        con.Open();

                        cm = new SqlCommand(
                            "INSERT INTO tbOrder(odate, pid, cid, qty, price, total) " +
                            "VALUES(@odate, @pid, @cid, @qty, @price, @total)", con);

                        cm.Parameters.AddWithValue("@odate", dtOrder.Value);
                        cm.Parameters.AddWithValue("@pid", Convert.ToInt16(textPId.Text));
                        cm.Parameters.AddWithValue("@cid", Convert.ToInt16(textCId.Text));
                        cm.Parameters.AddWithValue("@qty", Convert.ToInt16(UDQty.Value));
                        cm.Parameters.AddWithValue("@price", Convert.ToInt16(textPrice.Text));
                        cm.Parameters.AddWithValue("@total", Convert.ToInt16(textTotal.Text));

                        cm.ExecuteNonQuery();

                        con.Close();

                        MessageBox.Show("Order has been successfully inserted!",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);



                        cm = new SqlCommand(
                        "UPDATE tbProduct SET pqty = (pqty-@pqty)" +
                        "WHERE pid LIKE '" + textPId.Text + "'", con);

                        cm.Parameters.AddWithValue("@pqty", Convert.ToInt16(UDQty.Text));

                        cm.ExecuteNonQuery();
                        con.Close();
                        Clear();
                        LoadProduct();
                    }
                }

            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }
        public void Clear()
        {
            textCId.Clear();
            textCName.Clear();
            textPId.Clear();
            textPName.Clear();
            textPrice.Clear();
            textTotal.Clear();
            UDQty.Value = 1;
            dtOrder.Value = DateTime.Now;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
           
            
        }

        public void GetQty()
        {
            cm = new SqlCommand("SELECT pqty FROM tbProduct WHERE pid LIKE '" + textPId.Text + "'", con);
            con.Open();
            dr = cm.ExecuteReader();
            if (dr.Read())
            {
                qty = Convert.ToInt32(dr[0].ToString());
            }
            dr.Close();
            con.Close();
        }

        
    }

}


