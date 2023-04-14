using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSVP_lab01
{
    internal class Program
    {
        public static void SelectSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
        }
        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

      
        public static void MergeSort(int[] arr)
        {
            int n = arr.Length;
            int currSize;

            for (currSize = 1; currSize <= n - 1; currSize = 2 * currSize)
            {
                for (int leftStart = 0; leftStart < n - 1; leftStart += 2 * currSize)
                {
                    int mid = Math.Min(leftStart + currSize - 1, n - 1);
                    int rightEnd = Math.Min(leftStart + 2 * currSize - 1, n - 1);

                    Merge(arr, leftStart, mid, rightEnd);
                }
            }
        }

        public static void Merge(int[] arr, int left, int mid, int right)
        {
            int i, j, k;
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] L = new int[n1];
            int[] R = new int[n2];

            for (i = 0; i < n1; i++)
            {
                L[i] = arr[left + i];
            }
            for (j = 0; j < n2; j++)
            {
                R[j] = arr[mid + 1 + j];
            }

            i = 0;
            j = 0;
            k = left;

            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }

        public static void print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] arrSelectSort = { 64, 25, 12, 22, 11 };
            Console.Write("Сортировка Selekt Sort:");
            SelectSort(arrSelectSort);
            print(arrSelectSort);

            int[] arrBubbleSort = { 55, 33, 2, 43, 15 };
            Console.Write("Сортировка Bubble Sort:");
            BubbleSort(arrBubbleSort);
            print(arrBubbleSort);

            int[] arrMergeSort = { 75, 64, 13, 5, 19 };
            Console.Write("Сортировка Merge Sort:");
            MergeSort(arrMergeSort);
            print(arrMergeSort);


            Console.ReadLine();
        }
    }
}
