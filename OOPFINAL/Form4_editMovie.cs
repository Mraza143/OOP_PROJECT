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
using System.IO;

namespace MOVIEFLIX_OOP
{

    public partial class Form5_editMovie : Form
    {
        
        SQLiteConnection m_dbConnection;
        SQLiteCommand sql_query;
        SQLiteDataReader reader;
        int i;
        string username;
        bool photoIsEmpty;
        string[] genres;
        //
        // /GloVars
//#####################################################################################################################################################################
        public Form5_editMovie()                                                            //DEFAULT CONSTRUCTOR
        {
            InitializeComponent();
        }
//#####################################################################################################################################################################   
        public Form5_editMovie(int id,string x,string[] genres)                                                      //OVERLOADING CONSTRUCTOR TO RECEIVE IDENTIFIER OF 
                                                                                            //CURRENT ACTIVE RECORD FROM Form3
        {
            InitializeComponent();
            username = x;
            i = id;
            this.genres = genres;                                                     
        }
//#####################################################################################################################################################################
        private void Form5_editMovie_Load(object sender, EventArgs e)                       //SINCE THIS IS EDITING, FILL UP FIELDS WITH DETAILS OF 
                                                                                            //CURRENTLY ACTIVE RECORD
        {
            //Fill up the genre dropdown box 
            for (int x = 0; x < genres.Length;x++ )
            {
                m_comboBox_genre1.Items.Add(genres[x]);
                m_comboBox_genre2.Items.Add(genres[x]);
            }
            // /Fill up the genre dropdown box 

                using (m_dbConnection = new SQLiteConnection("Data Source=movieflix.sqlite"))
                {
                    m_dbConnection.Open();

                    //sql_query = new SQLiteCommand("select name,director,actor_main,actor_secondary,summary,(select count(*) from movies b where b.id>=a.id) as Rid from movies a where Rid="+i,m_dbConnection);
                    sql_query = new SQLiteCommand("select * from movies where id=" + i, m_dbConnection);
                    reader = sql_query.ExecuteReader();                                                     // this syntax assigns result of query to datareader object   

                    while (reader.Read())                                         // Datareader.read method is used to obtain a row from the query results
                {                                                                 // we can access each column of the returned row by passing the name to the reader

                        m_textBox_name.Text             = (reader["name"]               != DBNull.Value) ? Convert.ToString(reader["name"]) : "";        // ternary or conditional operator
                        m_textBox_director.Text         = (reader["director"]           != DBNull.Value) ? Convert.ToString(reader["director"]) : "";
                        m_textBox_actorMain.Text        = (reader["actor_main"]         != DBNull.Value) ? Convert.ToString(reader["actor_main"]) : "";
                        m_textBox_actorSecondary.Text   = (reader["actor_secondary"]    != DBNull.Value) ? Convert.ToString(reader["actor_secondary"]) : "";
                        m_comboBox_genre1.SelectedItem  = (reader["genre_main"]         != DBNull.Value) ? Convert.ToString(reader["genre_main"]) : "";
                        m_comboBox_genre2.SelectedItem =  (reader["genre_secondary"]    != DBNull.Value) ? Convert.ToString(reader["genre_secondary"]) : "";
                        m_richTextBox_summary.Text      = (reader["summary"]            != DBNull.Value) ? Convert.ToString(reader["summary"]) : "";
                        //m_pictureBox_poster goes here
                        if (reader["poster"] != DBNull.Value)
                        {
                            photoIsEmpty = false;                                 
                            byte[] a = (System.Byte[])reader["poster"];                    // converting poster from binary datatype to image by making an array
                            m_picturebox_poster.Image = Utilities.ByteToImage(a);          // because poster is in binary form in database
                        }
                        else
                        {
                            m_picturebox_poster.ImageLocation = @"placeholder.png";                // default image location
                        }

                    }

                }
        }
//#####################################################################################################################################################################
        private void m_button_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3_MovieList f3 = new Form3_MovieList(username,"",false);           //sending details of current user by making an object of form 3 and giving it parameters    
            f3.ShowDialog();
            this.Close();
        }
//#####################################################################################################################################################################
        private void m_button_editConfirm_Click(object sender, EventArgs e)
        {
            //update database
            Image img;
            byte[] imageBytes;
            string commandtext;

            

            using(m_dbConnection = new SQLiteConnection("Data Source=movieflix.sqlite"))
            {
                m_dbConnection.Open();
               
                    SQLiteParameter name            = new SQLiteParameter("@name",              System.Data.DbType.String);  //?
                    SQLiteParameter director        = new SQLiteParameter("@director",          System.Data.DbType.String);
                    SQLiteParameter actor_main      = new SQLiteParameter("@actor_main",        System.Data.DbType.String);
                    SQLiteParameter actor_secondary = new SQLiteParameter("@actor_secondary",   System.Data.DbType.String);
                    SQLiteParameter genre_main      = new SQLiteParameter("@genre_main",        System.Data.DbType.String);
                    SQLiteParameter genre_secondary = new SQLiteParameter("@genre_secondary",   System.Data.DbType.String);
                    SQLiteParameter summary         = new SQLiteParameter("@summary",           System.Data.DbType.String);
                    SQLiteParameter poster          = new SQLiteParameter("@poster",            System.Data.DbType.Binary);

                    name.Value              =   m_textBox_name.Text;
                    director.Value          =   m_textBox_director.Text;
                    actor_main.Value        =   m_textBox_actorMain.Text;
                    actor_secondary.Value   =   m_textBox_actorSecondary.Text;
                    summary.Value           =   m_richTextBox_summary.Text;
                    genre_main.Value        =   m_comboBox_genre1.SelectedItem;
                    genre_secondary.Value  =   m_comboBox_genre2.SelectedItem;

                    if(m_textBox_filepath.Text.Equals("")==false && photoIsEmpty==false) //changed for readability 11 jun 15
                    {
                        // just have a string for the sqlitecommand instead v
                        commandtext = "update movies set name=@name,director=@director,actor_main=@actor_main,actor_secondary=@actor_secondary,genre_main=@genre_main,genre_secondary=@genre_secondary,summary=@summary,poster=@poster where id=" + i;
                        // /just have a string for the sqlitecommand instead ^
                        sql_query = new SQLiteCommand(commandtext, m_dbConnection);
                        img = new Bitmap(m_textBox_filepath.Text);                                                // converts filepath into image 
                        imageBytes = Utilities.ImageToBytes(img, System.Drawing.Imaging.ImageFormat.Jpeg);        // converts image into binary form as we have to store it in database

                        poster.Value        =   imageBytes;

                        sql_query.Parameters.Add(name);         //??
                        sql_query.Parameters.Add(director);
                        sql_query.Parameters.Add(actor_main);
                        sql_query.Parameters.Add(actor_secondary);
                        sql_query.Parameters.Add(genre_main);
                        sql_query.Parameters.Add(genre_secondary);
                        sql_query.Parameters.Add(summary);
                        sql_query.Parameters.Add(poster);
                    }
                    else               // when we dont have an image
                    {
                        commandtext = "update movies set name=@name,director=@director,actor_main=@actor_main,actor_secondary=@actor_secondary,genre_main=@genre_main,genre_secondary=@genre_secondary,summary=@summary where id=" + i;
                        sql_query = new SQLiteCommand(commandtext, m_dbConnection);
                        sql_query.Parameters.Add(name);
                        sql_query.Parameters.Add(director);
                        sql_query.Parameters.Add(actor_main);
                        sql_query.Parameters.Add(actor_secondary);
                        sql_query.Parameters.Add(genre_main);
                        sql_query.Parameters.Add(genre_secondary);
                        sql_query.Parameters.Add(summary);
                        
                    }
                    try
                    {
                        sql_query.ExecuteNonQuery();       
                        MessageBox.Show("Updated Successfully.");
                    }
                    catch (Exception exc)        
                    {
                        MessageBox.Show(exc.Message);
                    }
                
            }
            
            this.Hide();
            Form3_MovieList f3 = new Form3_MovieList(username,"",false);       //need to send string of current user
            f3.ShowDialog();
            
            this.Close();
        }

        private void m_button_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();        //??
            dlg.Title = "Choose Image";
            dlg.Filter = "Image Files (*.jfif;*.jpg;*.bmp;*.png;*.jpeg)|*.jfif;*.jpg;*.bmp;*.png;*.jpeg";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                m_textBox_filepath.Text = dlg.FileName;
            }
            dlg.Dispose();
        }
        //#####################################################################################################################################################################
    }
}
