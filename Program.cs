using System;

namespace ObserverDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            YouTubeChannel channel = new YouTubeChannel();

            Subscriber ganesh = new Subscriber("Ganesh");
            Subscriber rahul = new Subscriber("Rahul");
            Subscriber amit = new Subscriber("Amit");

            channel.Subscribe(ganesh);
            channel.Subscribe(rahul);
            channel.Subscribe(amit);

            channel.UploadVideo("Observer Pattern Tutorial");

            Console.ReadLine();
        }
    }
}
