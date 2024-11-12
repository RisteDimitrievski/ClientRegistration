using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Numerics;
using Microsoft.VisualBasic.ApplicationServices;

namespace WinFormsApp2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 registration = new Form1();
            registration.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using(SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BHPJ89K\\SQLEXPRESS;Initial Catalog=registrations;Integrated Security=True;TrustServerCertificate=True"))
            {
                if(conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "SELECT COUNT(*) FROM clients WHERE email=@em AND password=@pa";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@em", email.Text);
                    cmd.Parameters.AddWithValue("@pa", password.Text);
                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        
       
                        string q2 = "SELECT user_id from clients where email = @e";
                        using (SqlCommand userData = new SqlCommand(q2, conn))
                        {
                            userData.Parameters.AddWithValue("@e", email.Text);
                            SqlDataReader reader = userData.ExecuteReader();
                            if (reader.Read())
                            {
                                 System.Data.SqlTypes.SqlInt64 userId = reader.GetSqlInt64(0);
                                reader.Close();
                                string data = "SELECT * FROM client_notes WHERE user_id = @u";
                                using (SqlCommand cmd2 = new SqlCommand(data, conn))
                                {
                                    cmd2.Parameters.AddWithValue("@u", userId);
                                    SqlDataReader r = cmd2.ExecuteReader();
                                    if (r.Read())
                                    {
                       
                                        this.Hide();
                                        Usernotes notes = new Usernotes(userId, conn);
                                        string notesData = @$"{r.GetDateTime(3)} - {r.GetSqlString(2)}";
                                            r.Close();
                                        notes.setNote(notesData);
                                        notes.ShowDialog();
                                        
                                    } else
                                    {
                                        this.Hide();
                                        r.Close();
                                        Usernotes notes = new Usernotes(userId, conn);
                                        notes.ShowDialog();
                                    }
                                    
                                }
                 
                            }
                            reader.Close();
           
                        }
            
                    } else
                    {
                        MessageBox.Show($"Invalid email address or password {count}", "Wrong credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
        }
    }
}
