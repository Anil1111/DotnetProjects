using System;
using System.Threading;

namespace Events.Classes
{
    public class VideoEncoder
    {
        // 1 - Define a delegate
        // 2 - Define an event based on that delegate
        // 3 - Raise the event

        public delegate void VideoEncodedEventHandler(object source, EventArgs args);

        public event VideoEncodedEventHandler VideoEncoded;
       
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            OnVideoEncoded();
        }

        protected virtual void OnVideoEncoded()
        {
            //if the list of subscribers is not empty (null) then notify the subscribers
            VideoEncoded?.Invoke(this, EventArgs.Empty);
        }
    }
}
