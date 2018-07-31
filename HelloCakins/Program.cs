using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCakins
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" H E L L O     M O T O");
            Console.Write(" Press <any> key to terminate ");

            // blocking call awaiting key down
            // 
            var _keyPressed = Console.ReadKey();
        }
    }
}
