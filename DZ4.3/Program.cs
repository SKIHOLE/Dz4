using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Player myPlayer = new Player();
            myPlayer.Play();
            myPlayer.Pause();
            myPlayer.Stop();
            myPlayer.Record();
            myPlayer.Pause();
            myPlayer.Stop();
            Console.ReadLine();
        }
    }
    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }
    interface IRecodable
    {
        void Record();
        void Pause();
        void Stop();
    }
    class Player:IPlayable,IRecodable
    {
        public void Play() => Console.WriteLine("Start Playing");
        public void Pause() => Console.WriteLine("Pause");
        public void Stop() => Console.WriteLine("Stop");
        public void Record() => Console.WriteLine("Start Recording");
    }
}
