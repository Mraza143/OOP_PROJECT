namespace MOVIEFLIX_OOP
{
    partial class Form3_MovieList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3_MovieList));
            this.m_richTextBox_details = new System.Windows.Forms.RichTextBox();
            this.m_picturebox_poster = new System.Windows.Forms.PictureBox();
            this.m_button_newMovie = new System.Windows.Forms.Button();
            this.m_button_editMovie = new System.Windows.Forms.Button();
            this.m_button_logout = new System.Windows.Forms.Button();
            this.m_label_username = new System.Windows.Forms.Label();
            this.m_textbox_search = new System.Windows.Forms.TextBox();
            this.m_button_search = new System.Windows.Forms.Button();
            this.m_button_findByGenre = new System.Windows.Forms.Button();
            this.m_comboBox_genre2 = new System.Windows.Forms.ComboBox();
            this.m_comboBox_genre1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_picturebox_poster)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // m_richTextBox_details
            // 
            this.m_richTextBox_details.Location = new System.Drawing.Point(1226, 496);
            this.m_richTextBox_details.Name = "m_richTextBox_details";
            this.m_richTextBox_details.ReadOnly = true;
            this.m_richTextBox_details.Size = new System.Drawing.Size(230, 182);
            this.m_richTextBox_details.TabIndex = 0;
            this.m_richTextBox_details.Text = "";
            // 
            // m_picturebox_poster
            // 
            this.m_picturebox_poster.BackColor = System.Drawing.Color.White;
            this.m_picturebox_poster.Location = new System.Drawing.Point(1224, 209);
            this.m_picturebox_poster.Name = "m_picturebox_poster";
            this.m_picturebox_poster.Size = new System.Drawing.Size(243, 292);
            this.m_picturebox_poster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.m_picturebox_poster.TabIndex = 1;
            this.m_picturebox_poster.TabStop = false;
            // 
            // m_button_newMovie
            // 
            this.m_button_newMovie.Location = new System.Drawing.Point(1226, 761);
            this.m_button_newMovie.Name = "m_button_newMovie";
            this.m_button_newMovie.Size = new System.Drawing.Size(110, 25);
            this.m_button_newMovie.TabIndex = 2;
            this.m_button_newMovie.Text = "Add a Movie...";
            this.m_button_newMovie.UseVisualStyleBackColor = true;
            this.m_button_newMovie.Click += new System.EventHandler(this.m_button_newMovie_Click);
            // 
            // m_button_editMovie
            // 
            this.m_button_editMovie.Location = new System.Drawing.Point(1226, 684);
            this.m_button_editMovie.Name = "m_button_editMovie";
            this.m_button_editMovie.Size = new System.Drawing.Size(230, 21);
            this.m_button_editMovie.TabIndex = 3;
            this.m_button_editMovie.Text = "Edit Details";
            this.m_button_editMovie.UseVisualStyleBackColor = false;
            this.m_button_editMovie.Click += new System.EventHandler(this.m_button_editMovie_Click);
            // 
            // m_button_logout
            // 
            this.m_button_logout.Location = new System.Drawing.Point(1323, 107);
            this.m_button_logout.Name = "m_button_logout";
            this.m_button_logout.Size = new System.Drawing.Size(74, 22);
            this.m_button_logout.TabIndex = 4;
            this.m_button_logout.Text = "Log Out";
            this.m_button_logout.UseVisualStyleBackColor = true;
            this.m_button_logout.Click += new System.EventHandler(this.m_button_logout_Click);
            // 
            // m_label_username
            // 
            this.m_label_username.AutoSize = true;
            this.m_label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_label_username.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.m_label_username.Location = new System.Drawing.Point(1092, 107);
            this.m_label_username.Name = "m_label_username";
            this.m_label_username.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.m_label_username.Size = new System.Drawing.Size(46, 18);
            this.m_label_username.TabIndex = 5;
            this.m_label_username.Text = "label1";
            this.m_label_username.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // m_textbox_search
            // 
            this.m_textbox_search.Location = new System.Drawing.Point(53, 224);
            this.m_textbox_search.Name = "m_textbox_search";
            this.m_textbox_search.Size = new System.Drawing.Size(170, 20);
            this.m_textbox_search.TabIndex = 6;
            this.m_textbox_search.Text = "Search a Movie by any keyword";
            this.m_textbox_search.Click += new System.EventHandler(this.m_textbox_search_click);
            // 
            // m_button_search
            // 
            this.m_button_search.BackColor = System.Drawing.Color.Black;
            this.m_button_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_button_search.ForeColor = System.Drawing.Color.Ivory;
            this.m_button_search.Location = new System.Drawing.Point(229, 224);
            this.m_button_search.Name = "m_button_search";
            this.m_button_search.Size = new System.Drawing.Size(96, 29);
            this.m_button_search.TabIndex = 7;
            this.m_button_search.Text = "Find...";
            this.m_button_search.UseVisualStyleBackColor = false;
            this.m_button_search.Click += new System.EventHandler(this.m_button_search_Click);
            // 
            // m_button_findByGenre
            // 
            this.m_button_findByGenre.BackColor = System.Drawing.Color.Black;
            this.m_button_findByGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_button_findByGenre.ForeColor = System.Drawing.Color.Ivory;
            this.m_button_findByGenre.Location = new System.Drawing.Point(130, 24);
            this.m_button_findByGenre.Name = "m_button_findByGenre";
            this.m_button_findByGenre.Size = new System.Drawing.Size(100, 47);
            this.m_button_findByGenre.TabIndex = 9;
            this.m_button_findByGenre.Text = "Search";
            this.m_button_findByGenre.UseVisualStyleBackColor = false;
            this.m_button_findByGenre.Click += new System.EventHandler(this.m_button_findByGenre_Click);
            // 
            // m_comboBox_genre2
            // 
            this.m_comboBox_genre2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_comboBox_genre2.FormattingEnabled = true;
            this.m_comboBox_genre2.Location = new System.Drawing.Point(6, 52);
            this.m_comboBox_genre2.Name = "m_comboBox_genre2";
            this.m_comboBox_genre2.Size = new System.Drawing.Size(100, 21);
            this.m_comboBox_genre2.TabIndex = 10;
            // 
            // m_comboBox_genre1
            // 
            this.m_comboBox_genre1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.m_comboBox_genre1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_comboBox_genre1.FormattingEnabled = true;
            this.m_comboBox_genre1.Location = new System.Drawing.Point(6, 19);
            this.m_comboBox_genre1.Name = "m_comboBox_genre1";
            this.m_comboBox_genre1.Size = new System.Drawing.Size(100, 21);
            this.m_comboBox_genre1.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_button_findByGenre);
            this.groupBox1.Controls.Add(this.m_comboBox_genre1);
            this.groupBox1.Controls.Add(this.m_comboBox_genre2);
            this.groupBox1.Location = new System.Drawing.Point(53, 260);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 82);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find Movie By Genre";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::OOPFINAL.Properties.Resources.axcvb_Untitled;
            this.pictureBox1.Location = new System.Drawing.Point(549, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1224, 728);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 28);
            this.button1.TabIndex = 14;
            this.button1.Text = "Add to favourites";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1341, 728);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 28);
            this.button2.TabIndex = 15;
            this.button2.Text = "View favourites";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1342, 760);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 27);
            this.button3.TabIndex = 16;
            this.button3.Text = "WatchList";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-257, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1771, 205);
            this.label1.TabIndex = 17;
            // 
            // Form3_MovieList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Ivory;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1024, 605);
            this.Controls.Add(this.m_picturebox_poster);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.m_button_search);
            this.Controls.Add(this.m_textbox_search);
            this.Controls.Add(this.m_label_username);
            this.Controls.Add(this.m_button_logout);
            this.Controls.Add(this.m_button_editMovie);
            this.Controls.Add(this.m_button_newMovie);
            this.Controls.Add(this.m_richTextBox_details);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1028, 598);
            this.Name = "Form3_MovieList";
            this.Text = "Movies List";
            this.Load += new System.EventHandler(this.Form3_MovieList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_picturebox_poster)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox m_richTextBox_details;
        private System.Windows.Forms.PictureBox m_picturebox_poster;
        private System.Windows.Forms.Button m_button_newMovie;
        private System.Windows.Forms.Button m_button_editMovie;
        private System.Windows.Forms.Button m_button_logout;
        private System.Windows.Forms.Label m_label_username;
        private System.Windows.Forms.TextBox m_textbox_search;
        private System.Windows.Forms.Button m_button_search;
        private System.Windows.Forms.Button m_button_findByGenre;
        private System.Windows.Forms.ComboBox m_comboBox_genre2;
        private System.Windows.Forms.ComboBox m_comboBox_genre1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
    }
}