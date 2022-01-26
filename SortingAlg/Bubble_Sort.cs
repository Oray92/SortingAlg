using System;



namespace Alphanumerische_Zahlen
{
    public class Bubble_Sort
    {
        //propertie
        public string Data { get; set; }

        public static void BubbleSort(DoppeltverketteteListe a)
        {

            for (int i = 1; i <= a.GetLength() - 1; ++i)

                for (int j = 0; j < a.GetLength() - i; ++j)
                    if (char.ToUpper(a.GetNode(j).Data) - 64 > char.ToUpper(a.GetNode(j + 1).Data) - 64)
                        Swap(a.GetNode(j), a.GetNode(j + 1));
        }

        public static void Swap(Node x, Node y)
        {
            Char temp = x.Data;
            x.Data = y.Data;
            y.Data = temp;
        }

    }
}