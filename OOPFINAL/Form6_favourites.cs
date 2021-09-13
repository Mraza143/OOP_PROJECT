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
    public partial class Form6_favourites : Form
    {
        SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=movieflix.sqlite;Version=3;");
        SQLiteCommand sql_query;
        SQLiteDataReader reader;
        int i = 0;
        int ii = 0;
        string username;
        public Form6_favourites()
        {
            InitializeComponent();
        }
        public Form6_favourites(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form6_favourites_Load(object sender, EventArgs e)
        {
            m_dbConnection.Open();
            sql_query = new SQLiteCommand("select count(*) from movies where isFavourite=1", m_dbConnection);
            int m_numberOfPictures = 0;
            reader = sql_query.ExecuteReader();
            while (reader.Read())
            {
                m_numberOfPictures = Convert.ToInt32(reader["count(*)"]);                   //get number of pictures to be rendered, assign to a variable

            }

            reader.Dispose();

            PictureBox[] picturebox = new PictureBox[m_numberOfPictures];


            int x = 0; int y = 60;            // the coordinates

            for (i = 0; i < m_numberOfPictures; i++)
            {
                x++;
                picturebox[i] = new PictureBox();
                this.Controls.Add(picturebox[i]);

                if (i % 7 == 0) { x = 0; y = y + 230; }
           
                picturebox[i].Location = new Point(x * 180 + 10, y);
                picturebox[i].Size = new Size(180, 230);
                picturebox[i].SizeMode = PictureBoxSizeMode.Zoom;


                sql_query = new SQLiteCommand("select id,poster from movies where isFavourite=1 AND  id=" + (i +1), m_dbConnection);              
                reader = sql_query.ExecuteReader();
                // try-catch block**
                try
                {
                    while (reader.Read())
                    {
                        if (reader["poster"] != DBNull.Value)
                        {
                            byte[] a = (System.Byte[])reader["poster"];
                            picturebox[i].Image = Utilities.ByteToImage(a);
                            ii++;
                        }
                        else { picturebox[i].ImageLocation = @"placeholder.png"; }
                    }
                    reader.Dispose();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "DB_ERROR");
                }
                // **************/try-catch block****************************
                picturebox[i].Name = "" + i;
                
                
            }// end of for loop

            m_dbConnection.Close();

        }

        private void button_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            //show new form
            Form3_MovieList f3 = new Form3_MovieList(username, "", false);
            f3.ShowDialog();
            //close this form after f3 has exited
            this.Close();
        }
    }
}
