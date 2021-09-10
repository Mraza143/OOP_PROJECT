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
        public Form6_favourites()
        {
            InitializeComponent();
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

                if (i % 4 == 0) { x = 0; y = y + 190; }

                //picturebox[i].BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                picturebox[i].Location = new Point(x * 140 + 10, y);

                picturebox[i].Size = new Size(140, 190);


                picturebox[i].SizeMode = PictureBoxSizeMode.Zoom;


                sql_query = new SQLiteCommand("select id,poster from movies where isFavourite=1 AND  id=" + (i +1), m_dbConnection);
                //sql_query = new SQLiteCommand("select poster from tmp where rowid=" + (i+1), m_dbConnection);
                reader = sql_query.ExecuteReader();
                // **************try-catch block****************************
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
            /*m_dbConnection.Open();
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

            for (int i = 0; i < m_numberOfPictures; i++)
            {
                x++;
                picturebox[i] = new PictureBox();
                this.Controls.Add(picturebox[i]);

                if (i % 4 == 0) { x = 0; y = y + 190; }

                //picturebox[i].BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                picturebox[i].Location = new Point(x * 140 + 10, y);

                picturebox[i].Size = new Size(140, 190);
                

                picturebox[i].SizeMode = PictureBoxSizeMode.Zoom;
                
                sql_query = new SQLiteCommand("select poster from movies where  isFavourite= 1 AND id =" + i+1, m_dbConnection);
                
                reader = sql_query.ExecuteReader();
                // **************try-catch block****************************
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

            }
            m_dbConnection.Close();*/

        }
        }
}
