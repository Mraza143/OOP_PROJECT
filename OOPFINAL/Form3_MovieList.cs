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
    public partial class Form3_MovieList : Form
    {
        SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=movieflix.sqlite;Version=3;");
        SQLiteCommand sql_query;
        SQLiteDataReader reader;
        int i;
        int movieID;
        string welcome;
        string username;
        string searchstring,genreString1,genreString2;
        bool searchByGenre;
        string[] genres;
        
        public Form3_MovieList()
        {
            InitializeComponent();
        }
//
        public Form3_MovieList(string x, string genreString1,string genreString2, bool searchByGenre)
        {
            username = x;
            this.genreString1 = genreString1;
            this.genreString2 = genreString2;
            this.searchByGenre = searchByGenre;
            InitializeComponent();
            welcome = "Welcome, " + x;
        }
        public Form3_MovieList(string x,string searchstring,bool searchByGenre)
        {
            username = x;
            this.searchstring = searchstring;
            this.searchByGenre = searchByGenre;
            InitializeComponent();
            welcome = "Welcome, " + x;
        }

        private void Form3_MovieList_Load(object sender, EventArgs e)
        {
            m_label_username.Text = welcome;
            this.AutoScroll = true;          
            genres = new string[] {"Action/Adventure","Biopic/Historical","Comedy","Drama","Documentary","Fantasy","Horror","Romance","Sci-Fi","Superhero","Thriller/Mystery"};
            for (int i = 0; i < genres.Length; i++)
            {
                m_comboBox_genre1.Items.Add(genres[i]);
                m_comboBox_genre2.Items.Add(genres[i]);
            }

            m_dbConnection.Open();                                                          

            
            if (searchByGenre)
            {
                //CREATE TEMP TABLE
                sql_query = new SQLiteCommand("drop table if exists tmp", m_dbConnection);
                sql_query.ExecuteNonQuery();
                sql_query = new SQLiteCommand("create table tmp as select rowid,* from movies where (genre_main like '%"+genreString1+"%' and genre_secondary like '%"+genreString2+"%') or (genre_main like '%"+genreString2+"%' and genre_secondary like '%"+genreString1+"%') ", m_dbConnection);
                sql_query.ExecuteNonQuery();
            } 
            
            else
            {

                sql_query = new SQLiteCommand("drop table if exists tmp", m_dbConnection);
                sql_query.ExecuteNonQuery();
                sql_query = new SQLiteCommand("create table tmp as select rowid,* from movies where (name like '%" + searchstring + "%' or director like '%" + searchstring + "%' or actor_main like '%" + searchstring + "%' or actor_secondary like '%" + searchstring + "%')", m_dbConnection);
                sql_query.ExecuteNonQuery();
            }

                sql_query = new SQLiteCommand("select count(*) from tmp", m_dbConnection);
                int m_numberOfPictures = 0;
                reader = sql_query.ExecuteReader();
                while (reader.Read())
                {
                    m_numberOfPictures = Convert.ToInt32(reader["count(*)"]);

                }
                reader.Dispose();
                
                PictureBox[] picturebox = new PictureBox[m_numberOfPictures];            
                int x = 0; int y = 260;
                for (i = 0; i < m_numberOfPictures; i++)
                {
                    x++;
                picturebox[i] = new PictureBox();
                this.Controls.Add(picturebox[i]);
                    if (i % 5 == 0) { x = 0; y = y + 260; }                   
                    picturebox[i].Location = new Point(x * 200 + 100, y);                   
                    picturebox[i].Size = new Size(200, 260);
                    picturebox[i].SizeMode = PictureBoxSizeMode.Zoom;
                   

                     sql_query = new SQLiteCommand("select id,poster,rowid from tmp where rowid=" + (i + 1), m_dbConnection);                   
                    reader = sql_query.ExecuteReader();
                    
                    try
                    {
                        while (reader.Read())
                        {
                            if (reader["poster"] != DBNull.Value)
                            {
                                byte[] a = (System.Byte[])reader["poster"];
                                picturebox[i].Image = Utilities.ByteToImage(a);
                            }
                            else { picturebox[i].ImageLocation = @"placeholder.png"; }
                        }
                        reader.Dispose();
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message, "DB_ERROR");
                    }
                    
                    picturebox[i].Name = "" + i;
                    picturebox[i].Click += handleClick;
                }// end of for loop

                m_dbConnection.Close();           
        }
        void handleClick(object sender, EventArgs e)
        {
            if (m_dbConnection.State != ConnectionState.Open)
            {
                m_dbConnection.Open();
            }
            PictureBox picbox = sender as PictureBox;
            i = Convert.ToInt32(picbox.Name);
           
            sql_query = new SQLiteCommand("select rowid,* from tmp a where rowid=" + (i+1),m_dbConnection);
            reader = sql_query.ExecuteReader();
            while (reader.Read())
            {
                m_richTextBox_details.Text = "";
                m_richTextBox_details.AppendText( "Name: " + reader["name"] + "\n" + "Directed by: " + reader["director"] + "\n" + "LEAD: " + reader["actor_main"] + "\n" + "SUPPORTING ACTORS: " + reader["actor_secondary"] + "\n" + "MAIN GENRE: " + reader["genre_main"] + "\n" + "SECONDARY GENRE: " + reader["genre_secondary"] + "\n" + "PLOT: " + reader["summary"] + "\n");
                
                movieID = Convert.ToInt32(reader["id"]);

                if (reader["poster"] != DBNull.Value)
                {
                    byte[] a = (System.Byte[])reader["poster"];
                    m_picturebox_poster.Image = Utilities.ByteToImage(a);
                }
                else
                {
                    m_picturebox_poster.ImageLocation = @"placeholder.png";
                }
            }
            reader.Dispose();
            m_dbConnection.Close();

        }

        private void m_button_newMovie_Click(object sender, EventArgs e)
        {
            this.Hide();           
            Form4_addMovie f4 = new Form4_addMovie(username);
            this.Close();
            f4.ShowDialog();
            
        }

        private void m_button_editMovie_Click(object sender, EventArgs e)
        {
            int id = movieID;
            if (id == 0)                  
            {
                MessageBox.Show("No movie selected");
            }
            else
            {
                Form5_editMovie f5 = new Form5_editMovie(id, username,genres);
                this.Hide();
                f5.ShowDialog();
                this.Close();
            }
        }

        private void m_button_logout_Click(object sender, EventArgs e)
        {
            //m_dbConnection.Open();
            using (SQLiteConnection con = new SQLiteConnection("Data Source=movieflix.sqlite;Version=3;"))
            {
                con.Open();
                using (SQLiteCommand sql_delete = new SQLiteCommand("delete from cookie", con))
                {
                   sql_delete.ExecuteNonQuery();
                }
            }
            this.Hide();
            Form1_signin f1 = new Form1_signin();
            f1.ShowDialog();
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Make favourite button
            if (m_dbConnection.State != ConnectionState.Open)
            {                
                m_dbConnection.Open();
            }
            sql_query = new SQLiteCommand("update movies set isFavourite=1 where id=" +movieID, m_dbConnection);
            sql_query.ExecuteNonQuery();          
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //view favourites button
            this.Hide();
            Form6_favourites f6 = new Form6_favourites(username);
            f6.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //watchList button
            this.Hide();
            Form7_watchList f7 = new Form7_watchList(username);
            f7.ShowDialog();
        }

        private void m_textbox_search_click(object sender, EventArgs e)
        {
            m_textbox_search.Text = "";
        }

       
        private void m_button_search_Click(object sender, EventArgs e)
        {
            
            searchstring = m_textbox_search.Text;
            searchByGenre = false;
            Form3_MovieList f3 = new Form3_MovieList(username, searchstring, searchByGenre);
            this.Hide();
            f3.ShowDialog();
            this.Close();
        }
//#
        private void m_button_findByGenre_Click(object sender, EventArgs e)
        {
            genreString1 = (m_comboBox_genre1.SelectedItem != null) ? m_comboBox_genre1.SelectedItem.ToString() : "";
            genreString2 = (m_comboBox_genre2.SelectedItem != null) ? m_comboBox_genre2.SelectedItem.ToString() : "";
            searchByGenre = true;
            Form3_MovieList f3 = new Form3_MovieList(username, genreString1,genreString2, searchByGenre);
            this.Hide();
            f3.ShowDialog();
            this.Close();
        }
    }
}
