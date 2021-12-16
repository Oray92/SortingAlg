using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Alphanumerische_Zahlen
{
    public class Quick_Sort
    {

        public string Data { get; set; }
        public static String Quicksort(DoppeltverketteteListe a, int start, int end)
        {
            //Index for the "left to right scan"
            int i = start;
            //Index for the "right to left scan"
            int j = end;
            //Only examine arrays of 2 or more elements.
            do /*(end - start >= 1)*/
            {
                Node pivot = a.GetNode(start);

                while ((a.GetNode(start).CompareTo(pivot) < 0) && (start < end)) start++;
                while ((a.GetNode(start).CompareTo(pivot) > 0) && end > start && end >= start) end--;

                if (start <= end)
                {
                    string temp = a.GetNode(start).Data;
                    a.GetNode(start).Data = a.GetNode(end).Data;
                    a.GetNode(end).Data = temp;
                }
                return pivot.Data;
            } while (start <= end);
            
            //Swap(a, start, end);            
        }
        private static void Swap(DoppeltverketteteListe a, int start, int end)
        {
            //Swap the pivot point with the last element of the left partition
            Swap(a, start, end);
            //Sort left partition
            Quicksort(a, start, end - 1);
            Quicksort(a, end + 1, end);
        }
    }
}