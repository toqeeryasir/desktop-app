namespace Banking_System
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            this.label1 = new System.Windows.Forms.Label();
            this.add_balalnce_button = new System.Windows.Forms.Button();
            this.withdraw_button = new System.Windows.Forms.Button();
            this.Check_balance_button = new System.Windows.Forms.Button();
            this.edit_account_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(164, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nevigate to required section";
            // 
            // add_balalnce_button
            // 
            this.add_balalnce_button.BackColor = System.Drawing.Color.Transparent;
            this.add_balalnce_button.FlatAppearance.BorderSize = 0;
            this.add_balalnce_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_balalnce_button.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.add_balalnce_button.ForeColor = System.Drawing.Color.Snow;
            this.add_balalnce_button.Location = new System.Drawing.Point(211, 101);
            this.add_balalnce_button.Name = "add_balalnce_button";
            this.add_balalnce_button.Size = new System.Drawing.Size(226, 53);
            this.add_balalnce_button.TabIndex = 1;
            this.add_balalnce_button.Text = "Add Balance";
            this.add_balalnce_button.UseVisualStyleBackColor = false;
            this.add_balalnce_button.Click += new System.EventHandler(this.add_balalnce_button_Click);
            // 
            // withdraw_button
            // 
            this.withdraw_button.BackColor = System.Drawing.Color.Transparent;
            this.withdraw_button.FlatAppearance.BorderSize = 0;
            this.withdraw_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.withdraw_button.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.withdraw_button.ForeColor = System.Drawing.Color.Snow;
            this.withdraw_button.Location = new System.Drawing.Point(211, 171);
            this.withdraw_button.Name = "withdraw_button";
            this.withdraw_button.Size = new System.Drawing.Size(226, 53);
            this.withdraw_button.TabIndex = 2;
            this.withdraw_button.Text = "Withdraw";
            this.withdraw_button.UseVisualStyleBackColor = false;
            this.withdraw_button.Click += new System.EventHandler(this.withdraw_button_Click);
            // 
            // Check_balance_button
            // 
            this.Check_balance_button.BackColor = System.Drawing.Color.Transparent;
            this.Check_balance_button.FlatAppearance.BorderSize = 0;
            this.Check_balance_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Check_balance_button.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.Check_balance_button.ForeColor = System.Drawing.Color.Snow;
            this.Check_balance_button.Location = new System.Drawing.Point(211, 241);
            this.Check_balance_button.Name = "Check_balance_button";
            this.Check_balance_button.Size = new System.Drawing.Size(226, 53);
            this.Check_balance_button.TabIndex = 3;
            this.Check_balance_button.Text = "Check Balance";
            this.Check_balance_button.UseVisualStyleBackColor = false;
            this.Check_balance_button.Click += new System.EventHandler(this.Check_balance_button_Click);
            // 
            // edit_account_button
            // 
            this.edit_account_button.BackColor = System.Drawing.Color.Transparent;
            this.edit_account_button.FlatAppearance.BorderSize = 0;
            this.edit_account_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.edit_account_button.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.edit_account_button.ForeColor = System.Drawing.Color.Snow;
            this.edit_account_button.Location = new System.Drawing.Point(211, 309);
            this.edit_account_button.Name = "edit_account_button";
            this.edit_account_button.Size = new System.Drawing.Size(226, 53);
            this.edit_account_button.TabIndex = 4;
            this.edit_account_button.Text = "Edit Account Info.";
            this.edit_account_button.UseVisualStyleBackColor = false;
            this.edit_account_button.Click += new System.EventHandler(this.edit_account_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(199, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "!! Plese follow all the terms and conditions carefully, \r\n   so you can easily ke" +
    "ep track of our account\r\n                               Thanks!";
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(624, 438);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edit_account_button);
            this.Controls.Add(this.Check_balance_button);
            this.Controls.Add(this.withdraw_button);
            this.Controls.Add(this.add_balalnce_button);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form10";
            this.Text = "Form10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add_balalnce_button;
        private System.Windows.Forms.Button withdraw_button;
        private System.Windows.Forms.Button Check_balance_button;
        private System.Windows.Forms.Button edit_account_button;
        private System.Windows.Forms.Label label2;
    }
}