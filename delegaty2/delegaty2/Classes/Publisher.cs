using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegaty2.Classes
{
    internal class Publisher
    {
        public event MessageHandler MessageEvent;
        public int counter;
        public void SendMessage(string message)
        {
            if(MessageEvent != null)
            {
                MessageEvent(message);
                counter++;
            }
        }
        public Publisher() {
            counter = 0;
        }
    }
}
