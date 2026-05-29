using Microsoft.Data.SqlClient;
using System.Data;

namespace SalesManagementSystem
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(
          @"Data Source=(LocalDB)\MSSQLLocalDB;
            AttachDbFilename=C:\Users\harsh\Documents\dbMS.mdf;
            Integrated Security=True;
            Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
                textpassword.UseSystemPasswordChar = true;
            else textpassword.UseSystemPasswordChar = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void ShowAllUsers()
        {
            try
            {
                SqlCommand cmdUsers = new SqlCommand(
                    "SELECT username, password FROM tbUser",
                    con);

                if (con.State == ConnectionState.Closed)
                    con.Open();

                SqlDataReader reader = cmdUsers.ExecuteReader();

                string users = "";

                while (reader.Read())
                {
                    users += "Username: " + reader["username"].ToString()
                          + " | Password: " + reader["password"].ToString()
                          + "\n";
                }

                reader.Close();

                MessageBox.Show(users, "User List");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM tbUser WHERE username=@username AND password=@password", con);
                cmd.Parameters.AddWithValue("@username", textBox1.Text);
                cmd.Parameters.AddWithValue("@password", textpassword.Text);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read()) 
                {
                    MessageBox.Show("Welcome " + dr["fullname"].ToString() + "!", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mainForm main = new mainForm();
                    this.Hide();
                    main.ShowDialog();

                }
            
                else
                {
                    MessageBox.Show("Invalid username or password!", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
