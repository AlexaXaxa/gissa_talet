using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gissa_talet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
                             Spelet ""Gissa talet""
                                Talet är tänkt
                                Du måste gissa
                        Mata in ett tal mellan 1 och 100");

            bool spelaIgen = true;
            while (spelaIgen)
            {
                Random rnd = new Random();
                int tal = rnd.Next(1, 100);
                //Console.WriteLine(tal);

                int amount = 1;


                int gissning = 0;

                while (!(gissning == tal))
                {
                    string input = Console.ReadLine();
                    while (!int.TryParse(input, out gissning))
                    {
                        Console.WriteLine("Mata in ett heltal mellan 1 och 100!");
                        input = Console.ReadLine();
                    }

                    if (gissning > tal)
                    {
                        Console.WriteLine("Mindre!");
                        amount++;
                    }
                    else if (gissning < tal)
                    {
                        Console.WriteLine("Större!");
                        amount++;
                    }
                }
                if (amount == 1)
                {
                    Console.WriteLine($"Rätt! Det tog dig {amount} gissning!");
                }
                else
                {
                    Console.WriteLine($"Rätt! Det tog dig {amount} gissningar!");
                }



                string answer = "";

                bool question = true;
                while (question)
                {
                    if (answer.ToUpper() == "YES" || answer.ToUpper() == "Y")
                    {
                        spelaIgen = true;
                        question = false;
                    }
                    else if (answer.ToUpper() == "NO" || answer.ToUpper() == "N")
                    {
                        spelaIgen = false;
                        question = false;
                    }
                    else
                    {
                        Console.Write("\nVill du spela igen? (yes/no): ");
                        answer = Console.ReadLine();
                    }
                }
            }
        }
    }
}
