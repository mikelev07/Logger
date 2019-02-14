using System;

namespace Logger
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*
            string input = Console.ReadLine();
            int value;

            if (int.TryParse(input, out value))
            {
                Console.WriteLine(
                    "You entered the number {0}, which is {1}.",
                    value,
                    value % 2 == 0 ? "even" : "odd"
                );

            }
            else
            {
                Console.WriteLine(
                    "You entered '{0}', which is not a valid integer.",
                    input
                );
            } */

            int[] array = new int[] { 3, 2, 1, 5, 4, 8, 7 };

            string[] names = { "Mike", "Emil", "Alan", "Nevskii", "Hohland" };
           

            Sort.InsertSort(names);

           
            foreach (string i in names)
                Console.WriteLine(i);

            Console.ReadKey();
        }

    }

    /// <summary>
    /// Sort class
    /// </summary>
    static class Sort
    {
        /// <summary>
        /// Swap the specified el1 and el2.
        /// </summary>
        /// <param name="el1">El1.</param>
        /// <param name="el2">El2.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        static void Swap<T>(ref T el1,ref T el2)
        {
            var mem = el1;
            el1 = el2;
            el2 = mem;
        }

        /// <summary>
        /// Inserts the sort.
        /// </summary>
        /// <param name="array">Array.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        public static void InsertSort<T>(T[] array) where T : IComparable<T>
        {
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = i; j > 0 && array[j - 1].CompareTo(array[j]) > 0; j--)
                {
                    Swap(ref array[j - 1], ref array[j]);
                }
            }
        }

        /// <summary>
        /// Choosens the sort.
        /// </summary>
        /// <param name="array">Array.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        public static void ChoosenSort<T>(T[] array) where T : IComparable<T>
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j].CompareTo(array[min]) < 0)
                        min = j;
                }
                Swap(ref array[i], ref array[min]);
            }
        }

        /// <summary>
        /// Quicks the sort.
        /// </summary>
        /// <param name="arr">Arr.</param>
        /// <param name="left">Left. (= 0)</param>
        /// <param name="right">Right.(= arr.Length - 1)</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        public static void QuickSort<T>(T[] arr, int left, int right) where T : IComparable<T>
        {
            if (left.CompareTo(right) < 0)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                {
                    QuickSort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    QuickSort(arr, pivot + 1, right);
                }
            }

        }

        static int Partition<T>(T[] arr, int left, int right) where T : IComparable<T>
        {
            T pivot = arr[left];
            while (true)
            {

                while (arr[left].CompareTo(pivot) < 0)
                {
                    left++;
                }

                while (arr[right].CompareTo(pivot) > 0)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left].CompareTo(arr[right]) == 0) return right;

                    Swap(ref arr[left], ref arr[right]);
                }
                else
                {
                    return right;
                }
            }
        }

    }

}
