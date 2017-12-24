using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QIDemo
{
    class QITest : IFavoriteFood, IVoice
    {
        public void Food()
        {
            Console.WriteLine("I like mice.");
        }

        public void Voice()
        {
            Console.WriteLine("miao,miao,miao...");
        }
    }
}
