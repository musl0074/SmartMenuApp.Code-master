using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunctionLibrary;

namespace SmartMenuLibrary
{
    public class SmartMenu
    {
        string titel, menuValg;
        string[] menuPunkt, menuID;

        public void LoadMenu(string path) {

            string line;
            List<string> lines = new List<string>();

            System.IO.StreamReader file = new System.IO.StreamReader(path);
            // Fyld vores liste med tekstfilen linje for linje
            while ((line = file.ReadLine()) != null) {
                lines.Add(line);
            }

            // Sæt de to unikke variabler
            titel = lines[0];
            menuValg = lines[1];

            menuPunkt = new string[lines.Count - 2];
            menuID = new string[lines.Count - 2];

            // Sæt resten af variablerne
            for (int i = 2; i < lines.Count; i++) {
                string[] split = lines[i].Split(';');
                menuPunkt[i - 2] = split[0];
                menuID[i - 2] = split[1];
            }

            file.Close();
        }
        public void Activate(){
            int brugervalg = 0;

            Console.WriteLine(titel);
            foreach (string punkt in menuPunkt){
                                Console.WriteLine(punkt);
                            }
                            Console.WriteLine(menuValg);

            while (true) {
                
                string input = Console.ReadLine();
                // Exit hvis input er "0" eller en tom linje0
                if (input == "0" || input == "") {
                    break;
                }
                else if (int.TryParse(input, out brugervalg)) {
                    brugervalg--;
                    if (brugervalg < menuID.Length && brugervalg > 0) {
                        Bindings.Call(menuID[brugervalg]);
                    }
                }
                else {
                    Console.WriteLine("Ugyldigt Input");
                }
            }
        }
    }
}
