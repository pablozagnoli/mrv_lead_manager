using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Domain.Interfaces.Leads.Services;

namespace Domain.Services
{
    public class MailService : IMailService
    {
        public void SendMailLeadAccept()
        {
            string smtpServer = "smtp.seuprovedor.com";
            int smtpPort = 587;
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
                smtpClient.EnableSsl = true;

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
