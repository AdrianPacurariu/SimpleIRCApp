using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatterinoApp
{
    internal class TrimitereEmail
    {
        /* Se trimite mail-ul prin intermediul librariei MailMessage si SMTPClient. */
        /* De pe aceasta adresa de mail se vor trimite mail-urile. */

        private static readonly String adresa = "<adresa de pe care se vor trimite mail-urile>";
        private static readonly string parola_email = "<parola de la mail>";

        public static void trimitereFeedback(String de_la, String nume, String mesaj_primit)
        {
            try
            {
                MailMessage mesaj = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential(adresa, parola_email);
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

                mesaj.From = new MailAddress(de_la, "Chatterino! App - Formular");
                mesaj.To.Add(new MailAddress(adresa));
                mesaj.Subject = "Chatterino! - Feedback/Intrebare din partea lui " + nume + ".";
                mesaj.Body = "Nume: " + nume + Environment.NewLine +
                    "Email: " + de_la + Environment.NewLine +
                    "Mesaj: " + mesaj_primit;

                smtp.Send(mesaj);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nu se poate trimite mailul.", "Chatterino! - Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void creareCont(String pentru, String username)
        {
            try
            {
                MailMessage mesaj = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential(adresa, parola_email);
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

                mesaj.From = new MailAddress(adresa, "Chatterino! App");
                mesaj.To.Add(new MailAddress(pentru));
                mesaj.Subject = "Chatterino - Cont creat cu succes";
                mesaj.Body = "Contul dvs. a fost creat cu succes." + Environment.NewLine + "" +
                    "Username: " + username + Environment.NewLine + "Email: " + pentru +
                    Environment.NewLine + Environment.NewLine + "Chatterino!";

                smtp.Send(mesaj);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nu se poate trimite mailul.", "Chatterino! - Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }

        public static void trimitereParola(String pentru, String username, string parola)
        {
            try
            {
                MailMessage mesaj = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential(adresa, parola_email);
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

                mesaj.From = new MailAddress(adresa, "Chatterino! App");
                mesaj.To.Add(new MailAddress(pentru));
                mesaj.Subject = "Chatterino! - Parola recuperata";
                mesaj.Body = "Ati solicitat recuperarea parolei." + Environment.NewLine + "" +
                    "Username: " + username + Environment.NewLine + "Parola: " + parola +
                    Environment.NewLine + Environment.NewLine + "Chatterino!";

                smtp.Send(mesaj);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nu se poate trimite mailul.", "Chatterino! - Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}