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
    public partial class CategoryModuleForm : Form
    {
        SqlConnection con = new SqlConnection(
           @"Data Source=(LocalDB)\MSSQLLocalDB;
            AttachDbFilename=C:\Users\harsh\Documents\dbMS.mdf;
            Integrated Security=True;
            Connect Timeout=30");
        SqlCommand cm = new SqlCommand();

        public CategoryModuleForm()
        {
            InitializeComponent();
        }

        private void CategoryModuleForm_Load(object sender, EventArgs e)
        {

        }
        public void Clear()
        {
            textCatName.Clear();
            //textCPhone.Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Confirmation
                if (MessageBox.Show(
                    "Are you sure you want to save this category?",
                    "Save Category",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();

                    SqlCommand cm = new SqlCommand(
                        "INSERT INTO tbCategory(catname) " +
                        "VALUES(@catname)", con);

                    cm.Parameters.AddWithValue("@catname", textCatName.Text);

                    //con.Open();


                    cm.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("Category has been successfully saved!",
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
                    "Are you sure you want to update this category?",
                    "Update Category",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (con.State == ConnectionState.Open)
                        con.Close();

                    con.Open();

                    SqlCommand cm = new SqlCommand(
                        "UPDATE tbCategory SET catname=@catname WHERE catid=@catid",
                        con);

                    cm.Parameters.AddWithValue("@catid", textCatId.Text);
                    cm.Parameters.AddWithValue("@catname", textCatName.Text);

                    int rows = cm.ExecuteNonQuery();

                    con.Close();

                    if (rows > 0)
                    {
                        MessageBox.Show(
                            "Category updated successfully!",
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
    }
}
