using System;
using System.Threading;

namespace CSharpEventAndDelegates
{
    class VideoEncoder
    {
        public delegate void VideoEncoded(object source, VideoEncodedEventArgs e);

        public event VideoEncoded VideoEncodedEvent;

        public void Encode(Video video)
        {
            //Some logic to encode video
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);

            //After video is encoded
            OnVideoEncoded(video);
        }

        private void OnVideoEncoded(Video video)
        {
            if (VideoEncodedEvent != null)
                VideoEncodedEvent(this, new VideoEncodedEventArgs { video = video });
        }
    }

    class VideoEncodedEventArgs : EventArgs
    {
        public Video video { get; set; }
    }
}