using System;
using System.Threading;

namespace Events.Classes
{
    public class VideoEncoder
    {
        // 1 - Define a delegate
        // 2 - Define an event based on that delegate
        // 3 - Raise the event

        //default delegate
        //public delegate void VideoEncodedEventHandler(object source, EventArgs args);

        //default delegate - Sending data to subscribers
        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        //default event handler
        //public event VideoEncodedEventHandler VideoEncoded;

        //-----SHORTHAND
        //if sending data to subscribers
        public event EventHandler<VideoEventArgs> VideoEncoded;

        //if not sending data to subscribers
        //public event EventHandler VideoEncoded;

        

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            //if the list of subscribers is not empty (null) then notify the subscribers
            //VideoEncoded?.Invoke(this, EventArgs.Empty);

            VideoEncoded?.Invoke(this, new VideoEventArgs() { Video = video });
        }
    }
}
