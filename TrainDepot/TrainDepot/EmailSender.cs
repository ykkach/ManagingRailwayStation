using System;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Text.RegularExpressions;

namespace TrainDepot
{
    public partial class EmailSender : Form
    {
        // Send email with some questions/ 
        // feedback to developer

        string fromPassword = $"Lelfhbr2002!";
        public EmailSender()
        {
            InitializeComponent();
        }

        // Send email to developer via Gmail
        private void send_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(login.Text) || String.IsNullOrEmpty(text.Text))
            {
                MessageBox.Show( "Please, enter sender name first.", "No login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (!Regex.IsMatch(login.Text, @"^[a-zA-Z]+$"))
                    throw new Exception("Invalid name entered. Please, try again.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential("kachmaryar@gmail.com", fromPassword) //Email that sends message. 
            };
            if (smtp.Credentials == null)
            {
                MessageBox.Show("Incorrect login or password.", "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            try
            {
                MailAddress from = new MailAddress("kachmaryar@gmail.com", login.Text);
                MailAddress to = new MailAddress("yaroslav.kachmar.pz.2019@lpnu.ua"); //Email that receive message.
                MailMessage m = new MailMessage(from, to);
                m.Subject = "TrainDepot questions";
                m.Body = text.Text;
                smtp.Send(m);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("Your email was sent", "Sent",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            this.Close();
        }

        private void EmailSender_Load(object sender, EventArgs e)
        {}
    }
}
