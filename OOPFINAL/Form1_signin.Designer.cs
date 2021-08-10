namespace MOVIEFLIX_OOP
{
    partial class Form1_signin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1_signin));
            this.m_textBox_email = new System.Windows.Forms.TextBox();
            this.m_textBox_password = new System.Windows.Forms.TextBox();
            this.m_button_login = new System.Windows.Forms.Button();
            this.m_label_register = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_textBox_email
            // 
            this.m_textBox_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_textBox_email.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.m_textBox_email.Location = new System.Drawing.Point(74, 119);
            this.m_textBox_email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_textBox_email.Multiline = true;
            this.m_textBox_email.Name = "m_textBox_email";
            this.m_textBox_email.Size = new System.Drawing.Size(228, 35);
            this.m_textBox_email.TabIndex = 0;
            this.m_textBox_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m_textBox_email.Click += new System.EventHandler(this.m_textBox_email_Click);
            // 
            // m_textBox_password
            // 
            this.m_textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_textBox_password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.m_textBox_password.Location = new System.Drawing.Point(75, 215);
            this.m_textBox_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_textBox_password.Multiline = true;
            this.m_textBox_password.Name = "m_textBox_password";
            this.m_textBox_password.PasswordChar = '*';
            this.m_textBox_password.Size = new System.Drawing.Size(228, 35);
            this.m_textBox_password.TabIndex = 1;
            this.m_textBox_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m_textBox_password.Click += new System.EventHandler(this.m_textBox_password_Click);
            // 
            // m_button_login
            // 
            this.m_button_login.BackColor = System.Drawing.Color.MistyRose;
            this.m_button_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_button_login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.m_button_login.Location = new System.Drawing.Point(75, 286);
            this.m_button_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_button_login.Name = "m_button_login";
            this.m_button_login.Size = new System.Drawing.Size(229, 34);
            this.m_button_login.TabIndex = 2;
            this.m_button_login.Text = "Log In";
            this.m_button_login.UseVisualStyleBackColor = false;
            this.m_button_login.Click += new System.EventHandler(this.m_button_login_Click);
            // 
            // m_label_register
            // 
            this.m_label_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.m_label_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_label_register.ForeColor = System.Drawing.Color.Black;
            this.m_label_register.Location = new System.Drawing.Point(73, 376);
            this.m_label_register.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_label_register.Name = "m_label_register";
            this.m_label_register.Size = new System.Drawing.Size(240, 51);
            this.m_label_register.TabIndex = 3;
            this.m_label_register.Text = "Dont have an account?\r\nCreate one !\r\n\r\n";
            this.m_label_register.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m_label_register.Click += new System.EventHandler(this.m_label_register_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(69, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.MistyRose;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(70, 183);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // Form1_signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(437, 550);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_label_register);
            this.Controls.Add(this.m_button_login);
            this.Controls.Add(this.m_textBox_password);
            this.Controls.Add(this.m_textBox_email);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1_signin";
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox m_textBox_email;
        private System.Windows.Forms.TextBox m_textBox_password;
        private System.Windows.Forms.Button m_button_login;
        private System.Windows.Forms.Label m_label_register;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

