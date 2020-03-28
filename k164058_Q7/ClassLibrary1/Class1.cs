using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class Class1
    {
        static unsafe void swap(int* x, int* y)
        {
            int temp;
            temp = *x;
            *x = *y;
            *y = temp;
        }

        static int choose_pivot(int i, int j)
        {
            return ((i + j) / 2);
        }

        public static unsafe void quicksort(int[] list, int m, int n)
        {
            int key, i, j, k;
            if (m < n)
            {
                k = choose_pivot(m, n);
                fixed (int* mm = &list[m])
                fixed (int* kk = &list[k])
                {
                    swap(mm, kk);
                }
                key = list[m];
                i = m + 1;
                j = n;
                while (i <= j)
                {
                    while ((i <= n) && (list[i] <= key))
                        i++;

                    while ((j >= m) && (list[j] > key))
                        j--;

                    if (i < j)
                    {
                        fixed (int* ii = &list[i])
                        fixed (int* jj = &list[j])
                        {
                            swap(ii, jj);
                        }
                    }
                }
                fixed (int* mm = &list[m])
                fixed (int* jj = &list[j])
                {
                    swap(mm, jj);
                }

                quicksort(list, m, j - 1);
                quicksort(list, j + 1, n);

            }

        }

        public static void printlist(int[] list, int n)
        {
            int i;
            for (i = 0; i < n; i++)
                Console.Write("{0}  ", list[i]);

        }
    }
}
