using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QIDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IFavoriteFood food = new QITest();
            food.Food();
            IVoice voice = food as IVoice;
            voice.Voice();
            Console.ReadLine();
        }
    }
}
