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
    public partial class OrderForm : Form
    {
        SqlConnection con = new SqlConnection(
           @"Data Source=(LocalDB)\MSSQLLocalDB;
            AttachDbFilename=C:\Users\harsh\Documents\dbMS.mdf;
            Integrated Security=True;
            Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public OrderForm()
        {
            InitializeComponent();
            LoadOrder();
        }

        public void LoadOrder()
        {
            double total = 0;
            int i = 0;
            orderGridView1.Rows.Clear();
            cmd = new SqlCommand("SELECT orderid, odate, O.pid, P.pname, O.cid, C.cname, qty, price, total * FROM tbOrder AS O JOIN tbCustomer AS C ON O.cid=C.cid JOIN tbProduct AS P ON O.pid=P.pid WHERE CONCAT(orderid, odate, O.pid, P.pname, O.cid, C.cname, qty, price) LIKE '%" + textSearch.Text + "%'", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                orderGridView1.Rows.Add(dr[0].ToString(), Convert.ToDateTime(dr[1].ToString()).ToString("dd/MM/yyyy"), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString());
                total += Convert.ToInt32(dr[8].ToString());
            }
            dr.Close();
            con.Close();

            lblQty1.Text = i.ToString();
            lblTotalAmount.Text = total.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OrderModuleForm orderModule = new OrderModuleForm();
            orderModule.btnInsert.Enabled = false;
            orderModule.btnUpdate.Enabled = true;


            orderModule.ShowDialog();
            LoadOrder();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = orderGridView1.Columns[e.ColumnIndex].Name;


            if (colName == "Delete")
                if (MessageBox.Show("Are you sure you want to delete this order?", "Delete Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM tbOrder WHERE orderid LIKE'" + orderGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cmd.Parameters.AddWithValue("@id", orderGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record has been successfully deleted.!");

                    cmd = new SqlCommand(
                        "UPDATE tbProduct SET pqty = (pqty-@pqty)" +
                        "WHERE pid LIKE '" + orderGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() + "'", con);

                    cmd.Parameters.AddWithValue("@pqty", Convert.ToInt16(orderGridView1.Rows[e.RowIndex].Cells[5].Value.ToString()));

                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            LoadOrder();
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            LoadOrder();
        }
    }
}
