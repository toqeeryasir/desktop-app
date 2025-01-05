namespace Banking_System
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.top_bar = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.sign_in_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.top_bar.SuspendLayout();
            this.SuspendLayout();
            // 
            // top_bar
            // 
            this.top_bar.BackColor = System.Drawing.Color.Black;
            this.top_bar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("top_bar.BackgroundImage")));
            this.top_bar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.top_bar.Controls.Add(this.label2);
            this.top_bar.Controls.Add(this.sign_in_button);
            this.top_bar.Location = new System.Drawing.Point(-1, -1);
            this.top_bar.Margin = new System.Windows.Forms.Padding(4);
            this.top_bar.Name = "top_bar";
            this.top_bar.Size = new System.Drawing.Size(1356, 58);
            this.top_bar.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(633, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = ".PY-Bank";
            // 
            // sign_in_button
            // 
            this.sign_in_button.BackColor = System.Drawing.Color.Transparent;
            this.sign_in_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sign_in_button.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.sign_in_button.FlatAppearance.BorderSize = 0;
            this.sign_in_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sign_in_button.Font = new System.Drawing.Font("Georgia", 14F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.sign_in_button.ForeColor = System.Drawing.Color.Snow;
            this.sign_in_button.Location = new System.Drawing.Point(1220, 11);
            this.sign_in_button.Name = "sign_in_button";
            this.sign_in_button.Size = new System.Drawing.Size(109, 37);
            this.sign_in_button.TabIndex = 2;
            this.sign_in_button.Text = "Sign_in";
            this.sign_in_button.UseVisualStyleBackColor = false;
            this.sign_in_button.Click += new System.EventHandler(this.sign_in_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 22F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(101, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to .PY-Bank: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Italic);
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(104, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(804, 162);
            this.label3.TabIndex = 2;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1346, 677);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.top_bar);
            this.Font = new System.Drawing.Font("Georgia", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.top_bar.ResumeLayout(false);
            this.top_bar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel top_bar;
        private System.Windows.Forms.Button sign_in_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

