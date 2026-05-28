using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace SalesManagementSystem
{
    public partial class UserModuleForm : Form
    {
        // Database Connection
        SqlConnection con = new SqlConnection(
            @"Data Source=(LocalDB)\MSSQLLocalDB;
            AttachDbFilename=C:\Users\harsh\Documents\dbMS.mdf;
            Integrated Security=True;
            Connect Timeout=30");
        SqlCommand cm = new SqlCommand();

        public UserModuleForm()
        {
            InitializeComponent();

            // Connect Save Button Event
            btnSave.Click += btnSave_Click;

            // Connect Clear Button Event
            btnClear.Click += btnClear_Click;
        }

        // SAVE BUTTON
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (textRePass.Text != textRePass.Text)
                {
                    MessageBox.Show("Password does not match.",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                // Validation
                if (textUserName.Text == "" ||
                    textFullName.Text == "" ||
                    textRePass.Text == "" ||
                    textPhone.Text == "")
                {
                    MessageBox.Show("Please fill all fields.",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // Confirmation
                if (MessageBox.Show(
                    "Are you sure you want to save this user?",
                    "Save User",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();

                    SqlCommand cm = new SqlCommand(
                        "INSERT INTO tbUser(username, fullname, password, phone) " +
                        "VALUES(@username, @fullname, @password, @phone)", con);

                    cm.Parameters.AddWithValue("@username", textUserName.Text);
                    cm.Parameters.AddWithValue("@fullname", textFullName.Text);
                    cm.Parameters.AddWithValue("@password", textRePass.Text);
                    cm.Parameters.AddWithValue("@phone", textPhone.Text);

                    cm.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("User has been successfully saved!",
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

        // CLEAR BUTTON
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        // CLEAR TEXTBOXES
        public void Clear()
        {
            textUserName.Clear();
            textFullName.Clear();
            textRePass.Clear();
            textRePass.Clear();
            textPhone.Clear();

            textUserName.Focus();
        }

        private void textFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (textRePass.Text != textRePass.Text)
                {
                    MessageBox.Show("Password does not match.",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                if(MessageBox.Show(
                    "Are you sure you want to update this user?",
                    "Update User",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand cm = new SqlCommand(
                        "UPDATE tbUser SET fullname = @fullname, password = @password, phone = @phone " +
                        "WHERE username LIKE '" + textUserName.Text + "'", con);
                    cm.Parameters.AddWithValue("@fullname", textFullName.Text);
                    cm.Parameters.AddWithValue("@password", textRePass.Text);
                    cm.Parameters.AddWithValue("@phone", textPhone.Text);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("User has been successfully updated!",
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

        private void UserModuleForm_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}