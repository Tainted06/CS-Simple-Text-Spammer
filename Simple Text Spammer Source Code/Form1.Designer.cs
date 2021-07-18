
namespace Simple_Text_Spammer_Source_Code
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // metroLink1
            // 
            this.metroLink1.Location = new System.Drawing.Point(23, 63);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(411, 23);
            this.metroLink1.TabIndex = 1;
            this.metroLink1.Text = "https://github.com/Tainted06/C-Simple-Text-Spammer";
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(410, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Message to spam";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(24, 123);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(410, 23);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Wait time between messages (In milliseconds)";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(24, 181);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(410, 23);
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "Start";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(23, 152);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(410, 23);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "Amount of times to send the message";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 227);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.metroLink1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Text = "C# Simple Text Spammer | By Tainted06";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLink metroLink1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.TextBox textBox3;
    }
}

