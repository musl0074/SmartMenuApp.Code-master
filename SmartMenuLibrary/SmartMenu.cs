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
        int counter = 0;
        string line;
        List<String> items = new List<string>();
        string[] substrings;
        string userInput;



        public void LoadMenu(string path)
        {
            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                substrings = line.Split(';');
                if (substrings.Length > 1)
                {
                    items.Add(substrings[1]);
                }

                System.Console.WriteLine(substrings[0]);
                counter++;
                System.Console.WriteLine("Hej Muslim");

            }

            file.Close();
            System.Console.WriteLine("There were {0} lines.", counter);
            // Suspend the screen.  
            System.Console.ReadLine();



        }
        public void Activate()
        {
            Console.WriteLine(line);
          
        }
    }
}
