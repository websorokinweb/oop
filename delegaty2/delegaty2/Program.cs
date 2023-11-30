using delegaty2.Classes;

namespace delegaty2
{
    public delegate void MessageHandler(string message);
    internal class Program
    {
        static void Main(string[] args)
        {
            Publisher pub = new Publisher();
            Subscriber sb = new Subscriber();
            
            pub.MessageEvent += sb.OnMessageReceived;
            pub.SendMessage("Test");
            pub.SendMessage("Test 2");
            pub.SendMessage("Test 3");
        }
    }
}