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
    public partial class Form7_watchList : Form
    {
        SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=movieflix.sqlite;Version=3;");
        SQLiteCommand sql_query;
        SQLiteDataReader reader;
        int i = 0;
        int ii = 0;
        int idd = 0;
        int index = 0;
        public Form7_watchList()
        {
            InitializeComponent();
        }

        private void Form7_watchList_Load(object sender, EventArgs e)
        {
            m_dbConnection.Open();
            sql_query = new SQLiteCommand("select * from movies", m_dbConnection);
            reader = sql_query.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(Convert.ToString(reader["name"]));         
                //get number of pictures to be rendered, assign to a variable

            }

            reader.Dispose();

            sql_query = new SQLiteCommand("select count(*) from movies", m_dbConnection);
            int m_numberOfPictures = 0;
            reader = sql_query.ExecuteReader();
            while (reader.Read())
            {
                m_numberOfPictures = Convert.ToInt32(reader["count(*)"]);                   //get number of pictures to be rendered, assign to a variable

            }

            reader.Dispose();

            PictureBox[] picturebox = new PictureBox[m_numberOfPictures];
            Label[] labels = new Label[m_numberOfPictures +1];


            int x = 0; int y = 60;            // the coordinates

            for (i = 0; i < m_numberOfPictures; i++)
            {
                x++;
                picturebox[i] = new PictureBox();
                labels[i] = new Label();
                

                if (ii % 4 == 0) { x = 0; y = y + 240; }

                //picturebox[i].BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                picturebox[i].Location = new Point(x * 140 + 10, y);
                labels[i].Location = new Point(x * 140 + 10, y+190);


                picturebox[i].Size = new Size(140, 190);
                labels[i].Size = new Size(50 , 20);
                labels[i].BackColor = Color.LightYellow;
                labels[i].Visible = true;
                labels[i].BringToFront();


                picturebox[i].SizeMode = PictureBoxSizeMode.Zoom;

                //sql_query = new SQLiteCommand("select id,poster,name from watchList", m_dbConnection);
                sql_query = new SQLiteCommand("select id,poster,name from watchList where id=" + (i+1 ), m_dbConnection);
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
                            labels[i].Text = Convert.ToString(reader["name"]);
                            ii++;
                            this.Controls.Add(picturebox[i]);
                            this.Controls.Add(labels[i]);
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
                picturebox[i].Click += handleClick;


            }// end of for loop

            m_dbConnection.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_dbConnection.State != ConnectionState.Open)
            {
                m_dbConnection.Open();
            }
             index = comboBox1.SelectedIndex;
            //sql_query = new SQLiteCommand("select id,poster,name from watchList where id=" + (i + 1), m_dbConnection);
            sql_query = new SQLiteCommand("Insert into watchList(id,name,poster) select id ,name , poster FROM movies where id=" + (index + 1), m_dbConnection);
            sql_query.ExecuteNonQuery();
            //this.Refresh();
            
             

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (m_dbConnection.State != ConnectionState.Open)
            {
                m_dbConnection.Open();
            }
            
            sql_query = new SQLiteCommand("delete from watchList  where id=" + (idd ), m_dbConnection);
            //sql_query = new SQLiteCommand("select rowid,* from tmp a where rowid=" + (i + 1), m_dbConnection);
            sql_query.ExecuteNonQuery();
        }

        private void handleClick(object sender, EventArgs e)
        {
            if (m_dbConnection.State != ConnectionState.Open)
            {
                m_dbConnection.Open();
            }
            PictureBox picbox = sender as PictureBox;
            idd = Convert.ToInt32(picbox.Name);
            //sql_query = new SQLiteCommand("delete from watchList  where id=" + (idd + 1), m_dbConnection);
            //sql_query = new SQLiteCommand("select rowid,* from tmp a where rowid=" + (i + 1), m_dbConnection);
            //sql_query.ExecuteNonQuery();
        }
    }
}
