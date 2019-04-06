using System;

namespace Interfaces.Polymorphism.Classes
{
    public class MailService
    {
        public void Send(Mail mail)
        {
            Console.WriteLine("Sending email...");
        }
    }
}