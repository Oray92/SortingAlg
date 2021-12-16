using System;
using System.Collections.Generic;
using System.Text;

namespace Alphanumerische_Zahlen
{
    public class Select_Sort
    {

        public string Data { get; set; }
        public static void SelectSort(DoppeltverketteteListe dllListe)
        {
            int n = dllListe.GetLength();

            for (int i = 0; i < n; i++)
            {
                int temp, smallest;
                smallest = i;
                string minStr = dllListe.GetLength().ToString();
                for (int j = i + 1; j < n; j++)
                {
                    if (n.CompareTo(minStr) != 0)
                    {

                        smallest = j;

                        // swapping the min. element, found with the first element.
                        temp = n.CompareTo(smallest);
                        Convert.ToString((smallest) = n.CompareTo(i));
                        Convert.ToString((i) = temp);
                    }
                }
            }
        }
    }
}
