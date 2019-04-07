﻿using System;

namespace Events.Classes
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine($"MailService: Sending an email...{e.Video.Title}");
        }
    }
}