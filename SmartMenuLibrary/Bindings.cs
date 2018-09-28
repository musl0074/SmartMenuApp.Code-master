using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunctionLibrary;

namespace SmartMenuLibrary
{
    class Bindings
    {
        //Vi har en metode som ikke returner noget. Den har en parametre der hedder menuID som den får fra SmartMenu.cs og tjekker hvor vidt hvilke id der blev tastet. 
        public static void Call(string menuID)
        {
            string something;
            string nothing = "";

            if (menuID == "1")
            {
                Console.WriteLine(Functions.DoThis());

            }
            else if (menuID == "2")
            {
                Console.WriteLine(Functions.DoThat());

            }
            else if (menuID == "3")
            {
                Console.WriteLine("Write something boyyy");
                something = Console.ReadLine();
                if (something.Equals(nothing))
                {
                    Console.WriteLine("Write something man?!?!!");
                    something = Console.ReadLine();
                }

                Console.WriteLine(Functions.DoSomething(something));

            }
            else if (menuID == "4")
            {
                Console.WriteLine("The The Answer To Life The Universe And Everything is: ");
                Console.WriteLine(Functions.GetTheAnswerToLifeTheUniverseAndEverything());
            }
            Console.ReadLine();
        }

    }
}