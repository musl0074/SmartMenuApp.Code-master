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
        List<String[]> list; 
        string userInput;
        

        public void LoadMenu(string path)
        {
             list = File.ReadLines(path)
                          .Select(r => r.TrimEnd().Split(','))
                          .ToList();


        }
        public void Activate()
        {
            foreach(string item in line)
            {
                Console.WriteLine(item);   
            }
             userInput = Console.ReadLine();
        
         


        }
    }
}
