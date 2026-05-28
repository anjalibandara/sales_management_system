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
    public partial class ProductModuleForm : Form
    {
        SqlConnection con = new SqlConnection(
            @"Data Source=(LocalDB)\MSSQLLocalDB;
            AttachDbFilename=C:\Users\harsh\Documents\dbMS.mdf;
            Integrated Security=True;
            Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public ProductModuleForm()
        {
            InitializeComponent();
        }
        public void LoudCategory()
        {
            comboQty.Items.Clear();
            cm = new SqlCommand("SELECT catname FROM tbCategory", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                comboQty.Items.Add(dr["catname"].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void comboQty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {


                if (MessageBox.Show(
                    "Are you sure you want to save this user?",
                    "Save User",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();

                    SqlCommand cm = new SqlCommand(
                        "INSERT INTO tbProduct(pname, pqty, pprice, pdescription, pcategory) " +
                        "VALUES(@pname, @pqty, @pprice, @pdescription, @pcategory)", con);

                    cm.Parameters.AddWithValue("@pname", textProductName.Text);
                    cm.Parameters.AddWithValue("@pqty", textQuantity.Text);
                    cm.Parameters.AddWithValue("@pprice", textPrice.Text);
                    cm.Parameters.AddWithValue("@pdescription", textDescription.Text);
                    cm.Parameters.AddWithValue("@pcategory", comboQty.Text);

                    cm.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("Product has been successfully saved!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                con.Close();

                MessageBox.Show(ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        public void Clear()
        {
            textProductName.Clear();
            textQuantity.Clear();
            textPrice.Clear();
            textDescription.Clear();
            comboQty.SelectedIndex = -1;
        }

        private void textProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (MessageBox.Show(
                    "Are you sure you want to update this product?",
                    "Update Product",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand cm = new SqlCommand(
                        "UPDATE tbProduct SET pname = @pname, pqty = @pqty, pprice = @pprice, pdescription = @pdescription, pcategory = @pcategory " +
                        "WHERE pid LIKE '" + lblPid.Text + "'", con);
                    cm.Parameters.AddWithValue("@pname", textProductName.Text);
                    cm.Parameters.AddWithValue("@pqty", textQuantity.Text);
                    cm.Parameters.AddWithValue("@pprice", textPrice.Text);
                    cm.Parameters.AddWithValue("@pdescription", textDescription.Text);
                    cm.Parameters.AddWithValue("@pcategory", comboQty.Text);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Product has been successfully updated!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    this.Dispose();
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
    }
}
