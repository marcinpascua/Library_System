namespace Library_System
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.noaccount_label = new System.Windows.Forms.Label();
            this.signup_link = new System.Windows.Forms.LinkLabel();
            this.login_button = new System.Windows.Forms.Button();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.login_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.noaccount_label);
            this.panel1.Controls.Add(this.signup_link);
            this.panel1.Controls.Add(this.login_button);
            this.panel1.Controls.Add(this.password_textbox);
            this.panel1.Controls.Add(this.username_textbox);
            this.panel1.Controls.Add(this.login_label);
            this.panel1.Location = new System.Drawing.Point(-5, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 532);
            this.panel1.TabIndex = 0;
            // 
            // noaccount_label
            // 
            this.noaccount_label.AutoSize = true;
            this.noaccount_label.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noaccount_label.Location = new System.Drawing.Point(158, 480);
            this.noaccount_label.Name = "noaccount_label";
            this.noaccount_label.Size = new System.Drawing.Size(175, 18);
            this.noaccount_label.TabIndex = 5;
            this.noaccount_label.Text = "Don\'t have an account yet?";
            this.noaccount_label.Click += new System.EventHandler(this.noaccount_label_Click);
            // 
            // signup_link
            // 
            this.signup_link.AutoSize = true;
            this.signup_link.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_link.Location = new System.Drawing.Point(351, 480);
            this.signup_link.Name = "signup_link";
            this.signup_link.Size = new System.Drawing.Size(84, 18);
            this.signup_link.TabIndex = 4;
            this.signup_link.TabStop = true;
            this.signup_link.Text = "Sign up now";
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.login_button.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.ForeColor = System.Drawing.Color.White;
            this.login_button.Location = new System.Drawing.Point(178, 319);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(155, 59);
            this.login_button.TabIndex = 3;
            this.login_button.Text = "Log in";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // password_textbox
            // 
            this.password_textbox.Font = new System.Drawing.Font("Candara Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_textbox.Location = new System.Drawing.Point(83, 233);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(352, 40);
            this.password_textbox.TabIndex = 2;
            this.password_textbox.Text = "password";
            this.password_textbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // username_textbox
            // 
            this.username_textbox.Font = new System.Drawing.Font("Candara Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_textbox.Location = new System.Drawing.Point(83, 166);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(352, 40);
            this.username_textbox.TabIndex = 1;
            this.username_textbox.Text = "username";
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.BackColor = System.Drawing.SystemColors.Window;
            this.login_label.Font = new System.Drawing.Font("Candara", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.login_label.Location = new System.Drawing.Point(180, 63);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(151, 53);
            this.login_label.TabIndex = 0;
            this.login_label.Text = "LOG IN";
            this.login_label.Click += new System.EventHandler(this.login_label_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(508, 526);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label noaccount_label;
        private System.Windows.Forms.LinkLabel signup_link;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.Label login_label;
    }
}

