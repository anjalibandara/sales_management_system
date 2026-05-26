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
                // Validation
                if (textUserName.Text == "" ||
                    textFullName.Text == "" ||
                    textPass.Text == "" ||
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
                    cm.Parameters.AddWithValue("@password", textPass.Text);
                    cm.Parameters.AddWithValue("@phone", textPhone.Text);

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
            textPass.Clear();
            textPhone.Clear();

            textUserName.Focus();
        }
    }
}