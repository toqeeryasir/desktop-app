namespace Banking_System
{
    partial class Form2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Sign_in_page = new System.Windows.Forms.Label();
            this.account_no_password_taxtbox = new System.Windows.Forms.TextBox();
            this.sign_in_password_taxtbox = new System.Windows.Forms.TextBox();
            this.sign_in_next_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sign_up_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.admin_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Sign_in_page
            // 
            this.Sign_in_page.AutoSize = true;
            this.Sign_in_page.BackColor = System.Drawing.Color.Transparent;
            this.Sign_in_page.Font = new System.Drawing.Font("Georgia", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Sign_in_page.ForeColor = System.Drawing.Color.Snow;
            this.Sign_in_page.Location = new System.Drawing.Point(140, 32);
            this.Sign_in_page.Name = "Sign_in_page";
            this.Sign_in_page.Size = new System.Drawing.Size(101, 27);
            this.Sign_in_page.TabIndex = 0;
            this.Sign_in_page.Text = "Sign_in";
            // 
            // account_no_password_taxtbox
            // 
            this.account_no_password_taxtbox.Location = new System.Drawing.Point(164, 129);
            this.account_no_password_taxtbox.Name = "account_no_password_taxtbox";
            this.account_no_password_taxtbox.Size = new System.Drawing.Size(181, 20);
            this.account_no_password_taxtbox.TabIndex = 1;
            // 
            // sign_in_password_taxtbox
            // 
            this.sign_in_password_taxtbox.Location = new System.Drawing.Point(164, 198);
            this.sign_in_password_taxtbox.Name = "sign_in_password_taxtbox";
            this.sign_in_password_taxtbox.Size = new System.Drawing.Size(181, 20);
            this.sign_in_password_taxtbox.TabIndex = 2;
            // 
            // sign_in_next_button
            // 
            this.sign_in_next_button.BackColor = System.Drawing.Color.Transparent;
            this.sign_in_next_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sign_in_next_button.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.sign_in_next_button.ForeColor = System.Drawing.Color.Snow;
            this.sign_in_next_button.Location = new System.Drawing.Point(41, 248);
            this.sign_in_next_button.Name = "sign_in_next_button";
            this.sign_in_next_button.Size = new System.Drawing.Size(304, 37);
            this.sign_in_next_button.TabIndex = 3;
            this.sign_in_next_button.Text = "Next";
            this.sign_in_next_button.UseVisualStyleBackColor = false;
            this.sign_in_next_button.Click += new System.EventHandler(this.sign_in_next_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(38, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Account N0.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(38, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.Color.FloralWhite;
            this.label3.Location = new System.Drawing.Point(38, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Don\'t have an account !";
            // 
            // sign_up_button
            // 
            this.sign_up_button.BackColor = System.Drawing.Color.Transparent;
            this.sign_up_button.FlatAppearance.BorderSize = 0;
            this.sign_up_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sign_up_button.Font = new System.Drawing.Font("Georgia", 8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.sign_up_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.sign_up_button.Location = new System.Drawing.Point(196, 306);
            this.sign_up_button.Name = "sign_up_button";
            this.sign_up_button.Size = new System.Drawing.Size(87, 27);
            this.sign_up_button.TabIndex = 7;
            this.sign_up_button.Text = "Creat new";
            this.sign_up_button.UseVisualStyleBackColor = false;
            this.sign_up_button.Click += new System.EventHandler(this.sign_up_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Georgia", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ForeColor = System.Drawing.Color.FloralWhite;
            this.label4.Location = new System.Drawing.Point(38, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "!! Looking for something else ?";
            // 
            // admin_button
            // 
            this.admin_button.BackColor = System.Drawing.Color.Transparent;
            this.admin_button.FlatAppearance.BorderSize = 0;
            this.admin_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_button.Font = new System.Drawing.Font("Georgia", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))));
            this.admin_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.admin_button.Location = new System.Drawing.Point(227, 369);
            this.admin_button.Name = "admin_button";
            this.admin_button.Size = new System.Drawing.Size(118, 27);
            this.admin_button.TabIndex = 10;
            this.admin_button.Text = "Administrator";
            this.admin_button.UseVisualStyleBackColor = false;
            this.admin_button.Click += new System.EventHandler(this.admin_button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(375, 434);
            this.Controls.Add(this.admin_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sign_up_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sign_in_next_button);
            this.Controls.Add(this.sign_in_password_taxtbox);
            this.Controls.Add(this.account_no_password_taxtbox);
            this.Controls.Add(this.Sign_in_page);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Sign_in_page;
        private System.Windows.Forms.TextBox account_no_password_taxtbox;
        private System.Windows.Forms.TextBox sign_in_password_taxtbox;
        private System.Windows.Forms.Button sign_in_next_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sign_up_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button admin_button;
    }
}
