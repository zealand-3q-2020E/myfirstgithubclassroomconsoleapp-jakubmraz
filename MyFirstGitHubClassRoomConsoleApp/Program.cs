using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGitHubClassRoomConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opgave tilføj en Console.writeline med noget tekst og commit + push
            //se herefter på dit GitHub Classroom repo om ændringen er kommet op
            if(1+1==2)
                if(1+1==2)
                    if (1 + 1 == 2)
                    {
                        Console.WriteLine("Cosnoom the chalice");
                    }
                    else
                    {
                        Console.WriteLine("Are ya coding son");
                    }
                else
                {
                    Console.WriteLine("patreon link below");
                }
            else
            {
                Console.WriteLine("/ban chaliceconsumer1");
            }

            Panzerkampfwagen tiger1 = new Panzerkampfwagen("Tiger 1");
            Console.WriteLine($"{tiger1.Name} goes {tiger1.Sound}");
            Console.ReadKey();
        }
    }
}
