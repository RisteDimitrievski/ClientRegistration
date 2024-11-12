using System.Data.SqlClient;
namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            if (string.IsNullOrEmpty(fname.Text))
            {
                MessageBox.Show("Please enter your name ", "Name required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(string.IsNullOrEmpty(email.Text))
            {
                MessageBox.Show("Please enter your email address ", "Email required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(string.IsNullOrEmpty(password.Text))
            {
                MessageBox.Show("Please enter your account password", "Password required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(string.IsNullOrEmpty(address.Text))
            {
                MessageBox.Show("Please enter your address", "Address required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(string.IsNullOrEmpty(postalcode.Text))
            {
                MessageBox.Show("Please enter your postal code", "Postal code required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(city.Text))
            {
                MessageBox.Show("Please enter your city", "City required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using(SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BHPJ89K\\SQLEXPRESS;Initial Catalog=registrations;Integrated Security=True;TrustServerCertificate=True"))
            {
                if(conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                // check if client already exists with the same email address and name
                string query = "SELECT fname,email FROM clients WHERE fname=@fname AND email=@e";
                SqlCommand check = new SqlCommand(query, conn);
                check.Parameters.AddWithValue("@fname", fname.Text);
                check.Parameters.AddWithValue("@e", email.Text);
                SqlDataReader reader = check.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("Client with the same name and email address already exists", "Client already exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                reader.Close();

                // Registration begins
                string insertQuery = "INSERT INTO clients (fname,email, password, address, postalcode,city) VALUES (@fname, @e, @password, @address, @postalcode, @city)";
                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@fname", fname.Text);
                cmd.Parameters.AddWithValue("@e", email.Text);
                cmd.Parameters.AddWithValue("@password", password.Text);
                cmd.Parameters.AddWithValue("@address", address.Text);
                cmd.Parameters.AddWithValue("@postalcode", postalcode.Text);
                cmd.Parameters.AddWithValue("@city", city.Text);
                int rowAffected = cmd.ExecuteNonQuery();
                if(rowAffected > 0)
                {
                    MessageBox.Show("Client registered successfully", "Registration Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                } else
                {
                    MessageBox.Show("Cliend failed to register", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
    }
}
