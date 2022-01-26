using System;

namespace Alphanumerische_Zahlen
{
    public class Select_Sort
    {

        public string Data { get; set; }
        public static void SelectSort(DoppeltverketteteListe dllListe)
        {
            int n = dllListe.GetLength();

            // One by one move boundary of unsorted subarray
            for (int i = 0; i < n - 1; i++)
            {
                // Find the minimum element in unsorted array
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (char.ToUpper(dllListe.GetNode(j).Data) - 64 < char.ToUpper(dllListe.GetNode(min_idx).Data) - 64)
                        min_idx = j;

                // Swap the found minimum element with the first
                // element
                Char temp = dllListe.GetNode(min_idx).Data;
                dllListe.GetNode(min_idx).Data = dllListe.GetNode(i).Data;
                dllListe.GetNode(i).Data = temp;
            }
        }
    }
}

