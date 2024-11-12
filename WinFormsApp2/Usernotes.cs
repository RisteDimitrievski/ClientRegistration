using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;

namespace WinFormsApp2
{
    public partial class Usernotes : Form
    {
        private System.Data.SqlTypes.SqlInt64 __userId;
        private System.Data.SqlClient.SqlConnection __conn;
        public Usernotes(System.Data.SqlTypes.SqlInt64 userId, System.Data.SqlClient.SqlConnection conn)
        {
            __userId = userId;
            InitializeComponent();
            __conn = conn;
        }
        public bool setNote(string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                note.Text = text;
                return true;
            }
            return true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
           if(UserNoteExist())
            {
                UpdateUserNote(note.Text);
                return;
            } 
                InsertToDatabase();
                return;
       
            
        }
        private bool UpdateUserNote(string text)
        {
            string query = "UPDATE client_notes SET user_note = @note, date = @d WHERE user_id = @uid";
            using (SqlCommand cmd = new SqlCommand(query, __conn))
            {
                cmd.Parameters.AddWithValue("@note", text);
                string date = DateTime.Now.ToString();
                cmd.Parameters.AddWithValue("@d", date);
                cmd.Parameters.AddWithValue("@uid", __userId);
                int rowsAffected = cmd.ExecuteNonQuery();
                if(rowsAffected > 0)
                {
                    MessageBox.Show("Successfully saved your note!", "Note saved successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                } else
                {
                    MessageBox.Show("Failed to save your note.", "Note failed to save", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return false;
        }
        private bool UserNoteExist()
        {
            string query = "SELECT COUNT(*) FROM client_notes WHERE user_id = @uid";
            using(SqlCommand cmd = new SqlCommand(query, __conn))
            {
                cmd.Parameters.AddWithValue("@uid", __userId);
                int count = (int)cmd.ExecuteScalar();
                if(count > 0)
                {
                    return true;
                }
                return false;
            }
        }
        private bool InsertToDatabase()
        {
            string data = @$"{note.Text}";
            string insertQuery = "INSERT INTO client_notes (user_id, user_note, date) VALUES (@uid, @note, @date)";
            using (SqlCommand cmd = new SqlCommand(insertQuery, __conn))
            {
                cmd.Parameters.AddWithValue("@uid", __userId);
                cmd.Parameters.AddWithValue("@note", data);
                string date = DateTime.Now.ToString();
                cmd.Parameters.AddWithValue("@date", date);
                int count = (int)cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("Your note has been saved successfully", "Note saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Failed to save your note!", "Note not saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
            return false;
        }
    }
}

