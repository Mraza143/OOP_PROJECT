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
            this.m_textbox_email = new System.Windows.Forms.TextBox();
            this.m_textbox_password = new System.Windows.Forms.TextBox();
            this.m_textbox_verification = new System.Windows.Forms.TextBox();
            this.m_button_register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_textbox_email
            // 
            this.m_textbox_email.Location = new System.Drawing.Point(59, 108);
            this.m_textbox_email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_textbox_email.Name = "m_textbox_email";
            this.m_textbox_email.Size = new System.Drawing.Size(267, 22);
            this.m_textbox_email.TabIndex = 0;
            this.m_textbox_email.Text = "E-Mail";
            this.m_textbox_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // m_textbox_password
            // 
            this.m_textbox_password.Location = new System.Drawing.Point(59, 140);
            this.m_textbox_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_textbox_password.Name = "m_textbox_password";
            this.m_textbox_password.PasswordChar = '*';
            this.m_textbox_password.Size = new System.Drawing.Size(267, 22);
            this.m_textbox_password.TabIndex = 1;
            this.m_textbox_password.Text = "Password";
            this.m_textbox_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // m_textbox_verification
            // 
            this.m_textbox_verification.Location = new System.Drawing.Point(59, 172);
            this.m_textbox_verification.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_textbox_verification.Name = "m_textbox_verification";
            this.m_textbox_verification.PasswordChar = '*';
            this.m_textbox_verification.Size = new System.Drawing.Size(267, 22);
            this.m_textbox_verification.TabIndex = 2;
            this.m_textbox_verification.Text = "Password confirmation";
            this.m_textbox_verification.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // m_button_register
            // 
            this.m_button_register.Location = new System.Drawing.Point(59, 204);
            this.m_button_register.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_button_register.Name = "m_button_register";
            this.m_button_register.Size = new System.Drawing.Size(268, 25);
            this.m_button_register.TabIndex = 3;
            this.m_button_register.Text = "Register";
            this.m_button_register.UseVisualStyleBackColor = true;
            this.m_button_register.Click += new System.EventHandler(this.m_button_register_Click);
            // 
            // Form2_registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.m_button_register);
            this.Controls.Add(this.m_textbox_verification);
            this.Controls.Add(this.m_textbox_password);
            this.Controls.Add(this.m_textbox_email);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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

    }
}