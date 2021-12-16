using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alphanumerische_Zahlen
{
    public class Merge_Sort
    {
        public string Data { get; set; }
        public static void MergeSort(DoppeltverketteteListe dllListe, int left, int mid, int right)
        {
            string[] temp = new string[10];
            int i, left_end, dllListe_elements, tmp_pos;
            left_end = (mid - 1);
            tmp_pos = left;
            dllListe_elements = (right - left + 1);
            while ((left <= left_end) && (mid <= right))
            {
                if ((char)(left) <= (char)(mid))
                    temp[tmp_pos++] = char.ConvertFromUtf32(left++);
                else
                    temp[tmp_pos++] = char.ConvertFromUtf32(mid++);
            }
            while (left <= left_end)
                temp[tmp_pos++] = char.ConvertFromUtf32(left++);
            while (mid <= right)
                temp[tmp_pos++] = char.ConvertFromUtf32(mid++);
            for (i = 0; i < dllListe_elements; i++)
            {
                dllListe.GetNode(right).Data = temp[right];
                right--;
            }
        }
        public static void SortMethod(DoppeltverketteteListe dllListe, int left, int right)
        {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                SortMethod(dllListe, left, mid);
                SortMethod(dllListe, (mid + 1), right);
                MergeSort(dllListe, left, (mid + 1), right);
            }
        }
    }
}
