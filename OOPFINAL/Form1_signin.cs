using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;
                         

namespace MOVIEFLIX_OOP
{
    public partial class Form1_signin : Form
    {
        
        
        SQLiteConnection m_dbConnection_signin; // The main DB Connection
        SQLiteCommand sql_query_signin;         // a general purpose query, can be overloaded as req.
        String username, password;              // for textbox data
        String response;                        // a generalized response string for MessageBoxes, reused as req.
        

        public Form1_signin()
        {
            InitializeComponent();
        }

        private void m_label_register_Click(object sender, EventArgs e)
        {
            Form2_registration f2 = new Form2_registration();
            f2.Show();                      
                                           
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            // Existence check for database...
            //
            if(!File.Exists("movieflix.sqlite"))
            {
                SQLiteConnection.CreateFile("movieflix.sqlite");
            }

            // connection string and open
            using (SQLiteConnection con = new SQLiteConnection("Data Source=movieflix.sqlite;Version=3;"))//connection string
            {

                con.Open();


                // existence check for users table
                SQLiteCommand check_table_existence = new SQLiteCommand("select count(*) from sqlite_master where type='table' and name='users'", con);
                SQLiteDataReader reader = check_table_existence.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["count(*)"].ToString() == "0")
                    {
                        // creation of users table if not present follows :
                        SQLiteCommand sql_create_table = new SQLiteCommand("create table users(id INTEGER PRIMARY KEY AUTOINCREMENT, email VARCHAR(20) NOT NULL, password VARCHAR(20) NOT NULL)", con);
                        sql_create_table.ExecuteNonQuery();
                    }
                }
           

                //end existence check/creation for users table

                // COOKIE SIMULATOR!
                //
                SQLiteCommand sql_query_createCookie = new SQLiteCommand("create table if not exists cookie(id integer primary key,cookie_id VARCHAR(20))", con);
                sql_query_createCookie.ExecuteNonQuery();
                //
                // /COOKIE SIMULATOR!

                SQLiteCommand sql_query_redirect = new SQLiteCommand("select cookie_id,count(*) from cookie", con);
                string cookie_id;
                SQLiteDataReader reader_redirect = sql_query_redirect.ExecuteReader();
                        while(reader_redirect.Read())
                        {
                            cookie_id = Convert.ToString(reader_redirect["cookie_id"]);
                            if (Convert.ToInt32(reader_redirect["count(*)"]) == 1)
                            {

                                reader_redirect.Dispose();
                                this.Hide();
                                Form3_MovieList f3 = new Form3_MovieList(cookie_id,"",false);
                                f3.ShowDialog();
                                this.Close();
                                break;
                            }

                        }               
            }

        }



        private void m_button_login_Click(object sender, EventArgs e)
        {

            username = m_textBox_email.Text;
            password = m_textBox_password.Text;
            using (SQLiteConnection con = new SQLiteConnection("Data Source=movieflix.sqlite"))
            {

                con.Open();
                sql_query_signin = new SQLiteCommand("select count(*) from users where email='" + username + "' and password='" + Utilities.md5_generator(password) + "'", con);
                SQLiteDataReader reader = sql_query_signin.ExecuteReader();

                while (reader.Read())
                {

                    response = (reader["count(*)"].ToString() != "0") ? "Successfully logged in" : "Invalid username/password";
                    
                }
                MessageBox.Show(response);


                if (response.Equals("Successfully logged in"))
                {

                    SQLiteCommand sql_query_remember = new SQLiteCommand("insert into cookie(cookie_id) values ('"+username+"')", con); //insert a string here, the username?
                    sql_query_remember.ExecuteNonQuery();
                    //m_dbConnection_signin.Close();
                    //hide this form
                    this.Hide();
                    //show new form
                    Form3_MovieList f3 = new Form3_MovieList(username,"",false);
                    f3.ShowDialog();
                    //close this form after f3 has exited
                    this.Close();
                }
            }
        }

        private void m_textBox_password_Click(object sender, EventArgs e)
        {
                m_textBox_password.Text = "";
        }

        private void m_textBox_email_Click(object sender, EventArgs e)
        {         
                m_textBox_email.Text = "";
        }
    }
}