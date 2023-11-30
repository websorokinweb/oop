using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegaty2.Classes
{
    internal class Subscriber
    {
        public void OnMessageReceived(string message)
        {
            Console.WriteLine($"Otrzymałem wiadomość: {message}");
        }
        public void OnCounterReahed(int count)
        {
            Console.WriteLine($"Osiągnęto limit {count}");
        }
    }
}
