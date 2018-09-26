using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMenuLibrary
{
    public class SmartMenu
    {
        string[] line;
        

        public void LoadMenu(string path)
        {
            line = File.ReadAllLines(path);
           
        }
        public void Activate()
        {
            foreach(string item in line)
            {
                Console.WriteLine(item);   
            }
            Console.ReadLine();

        }
    }
}
