using System;

namespace Alphanumerische_Zahlen
{
    public class Quick_Sort
    {
        public static void QuickSort(DoppeltverketteteListe arr, int start, int end)
        {
            int i;
            if (start < end)
            {
                i = Partition(arr, start, end);

                QuickSort(arr, start, i - 1);
                QuickSort(arr, i + 1, end);
            }
        }

        private static int Partition(DoppeltverketteteListe arr, int start, int end)
        {
            char temp;
            char lastString = arr.GetNode(end).Data;
           
            int i = start - 1;

            for (int j = start; j <= end - 1; j++)
            {
                char jString = arr.GetNode(j).Data;
                if (char.ToUpper(lastString) - 64 >= char.ToUpper(jString) - 64)
                {
                    i++;
                    temp = arr.GetNode(i).Data;
                    arr.GetNode(i).Data = arr.GetNode(j).Data;
                    arr.GetNode(j).Data = temp;
                }
            }

            temp = arr.GetNode(i + 1).Data;
            arr.GetNode(i + 1).Data = arr.GetNode(end).Data;
            arr.GetNode(end).Data = temp;

            return i + 1;
        }


    }
}