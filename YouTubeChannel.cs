using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern
{
    public class YouTubeChannel
    {
        private List<ISubscriber> subscribers =
            new List<ISubscriber>();

        public void Subscribe(ISubscriber subscriber)
        {
            subscribers.Add(subscriber);
        }

        public void UploadVideo(string title)
        {
            Console.WriteLine($"New Video Uploaded: {title}");
            Console.WriteLine();

            foreach (var subscriber in subscribers)
            {
                subscriber.Update(title);
            }
        }
    }
}
