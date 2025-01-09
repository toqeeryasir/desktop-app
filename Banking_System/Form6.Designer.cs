namespace Banking_System
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.withdraw_textbox = new System.Windows.Forms.TextBox();
            this.withdraw_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(133, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Withdraw";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(36, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Withdraw Amount";
            // 
            // withdraw_textbox
            // 
            this.withdraw_textbox.Location = new System.Drawing.Point(188, 129);
            this.withdraw_textbox.Name = "withdraw_textbox";
            this.withdraw_textbox.Size = new System.Drawing.Size(163, 20);
            this.withdraw_textbox.TabIndex = 2;
            // 
            // withdraw_button
            // 
            this.withdraw_button.BackColor = System.Drawing.Color.Transparent;
            this.withdraw_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.withdraw_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.withdraw_button.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.withdraw_button.ForeColor = System.Drawing.Color.Snow;
            this.withdraw_button.Location = new System.Drawing.Point(55, 196);
            this.withdraw_button.Name = "withdraw_button";
            this.withdraw_button.Size = new System.Drawing.Size(281, 41);
            this.withdraw_button.TabIndex = 3;
            this.withdraw_button.Text = "Withdraw";
            this.withdraw_button.UseVisualStyleBackColor = false;
            this.withdraw_button.Click += new System.EventHandler(this.withdraw_button_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(391, 290);
            this.Controls.Add(this.withdraw_button);
            this.Controls.Add(this.withdraw_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox withdraw_textbox;
        private System.Windows.Forms.Button withdraw_button;
    }
}