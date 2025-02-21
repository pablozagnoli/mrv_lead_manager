using Domain.Interfaces.Leads;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class MailService : IMailService
    {
        public void SendMail()
        {
            string smtpServer = "smtp.seuprovedor.com";
            int smtpPort = 587; // Porta SMTP (587 para TLS, 465 para SSL)
            string senderEmail = "vendas@teste.com";
            string senderPassword = "suaSenha";
            string recipientEmail = "destinatario@exemplo.com";
            string subject = "Teste de e-mail";
            string body = "Este é um e-mail de teste enviado pelo C#!";

            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(senderEmail);
                mail.To.Add(recipientEmail);
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = false;

                SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort);
                smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);
                smtpClient.EnableSsl = true; // Defina como false se não usar SSL/TLS

                smtpClient.Send(mail);
                Console.WriteLine("E-mail enviado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao enviar e-mail: {ex.Message}");
            }
        }
    }
}
