using Sloj_pristupa_podacima;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sloj_poslovne_logike
{
    public class Mailer
    {
        public static void PosaljiMail(Korisnik korisnik, string putanja,string naslov)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(Sesija.PrijavljenKorisnik.email, Konfiguracija.DajPostavku("mail.naslov"), Encoding.UTF8);
            mail.To.Add(new MailAddress(korisnik.email, korisnik.ime_korisnika+" "+korisnik.prezime_korisnika, Encoding.UTF8));
            mail.Attachments.Add(new Attachment(putanja));
            mail.Subject = naslov;
            mail.SubjectEncoding = Encoding.UTF8;
            mail.IsBodyHtml = true;
            mail.Body = "Dokument u privitku.";
            mail.BodyEncoding = Encoding.UTF8;
            SmtpClient client = new SmtpClient();
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential(Konfiguracija.DajPostavku("korisnik.email"), Konfiguracija.DajPostavku("korisnik.lozinka"));
            client.Host = Konfiguracija.DajPostavku("mail.smtp");
            client.Port = int.Parse(Konfiguracija.DajPostavku("mail.port"));
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Send(mail);
        }
    }
}
