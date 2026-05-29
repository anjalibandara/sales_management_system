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
    public partial class CustomerModuleForm : Form
    {
        SqlConnection con = new SqlConnection(
            @"Data Source=(LocalDB)\MSSQLLocalDB;
            AttachDbFilename=C:\Users\harsh\Documents\dbMS.mdf;
            Integrated Security=True;
            Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        public CustomerModuleForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button clicked");
            try
            {

                // Confirmation
                if (MessageBox.Show(
                    "Are you sure you want to save this customer?",
                    "Save Customer",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();

                    SqlCommand cm = new SqlCommand(
                        "INSERT INTO tbCustomer(cname, cphone) " +
                        "VALUES(@cname, @cphone)", con);

                    cm.Parameters.AddWithValue("@cname", textCName.Text);
                    cm.Parameters.AddWithValue("@cphone", textCPhone.Text);
                    //con.Open();


                    cm.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("User has been successfully saved!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    Clear();
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
            textCName.Clear();
            textCPhone.Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(
                    "Are you sure you want to update this customer?",
                    "Update Customer",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (con.State == ConnectionState.Open)
                        con.Close();

                    con.Open();

                    SqlCommand cm = new SqlCommand(
                        "UPDATE tbCustomer SET cname=@cname, cphone=@cphone WHERE cid=@cid",
                        con);

                    cm.Parameters.AddWithValue("@cid", Convert.ToInt32(lblCId.Text));
                    cm.Parameters.AddWithValue("@cname", textCName.Text);
                    cm.Parameters.AddWithValue("@cphone", textCPhone.Text);

                    int rows = cm.ExecuteNonQuery();

                    con.Close();

                    if (rows > 0)
                    {
                        MessageBox.Show(
                            "Customer updated successfully!",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        this.Close(); // close form after update
                    }
                    else
                    {
                        MessageBox.Show("Update failed. Record not found.");
                    }

                }
            }
            catch (Exception ex)
            {
                if (con.State == ConnectionState.Open)
                    con.Close();

                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void lblCId_Click(object sender, EventArgs e)
        {

        }

        private void CustomerModuleForm_Load(object sender, EventArgs e)
        {

        }
    }
}
