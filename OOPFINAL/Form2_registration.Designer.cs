namespace MOVIEFLIX_OOP
{
    partial class Form2_registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2_registration));
            this.m_textbox_email = new System.Windows.Forms.TextBox();
            this.m_textbox_password = new System.Windows.Forms.TextBox();
            this.m_textbox_verification = new System.Windows.Forms.TextBox();
            this.m_button_register = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_textbox_email
            // 
            this.m_textbox_email.Location = new System.Drawing.Point(59, 138);
            this.m_textbox_email.Margin = new System.Windows.Forms.Padding(4);
            this.m_textbox_email.Multiline = true;
            this.m_textbox_email.Name = "m_textbox_email";
            this.m_textbox_email.Size = new System.Drawing.Size(267, 28);
            this.m_textbox_email.TabIndex = 0;
            this.m_textbox_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // m_textbox_password
            // 
            this.m_textbox_password.Location = new System.Drawing.Point(59, 231);
            this.m_textbox_password.Margin = new System.Windows.Forms.Padding(4);
            this.m_textbox_password.Multiline = true;
            this.m_textbox_password.Name = "m_textbox_password";
            this.m_textbox_password.PasswordChar = '*';
            this.m_textbox_password.Size = new System.Drawing.Size(267, 31);
            this.m_textbox_password.TabIndex = 1;
            this.m_textbox_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // m_textbox_verification
            // 
            this.m_textbox_verification.Location = new System.Drawing.Point(60, 317);
            this.m_textbox_verification.Margin = new System.Windows.Forms.Padding(4);
            this.m_textbox_verification.Multiline = true;
            this.m_textbox_verification.Name = "m_textbox_verification";
            this.m_textbox_verification.PasswordChar = '*';
            this.m_textbox_verification.Size = new System.Drawing.Size(267, 34);
            this.m_textbox_verification.TabIndex = 2;
            this.m_textbox_verification.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // m_button_register
            // 
            this.m_button_register.BackColor = System.Drawing.Color.MistyRose;
            this.m_button_register.Location = new System.Drawing.Point(246, 397);
            this.m_button_register.Margin = new System.Windows.Forms.Padding(4);
            this.m_button_register.Name = "m_button_register";
            this.m_button_register.Padding = new System.Windows.Forms.Padding(4);
            this.m_button_register.Size = new System.Drawing.Size(80, 37);
            this.m_button_register.TabIndex = 3;
            this.m_button_register.Text = "Register";
            this.m_button_register.UseVisualStyleBackColor = false;
            this.m_button_register.Click += new System.EventHandler(this.m_button_register_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.Location = new System.Drawing.Point(61, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(2);
            this.label1.Size = new System.Drawing.Size(46, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MistyRose;
            this.label2.Location = new System.Drawing.Point(57, 210);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(2);
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MistyRose;
            this.label3.Location = new System.Drawing.Point(57, 296);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(2);
            this.label3.Size = new System.Drawing.Size(125, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Confirm Password";
            // 
            // Form2_registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(421, 511);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_button_register);
            this.Controls.Add(this.m_textbox_verification);
            this.Controls.Add(this.m_textbox_password);
            this.Controls.Add(this.m_textbox_email);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2_registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Form2_registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox m_textbox_email;
        private System.Windows.Forms.TextBox m_textbox_password;
        private System.Windows.Forms.TextBox m_textbox_verification;
        private System.Windows.Forms.Button m_button_register;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}