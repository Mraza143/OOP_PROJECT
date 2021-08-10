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
            ((System.ComponentModel.ISupportInitialize)(this.m_picturebox_poster)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_richTextBox_details
            // 
            this.m_richTextBox_details.Location = new System.Drawing.Point(542, 340);
            this.m_richTextBox_details.Name = "m_richTextBox_details";
            this.m_richTextBox_details.Size = new System.Drawing.Size(230, 182);
            this.m_richTextBox_details.TabIndex = 0;
            this.m_richTextBox_details.Text = "";
            // 
            // m_picturebox_poster
            // 
            this.m_picturebox_poster.Location = new System.Drawing.Point(542, 56);
            this.m_picturebox_poster.Name = "m_picturebox_poster";
            this.m_picturebox_poster.Size = new System.Drawing.Size(230, 278);
            this.m_picturebox_poster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.m_picturebox_poster.TabIndex = 1;
            this.m_picturebox_poster.TabStop = false;
            // 
            // m_button_newMovie
            // 
            this.m_button_newMovie.Location = new System.Drawing.Point(12, 12);
            this.m_button_newMovie.Name = "m_button_newMovie";
            this.m_button_newMovie.Size = new System.Drawing.Size(338, 25);
            this.m_button_newMovie.TabIndex = 2;
            this.m_button_newMovie.Text = "Add a Movie...";
            this.m_button_newMovie.UseVisualStyleBackColor = true;
            this.m_button_newMovie.Click += new System.EventHandler(this.m_button_newMovie_Click);
            // 
            // m_button_editMovie
            // 
            this.m_button_editMovie.Location = new System.Drawing.Point(542, 528);
            this.m_button_editMovie.Name = "m_button_editMovie";
            this.m_button_editMovie.Size = new System.Drawing.Size(230, 21);
            this.m_button_editMovie.TabIndex = 3;
            this.m_button_editMovie.Text = "Edit Details";
            this.m_button_editMovie.UseVisualStyleBackColor = false;
            this.m_button_editMovie.Click += new System.EventHandler(this.m_button_editMovie_Click);
            // 
            // m_button_logout
            // 
            this.m_button_logout.Location = new System.Drawing.Point(542, 28);
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
            this.m_label_username.Location = new System.Drawing.Point(539, 9);
            this.m_label_username.Name = "m_label_username";
            this.m_label_username.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.m_label_username.Size = new System.Drawing.Size(35, 13);
            this.m_label_username.TabIndex = 5;
            this.m_label_username.Text = "label1";
            this.m_label_username.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // m_textbox_search
            // 
            this.m_textbox_search.Location = new System.Drawing.Point(12, 43);
            this.m_textbox_search.Name = "m_textbox_search";
            this.m_textbox_search.Size = new System.Drawing.Size(100, 20);
            this.m_textbox_search.TabIndex = 6;
            // 
            // m_button_search
            // 
            this.m_button_search.Location = new System.Drawing.Point(118, 43);
            this.m_button_search.Name = "m_button_search";
            this.m_button_search.Size = new System.Drawing.Size(121, 20);
            this.m_button_search.TabIndex = 7;
            this.m_button_search.Text = "Find...";
            this.m_button_search.UseVisualStyleBackColor = true;
            this.m_button_search.Click += new System.EventHandler(this.m_button_search_Click);
            // 
            // m_button_findByGenre
            // 
            this.m_button_findByGenre.Location = new System.Drawing.Point(112, 19);
            this.m_button_findByGenre.Name = "m_button_findByGenre";
            this.m_button_findByGenre.Size = new System.Drawing.Size(100, 47);
            this.m_button_findByGenre.TabIndex = 9;
            this.m_button_findByGenre.Text = "Search";
            this.m_button_findByGenre.UseVisualStyleBackColor = true;
            this.m_button_findByGenre.Click += new System.EventHandler(this.m_button_findByGenre_Click);
            // 
            // m_comboBox_genre2
            // 
            this.m_comboBox_genre2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_comboBox_genre2.FormattingEnabled = true;
            this.m_comboBox_genre2.Location = new System.Drawing.Point(6, 45);
            this.m_comboBox_genre2.Name = "m_comboBox_genre2";
            this.m_comboBox_genre2.Size = new System.Drawing.Size(100, 21);
            this.m_comboBox_genre2.TabIndex = 10;
            // 
            // m_comboBox_genre1
            // 
            this.m_comboBox_genre1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_comboBox_genre1.FormattingEnabled = true;
            this.m_comboBox_genre1.Location = new System.Drawing.Point(6, 19);
            this.m_comboBox_genre1.Name = "m_comboBox_genre1";
            this.m_comboBox_genre1.Size = new System.Drawing.Size(100, 21);
            this.m_comboBox_genre1.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_comboBox_genre1);
            this.groupBox1.Controls.Add(this.m_comboBox_genre2);
            this.groupBox1.Controls.Add(this.m_button_findByGenre);
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 78);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find Movie By Genre";
            // 
            // Form3_MovieList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.m_button_search);
            this.Controls.Add(this.m_textbox_search);
            this.Controls.Add(this.m_label_username);
            this.Controls.Add(this.m_button_logout);
            this.Controls.Add(this.m_button_editMovie);
            this.Controls.Add(this.m_button_newMovie);
            this.Controls.Add(this.m_picturebox_poster);
            this.Controls.Add(this.m_richTextBox_details);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3_MovieList";
            this.Text = "Movies List";
            this.Load += new System.EventHandler(this.Form3_MovieList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_picturebox_poster)).EndInit();
            this.groupBox1.ResumeLayout(false);
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
    }
}