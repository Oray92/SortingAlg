using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;



namespace Alphanumerische_Zahlen
{
    public class Bubble_Sort
    {
        //propertie
        public string Data { get; set; }
        public static void BubbleSort(DoppeltverketteteListe liste)
        {

            bool swap;
            string temp;
            int n = liste.GetLength();
            do
            {
                swap = false;

                for (int i = 0; i < n - 1; i++)

                    if (string.Compare((currentNode), (currentNode + 1)) < 0)
                    {
                        //swap
                        temp = n.CompareTo[currentNode];
                        letters[currentNode] = letters[currentNode + 1];
                        letters[currentNode + 1] = temp;
                        swap = true;
                    }
                n--;
            } while (swap && n > 0);
        }
    }
}