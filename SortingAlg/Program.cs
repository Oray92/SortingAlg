using Alphanumerische_Zahlen;
using System;
using System.Linq;
using System.Collections.Concurrent;



namespace Alphanumerische_Zahl
{
    class Program
    {
        private static Random random = new Random();

        public static void Main(string[] args)
        {
            int stringCount = 1;  //die länge der generierten strings
            int nodeCount = 10;   //anzahl 
            bool isFin = false;

            var quick = new Quick_Sort();
            var merge = new Merge_Sort();
            var bubble = new Bubble_Sort();
            var select = new Select_Sort();

            while (!isFin)
            {
                DoppeltverketteteListe dllListe = new DoppeltverketteteListe();

                Node node = new Node();

                //Generiert einen zufälligen char
                static string GenerateChar(int charCount)
                {
                    const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                    return new string(Enumerable.Repeat(chars, charCount)
                        .Select(s => s[random.Next(s.Length)]).ToArray());
                }



                for (int i = 0; i < nodeCount; i++)
                {
                    dllListe.Add(GenerateChar(stringCount));
                }


                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Unsorted list: \n" + dllListe + " length: " + dllListe.GetLength());
                Console.ResetColor();
                Console.WriteLine("\n1 Quick, 2 Bubble, 3 Merge, 4 Select \n");
                string userInput = Console.ReadLine();



                Console.ForegroundColor = ConsoleColor.Green;
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("QuickSort chosen, sorted list: \n" + dllListe.toString(quick.Data));
                        break;
                    case "2":
                        Console.WriteLine("BubbleSort chosen, sorted list: \n" + dllListe.toString(bubble.Data));
                        break;
                    case "3":
                        Console.WriteLine("MergeSort chosen, sorted list: \n" + dllListe.toString(merge.Data));
                        break;
                    case "4":
                        Console.WriteLine("SelectSort chosen, sorted list. \n" + dllListe.toString(select.Data));
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("!!!WRONG INPUT!!!: " + userInput);
                        break;
                }
                Console.ResetColor();
            }
        }
    }
}