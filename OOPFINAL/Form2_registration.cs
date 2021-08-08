using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace MOVIEFLIX_OOP
{
    public partial class Form2_registration : Form
    {
        // summary
        // Initialize required database connections for insert here(since registration)
        // /summary

        SQLiteConnection m_dbConnection;
        SQLiteCommand sql_query;

        public Form2_registration()
        {
            InitializeComponent();
          

        }


        private void m_button_register_Click(object sender, EventArgs e)
        {
            String email, password, verification,password_md5;
            email = m_textbox_email.Text;
            password = m_textbox_password.Text;
            verification = m_textbox_verification.Text;

            if (!verification.Equals(password)) { MessageBox.Show("Passwords do not match, re-check"); }

            else
            {
                password_md5 = Utilities.md5_generator(password);

                m_dbConnection = new SQLiteConnection("Data Source=imdbclone.sqlite;Version=3;");
                m_dbConnection.Open();

                sql_query = new SQLiteCommand(@"insert into users(email,password) values ('" + email + "','" + password_md5 + "')", m_dbConnection);

                if (sql_query.ExecuteNonQuery() != 0)
                {
                    MessageBox.Show("Account created successfully");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Unable to create accountt");
                }
            }
            
 
        }

        private void Form2_registration_Load(object sender, EventArgs e)
        {

        }
    }
}
