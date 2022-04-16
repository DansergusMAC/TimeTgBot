using System;
using System.Threading.Tasks;
using System.Timers;

namespace DzTg
{
    class Program
    {
        static void Main(string[] args)
        {
         
        
        
        Timer timer = new Timer(21600000);
        timer.Elapsed += async ( sender, e ) =>  HandleTimer();
        timer.Start();
        Console.Write("Press any key to exit... ");
        Console.ReadKey();
    }

    private static void HandleTimer()
    {
        TgUI.SendMsg();
        ConnectionLogic.UserIdChecker();
    }
    }
}