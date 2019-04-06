using Interfaces.Polymorphism.Classes;

namespace Interfaces.Polymorphism
{
    class Program
    {
        private static void Main(string[] args)
        {
            var encoder = new VideoEncoder();
            encoder.RegisterNotificationChannel(new MailNotificationChannel());
            encoder.RegisterNotificationChannel(new SmsNotificationChannel());
            encoder.Encode(new Video());
        }
    }
}
