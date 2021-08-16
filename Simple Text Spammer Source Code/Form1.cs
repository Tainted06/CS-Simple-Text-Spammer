using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Threading;

namespace Simple_Text_Spammer_Source_Code
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd", "/C start" + " " + "https://github.com/Tainted06/CS-Simple-Text-Spammer");
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string message = textBox1.Text; // Setting the message variable
                int time = Int32.Parse(textBox2.Text); // Setting the wait time variable
                int times = Int32.Parse(textBox3.Text); // Setting the amount of times variable
                for (int i = 0; i < times; i++) // Text Spamming Loop
                {
                    SendKeys.Send(i); // Sending the Message
                    SendKeys.Send("{Enter}"); // Sending the key Enter
                    Thread.Sleep(time); // Waiting for the given amount of time
                }
                MessageBox.Show("Done!"); // Message box saying the spammer is finished
            }
            catch
            {
                MessageBox.Show("Error! Make sure you typed only numbers for the last two text boxes!"); // Error incase they typed a letter for the wait time or the amount of times
            }
        }
    }
}
