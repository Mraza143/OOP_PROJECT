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
//######################################################################################################################################################################
    public partial class Form4_addMovie : Form
    {
        //  GloVars
        //
        SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=IMDBClone.sqlite;Version=3;");
        SQLiteCommand sql_query;
        SQLiteDataReader reader;
        string username;
        //
        // /GloVars
//######################################################################################################################################################################
        public Form4_addMovie(string x)
        {
            InitializeComponent();
            username = x;
        }
 //######################################################################################################################################################################
       
 //######################################################################################################################################################################
        private void m_button_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Choose Image";
            dlg.Filter = "Image Files (*.jfif;*.jpg;*.bmp;*.png;*.jpeg)|*.jfif;*.jpg;*.bmp;*.png;*.jpeg";

            if(dlg.ShowDialog() == DialogResult.OK)
            {
                m_textBox_filepath.Text = dlg.FileName;
            }

            dlg.Dispose();
        }
//######################################################################################################################################################################
        private void m_button_addMovie_Click(object sender, EventArgs e)
        {
            m_dbConnection.Open();
            Image image;
            byte[] imageBytes;

            sql_query = new SQLiteCommand("insert into movies(name,director,actor_main,actor_secondary,genre_main,genre_secondary,summary,poster) values (@name,@director,@actor_main,@actor_secondary,@genre_main,@genre_secondary,@summary,@poster)", m_dbConnection);
            SQLiteParameter name                = new SQLiteParameter("@name",              System.Data.DbType.String);
            SQLiteParameter director            = new SQLiteParameter("@director",          System.Data.DbType.String);
            SQLiteParameter actor_main          = new SQLiteParameter("@actor_main",        System.Data.DbType.String);
            SQLiteParameter actor_secondary     = new SQLiteParameter("@actor_secondary",   System.Data.DbType.String);
            SQLiteParameter genre_main = new SQLiteParameter("@genre_main", System.Data.DbType.String);
            SQLiteParameter genre_secondary = new SQLiteParameter("@genre_secondary", System.Data.DbType.String);
            SQLiteParameter summary             = new SQLiteParameter("@summary",           System.Data.DbType.String);
            SQLiteParameter poster              = new SQLiteParameter("@poster",            System.Data.DbType.Binary);

            name.Value                      = m_textBox_name.Text;
            director.Value                  = m_textBox_director.Text;
            actor_main.Value                = m_textBox_actorMain.Text;
            actor_secondary.Value           = m_textBox_actorSecondary.Text;
            genre_main.Value = m_textBox_genre.Text;
            genre_secondary.Value = textBox2.Text;
            summary.Value                   = m_richTextBox_summary.Text;

            if (!m_textBox_filepath.Text.Equals(""))
            {
                image = new Bitmap(m_textBox_filepath.Text);
                imageBytes = Utilities.ImageToBytes(image, System.Drawing.Imaging.ImageFormat.Jpeg);

                poster.Value = imageBytes;
                
            }
           

           
            sql_query.Parameters.Add(name);
            sql_query.Parameters.Add(director);
            sql_query.Parameters.Add(actor_main);
            sql_query.Parameters.Add(actor_secondary);
            sql_query.Parameters.Add(genre_main);
            sql_query.Parameters.Add(genre_secondary);

            sql_query.Parameters.Add(summary);
            sql_query.Parameters.Add(poster);


            try
            {
                sql_query.ExecuteNonQuery();
                MessageBox.Show("Successfully added new movie.");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            m_dbConnection.Close();
            this.Hide();
           Form3_MovieList f3 = new Form3_MovieList(username,"",false); //need to send string of current user
           this.Close();
            f3.ShowDialog();

            
           
                /*FileStream stream = new FileStream(
      filePath, FileMode.Open, FileAccess.Read);
  BinaryReader reader = new BinaryReader(stream);

  byte[] photo = reader.ReadBytes((int)stream.Length);

  reader.Close();
  stream.Close();
                 return photo; */

        }

        private void m_button_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3_MovieList f3 = new Form3_MovieList(username,"",false);//need to send string of current user
            this.Close();
            f3.ShowDialog();
        }

        private void Form4_addMovie_Load(object sender, EventArgs e)
        {

        }
        //######################################################################################################################################################################
    }
}
