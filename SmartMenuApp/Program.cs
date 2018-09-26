using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartMenuLibrary;

namespace SmartMenuApp
{
    class Program
    {

        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Run();
        }

        private void Run()
        {
            SmartMenu menu = new SmartMenu();
            menu.LoadMenu(@"C:\Users\Marcu\Documents\SmartMenuApp.Code-master\MenuSpec.txt.Code-master\MenuSpec.txt");
            menu.Activate();
        }
    }
}
