using System;

namespace CSharpEventAndDelegates
{
    class MailService
    {
        //Event handler
        public void VideoEncoded_EventHandler(object s, VideoEncodedEventArgs e)
        {
            Console.WriteLine("Sending mail for video " + e.video.Title);
            Console.ReadKey();
        }
    }
}
