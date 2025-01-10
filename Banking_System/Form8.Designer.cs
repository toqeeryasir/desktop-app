namespace Banking_System
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.admin_password_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.admin_next_button = new System.Windows.Forms.Button();
            this.change_admin_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(144, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(52, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // admin_password_textbox
            // 
            this.admin_password_textbox.Location = new System.Drawing.Point(149, 120);
            this.admin_password_textbox.Name = "admin_password_textbox";
            this.admin_password_textbox.Size = new System.Drawing.Size(167, 20);
            this.admin_password_textbox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Italic);
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(52, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Change Admin !...";
            // 
            // admin_next_button
            // 
            this.admin_next_button.BackColor = System.Drawing.Color.Transparent;
            this.admin_next_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.admin_next_button.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.admin_next_button.ForeColor = System.Drawing.Color.Snow;
            this.admin_next_button.Location = new System.Drawing.Point(44, 176);
            this.admin_next_button.Name = "admin_next_button";
            this.admin_next_button.Size = new System.Drawing.Size(281, 41);
            this.admin_next_button.TabIndex = 4;
            this.admin_next_button.Text = "Next";
            this.admin_next_button.UseVisualStyleBackColor = false;
            this.admin_next_button.Click += new System.EventHandler(this.admin_next_button_Click);
            // 
            // change_admin_button
            // 
            this.change_admin_button.BackColor = System.Drawing.Color.Transparent;
            this.change_admin_button.FlatAppearance.BorderSize = 0;
            this.change_admin_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.change_admin_button.Font = new System.Drawing.Font("Georgia", 8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.change_admin_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.change_admin_button.Location = new System.Drawing.Point(164, 243);
            this.change_admin_button.Name = "change_admin_button";
            this.change_admin_button.Size = new System.Drawing.Size(81, 30);
            this.change_admin_button.TabIndex = 5;
            this.change_admin_button.Text = "Request";
            this.change_admin_button.UseVisualStyleBackColor = false;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(362, 329);
            this.Controls.Add(this.change_admin_button);
            this.Controls.Add(this.admin_next_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.admin_password_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form8";
            this.Text = "Form8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox admin_password_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button admin_next_button;
        private System.Windows.Forms.Button change_admin_button;
    }
}