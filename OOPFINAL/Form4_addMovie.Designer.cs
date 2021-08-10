namespace MOVIEFLIX_OOP
{
    partial class Form4_addMovie
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
            this.m_textBox_name = new System.Windows.Forms.TextBox();
            this.m_textBox_director = new System.Windows.Forms.TextBox();
            this.m_textBox_actorMain = new System.Windows.Forms.TextBox();
            this.m_textBox_actorSecondary = new System.Windows.Forms.TextBox();
            this.m_richTextBox_summary = new System.Windows.Forms.RichTextBox();
            this.m_button_browse = new System.Windows.Forms.Button();
            this.m_textBox_filepath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.m_button_addMovie = new System.Windows.Forms.Button();
            this.m_button_cancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // m_textBox_name
            // 
            this.m_textBox_name.Location = new System.Drawing.Point(156, 15);
            this.m_textBox_name.Margin = new System.Windows.Forms.Padding(4);
            this.m_textBox_name.Name = "m_textBox_name";
            this.m_textBox_name.Size = new System.Drawing.Size(323, 22);
            this.m_textBox_name.TabIndex = 0;
            // 
            // m_textBox_director
            // 
            this.m_textBox_director.Location = new System.Drawing.Point(156, 47);
            this.m_textBox_director.Margin = new System.Windows.Forms.Padding(4);
            this.m_textBox_director.Name = "m_textBox_director";
            this.m_textBox_director.Size = new System.Drawing.Size(323, 22);
            this.m_textBox_director.TabIndex = 1;
            // 
            // m_textBox_actorMain
            // 
            this.m_textBox_actorMain.Location = new System.Drawing.Point(156, 79);
            this.m_textBox_actorMain.Margin = new System.Windows.Forms.Padding(4);
            this.m_textBox_actorMain.Name = "m_textBox_actorMain";
            this.m_textBox_actorMain.Size = new System.Drawing.Size(323, 22);
            this.m_textBox_actorMain.TabIndex = 2;
            // 
            // m_textBox_actorSecondary
            // 
            this.m_textBox_actorSecondary.Location = new System.Drawing.Point(156, 111);
            this.m_textBox_actorSecondary.Margin = new System.Windows.Forms.Padding(4);
            this.m_textBox_actorSecondary.Name = "m_textBox_actorSecondary";
            this.m_textBox_actorSecondary.Size = new System.Drawing.Size(323, 22);
            this.m_textBox_actorSecondary.TabIndex = 3;
            // 
            // m_richTextBox_summary
            // 
            this.m_richTextBox_summary.Location = new System.Drawing.Point(156, 266);
            this.m_richTextBox_summary.Margin = new System.Windows.Forms.Padding(4);
            this.m_richTextBox_summary.Name = "m_richTextBox_summary";
            this.m_richTextBox_summary.Size = new System.Drawing.Size(323, 219);
            this.m_richTextBox_summary.TabIndex = 4;
            this.m_richTextBox_summary.Text = "";
            // 
            // m_button_browse
            // 
            this.m_button_browse.Location = new System.Drawing.Point(156, 495);
            this.m_button_browse.Margin = new System.Windows.Forms.Padding(4);
            this.m_button_browse.Name = "m_button_browse";
            this.m_button_browse.Size = new System.Drawing.Size(89, 25);
            this.m_button_browse.TabIndex = 5;
            this.m_button_browse.Text = "Browse...";
            this.m_button_browse.UseVisualStyleBackColor = true;
            this.m_button_browse.Click += new System.EventHandler(this.m_button_browse_Click);
            // 
            // m_textBox_filepath
            // 
            this.m_textBox_filepath.Location = new System.Drawing.Point(254, 495);
            this.m_textBox_filepath.Margin = new System.Windows.Forms.Padding(4);
            this.m_textBox_filepath.Name = "m_textBox_filepath";
            this.m_textBox_filepath.ReadOnly = true;
            this.m_textBox_filepath.Size = new System.Drawing.Size(225, 22);
            this.m_textBox_filepath.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Director";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Starring";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Featuring";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 266);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Summary";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 495);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Poster";
            // 
            // m_button_addMovie
            // 
            this.m_button_addMovie.Location = new System.Drawing.Point(155, 526);
            this.m_button_addMovie.Margin = new System.Windows.Forms.Padding(4);
            this.m_button_addMovie.Name = "m_button_addMovie";
            this.m_button_addMovie.Size = new System.Drawing.Size(153, 28);
            this.m_button_addMovie.TabIndex = 13;
            this.m_button_addMovie.Text = "Add";
            this.m_button_addMovie.UseVisualStyleBackColor = true;
            this.m_button_addMovie.Click += new System.EventHandler(this.m_button_addMovie_Click);
            // 
            // m_button_cancel
            // 
            this.m_button_cancel.Location = new System.Drawing.Point(330, 526);
            this.m_button_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.m_button_cancel.Name = "m_button_cancel";
            this.m_button_cancel.Size = new System.Drawing.Size(149, 28);
            this.m_button_cancel.TabIndex = 14;
            this.m_button_cancel.Text = "Cancel";
            this.m_button_cancel.UseVisualStyleBackColor = true;
            this.m_button_cancel.Click += new System.EventHandler(this.m_button_cancel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Genre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 170);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(323, 22);
            this.textBox1.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Genre Secondary";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(156, 226);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(323, 22);
            this.textBox2.TabIndex = 19;
            // 
            // Form4_addMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 579);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.m_button_cancel);
            this.Controls.Add(this.m_button_addMovie);
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
            this.Location = new System.Drawing.Point(400, 400);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form4_addMovie";
            this.Text = "Form4_addMovie";
            this.Load += new System.EventHandler(this.Form4_addMovie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox m_textBox_name;
        private System.Windows.Forms.TextBox m_textBox_director;
        private System.Windows.Forms.TextBox m_textBox_actorMain;
        private System.Windows.Forms.TextBox m_textBox_actorSecondary;
        private System.Windows.Forms.RichTextBox m_richTextBox_summary;
        private System.Windows.Forms.Button m_button_browse;
        private System.Windows.Forms.TextBox m_textBox_filepath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button m_button_addMovie;
        private System.Windows.Forms.Button m_button_cancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
    }
}