// See https://aka.ms/new-console-template for more information
using MailKit;
using MailKit.Net.Smtp;
using MimeKit;
using SMTP;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

string password = "zOyPdlnrnL0upltS";

//Console.WriteLine("Приві, Козаки, Сігми, і хороші люди :) ");

Message msg = new Message
{
    Subject = "Здоров Козак",
    Body = "CСигма Сигма бой, Ешкере ",
    To = "evelin.savchuk@gmail.com"
};

string pathFile = @"C:\Users\STUDENT\Desktop\images\images.jpg";

var attachment = new MimePart("image", "jpg")
{
    FileName = "Аткрить СРОЧНAA",
    Content = new MimeContent(File.OpenRead(pathFile))

};

var body = new TextPart("plain")
           {
               Text = msg.Body 
           };

var multipart = new Multipart("mixed");
multipart.Add(body);
multipart.Add(attachment);

var em = new MimeMessage();
em.From.Add(new MailboxAddress(MailConf.From)); // від кого надсилаємо листа 
em.To.Add(new MailboxAddress(msg.To)); // Комі надсилаємо повідомлення 
em.Subject = msg.Subject; //  Тема листа 
// Тіло повідомлення
em.Body = multipart;

// Налаштування сервера 
using var client = new SmtpClient();
try
{
    client.Connect(MailConf.SmtpServer, MailConf.SmtpPort, true);
    client.Authenticate(MailConf.UserName, MailConf.Password);
    client.Send(em);
    client.Disconnect(true);
    Console.WriteLine("Лист успішно відправлено!");
}      
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}






 