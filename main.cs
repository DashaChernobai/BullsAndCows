using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullsAndCows
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] arr = new String[4];
            arr = GenerateNewGameMas();
            bool game = true;
            string inputString = "";
            Console.WriteLine("Game is started!!! (Write 'exit' to left the game)");
            while (inputString != "exit")
            {
                int bulls, cows;
                
                
                    Console.WriteLine("Input 4 numbers");
                    String[] mas = new String[4];
                    bulls = 0;
                    cows = 0;
                    for (int g = 0; g < 4; g++)
                    {

                        mas[g] = Console.ReadLine().ToString();
                        
                        if (mas[g] == arr[g]) { bulls++; }
                        else if ((mas[g] == arr[0])||(mas[g] == arr[1]) ||(mas[g] == arr[2]) ||(mas[g] == arr[3])) { cows++; }
                    }
                    if (bulls == 4) { Console.WriteLine("You won!!!!!!!!!!!!"); } 
                    else {
                        Console.WriteLine("You have "+bulls+" bulls and "+ cows+" cows."); 
                    }
                    
                
            }

            
        }

        private static String[] GenerateNewGameMas()
        {
            var rand = new Random();

            var knownNumbers = new HashSet<int>();

            String[] arr = new String[4];

            for (int i = 0; i < arr.Length; i++)
            {
                int newElement;
                do
                {
                    newElement = rand.Next(0,9);
                } while (!knownNumbers.Add(newElement));


                arr[i] = newElement.ToString();
                //Console.WriteLine(arr[i]);

            }
            return arr;
        }
    }
}
