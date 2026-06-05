using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern
{
    public interface ISubscriber
    {
        void Update(string videoTitle);
    }
    public class Subscriber : ISubscriber
    {
        private string name;

        public Subscriber(string name)
        {
            this.name = name;
        }

        public void Update(string videoTitle)
        {
            Console.WriteLine($"{name} received notification: {videoTitle}");
        }
    }
}
