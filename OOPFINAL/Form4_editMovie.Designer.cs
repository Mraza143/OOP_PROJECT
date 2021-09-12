namespace MOVIEFLIX_OOP
{
    partial class Form5_editMovie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5_editMovie));
            this.m_button_editConfirm = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.m_textBox_filepath = new System.Windows.Forms.TextBox();
            this.m_button_browse = new System.Windows.Forms.Button();
            this.m_richTextBox_summary = new System.Windows.Forms.RichTextBox();
            this.m_textBox_actorSecondary = new System.Windows.Forms.TextBox();
            this.m_textBox_actorMain = new System.Windows.Forms.TextBox();
            this.m_textBox_director = new System.Windows.Forms.TextBox();
            this.m_textBox_name = new System.Windows.Forms.TextBox();
            this.m_picturebox_poster = new System.Windows.Forms.PictureBox();
            this.m_button_cancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.m_comboBox_genre1 = new System.Windows.Forms.ComboBox();
            this.m_comboBox_genre2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.m_picturebox_poster)).BeginInit();
            this.SuspendLayout();
            // 
            // m_button_editConfirm
            // 
            this.m_button_editConfirm.Location = new System.Drawing.Point(86, 462);
            this.m_button_editConfirm.Name = "m_button_editConfirm";
            this.m_button_editConfirm.Size = new System.Drawing.Size(115, 23);
            this.m_button_editConfirm.TabIndex = 27;
            this.m_button_editConfirm.Text = "Add";
            this.m_button_editConfirm.UseVisualStyleBackColor = true;
            this.m_button_editConfirm.Click += new System.EventHandler(this.m_button_editConfirm_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(4, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Poster";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(4, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Summary";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(4, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Featuring";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Starring";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Director";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Name";
            // 
            // m_textBox_filepath
            // 
            this.m_textBox_filepath.Location = new System.Drawing.Point(159, 302);
            this.m_textBox_filepath.Name = "m_textBox_filepath";
            this.m_textBox_filepath.ReadOnly = true;
            this.m_textBox_filepath.Size = new System.Drawing.Size(170, 20);
            this.m_textBox_filepath.TabIndex = 20;
            // 
            // m_button_browse
            // 
            this.m_button_browse.Location = new System.Drawing.Point(86, 302);
            this.m_button_browse.Name = "m_button_browse";
            this.m_button_browse.Size = new System.Drawing.Size(67, 20);
            this.m_button_browse.TabIndex = 19;
            this.m_button_browse.Text = "Browse...";
            this.m_button_browse.UseVisualStyleBackColor = true;
            this.m_button_browse.Click += new System.EventHandler(this.m_button_browse_Click);
            // 
            // m_richTextBox_summary
            // 
            this.m_richTextBox_summary.Location = new System.Drawing.Point(86, 116);
            this.m_richTextBox_summary.Name = "m_richTextBox_summary";
            this.m_richTextBox_summary.Size = new System.Drawing.Size(243, 124);
            this.m_richTextBox_summary.TabIndex = 18;
            this.m_richTextBox_summary.Text = "";
            // 
            // m_textBox_actorSecondary
            // 
            this.m_textBox_actorSecondary.Location = new System.Drawing.Point(86, 90);
            this.m_textBox_actorSecondary.Name = "m_textBox_actorSecondary";
            this.m_textBox_actorSecondary.Size = new System.Drawing.Size(243, 20);
            this.m_textBox_actorSecondary.TabIndex = 17;
            // 
            // m_textBox_actorMain
            // 
            this.m_textBox_actorMain.Location = new System.Drawing.Point(86, 64);
            this.m_textBox_actorMain.Name = "m_textBox_actorMain";
            this.m_textBox_actorMain.Size = new System.Drawing.Size(243, 20);
            this.m_textBox_actorMain.TabIndex = 16;
            // 
            // m_textBox_director
            // 
            this.m_textBox_director.Location = new System.Drawing.Point(86, 38);
            this.m_textBox_director.Name = "m_textBox_director";
            this.m_textBox_director.Size = new System.Drawing.Size(243, 20);
            this.m_textBox_director.TabIndex = 15;
            // 
            // m_textBox_name
            // 
            this.m_textBox_name.Location = new System.Drawing.Point(86, 12);
            this.m_textBox_name.Name = "m_textBox_name";
            this.m_textBox_name.Size = new System.Drawing.Size(243, 20);
            this.m_textBox_name.TabIndex = 14;
            // 
            // m_picturebox_poster
            // 
            this.m_picturebox_poster.Location = new System.Drawing.Point(86, 328);
            this.m_picturebox_poster.Name = "m_picturebox_poster";
            this.m_picturebox_poster.Size = new System.Drawing.Size(243, 128);
            this.m_picturebox_poster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.m_picturebox_poster.TabIndex = 28;
            this.m_picturebox_poster.TabStop = false;
            // 
            // m_button_cancel
            // 
            this.m_button_cancel.Location = new System.Drawing.Point(216, 462);
            this.m_button_cancel.Name = "m_button_cancel";
            this.m_button_cancel.Size = new System.Drawing.Size(113, 23);
            this.m_button_cancel.TabIndex = 29;
            this.m_button_cancel.Text = "Cancel";
            this.m_button_cancel.UseVisualStyleBackColor = true;
            this.m_button_cancel.Click += new System.EventHandler(this.m_button_cancel_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(4, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Current";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(4, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "Genre";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(4, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 32;
            this.label9.Text = "Subgenre";
            // 
            // m_comboBox_genre1
            // 
            this.m_comboBox_genre1.FormattingEnabled = true;
            this.m_comboBox_genre1.Location = new System.Drawing.Point(86, 246);
            this.m_comboBox_genre1.Name = "m_comboBox_genre1";
            this.m_comboBox_genre1.Size = new System.Drawing.Size(243, 21);
            this.m_comboBox_genre1.TabIndex = 33;
            // 
            // m_comboBox_genre2
            // 
            this.m_comboBox_genre2.FormattingEnabled = true;
            this.m_comboBox_genre2.Location = new System.Drawing.Point(86, 275);
            this.m_comboBox_genre2.Name = "m_comboBox_genre2";
            this.m_comboBox_genre2.Size = new System.Drawing.Size(243, 21);
            this.m_comboBox_genre2.TabIndex = 34;
            // 
            // Form5_editMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(357, 497);
            this.Controls.Add(this.m_comboBox_genre2);
            this.Controls.Add(this.m_comboBox_genre1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.m_button_cancel);
            this.Controls.Add(this.m_picturebox_poster);
            this.Controls.Add(this.m_button_editConfirm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_textBox_filepath);
            this.Controls.Add(this.m_button_browse);
            this.Controls.Add(this.m_richTextBox_summary);
            this.Controls.Add(this.m_textBox_actorSecondary);
            this.Controls.Add(this.m_textBox_actorMain);
            this.Controls.Add(this.m_textBox_director);
            this.Controls.Add(this.m_textBox_name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(400, 400);
            this.Name = "Form5_editMovie";
            this.Text = "Edit Movie";
            this.Load += new System.EventHandler(this.Form5_editMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_picturebox_poster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_button_editConfirm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_textBox_filepath;
        private System.Windows.Forms.Button m_button_browse;
        private System.Windows.Forms.RichTextBox m_richTextBox_summary;
        private System.Windows.Forms.TextBox m_textBox_actorSecondary;
        private System.Windows.Forms.TextBox m_textBox_actorMain;
        private System.Windows.Forms.TextBox m_textBox_director;
        private System.Windows.Forms.TextBox m_textBox_name;
        private System.Windows.Forms.PictureBox m_picturebox_poster;
        private System.Windows.Forms.Button m_button_cancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox m_comboBox_genre1;
        private System.Windows.Forms.ComboBox m_comboBox_genre2;
    }
}