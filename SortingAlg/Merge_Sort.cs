namespace Alphanumerische_Zahlen
{
    public class Merge_Sort
    {
        private static void MergeSort(DoppeltverketteteListe dllListe, int left, int mid, int right)
        {


            // Find sizes of two
            // subarrays to be merged
            int n1 = mid - left + 1;
            int n2 = right - mid;

            // Create temp arrays
            char[] L = new char[n1];
            char[] R = new char[n2];
            int i, j;

            // Copy data to temp arrays
            for (i = 0; i < n1; ++i)
                L[i] = dllListe.GetNode(left + i).Data;
            for (j = 0; j < n2; ++j)
                R[j] = dllListe.GetNode(mid + 1 + j).Data;

            // Merge the temp arrays

            // Initial indexes of first
            // and second subarrays
            i = 0;
            j = 0;

            // Initial index of merged
            // subarray array
            int k = left;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    dllListe.GetNode(k).Data = L[i];
                    i++;
                }
                else
                {
                    dllListe.GetNode(k).Data = R[j];
                    j++;
                }
                k++;
            }

            // Copy remaining elements
            // of L[] if any
            while (i < n1)
            {
                dllListe.GetNode(k).Data = L[i];
                i++;
                k++;
            }

            // Copy remaining elements
            // of R[] if any
            while (j < n2)
            {
                dllListe.GetNode(k).Data = R[j];
                j++;
                k++;
            }
        }

        // Main function that
        // sorts arr[l..r] using
        // merge()
        public static void sort(DoppeltverketteteListe dllListe, int start, int ende)
        {
            if (start < ende)
            {
                // Find the middle
                // point
                int m = start + (ende - start) / 2;

                // Sort first and
                // second halves
                sort(dllListe, start, m);
                sort(dllListe, m + 1, ende);

                // Merge the sorted halves
                MergeSort(dllListe, start, m, ende);
            }
        }
    }
}
