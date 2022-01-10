using System;
using System.Linq;

namespace SortingArray
{
    class Program
    {
        enum Sorting
        {
            Ascending,     // 0
            Descending     // 1            
        }
        static void Main(string[] args)
        {
            int n = ReadNumber("How many elements has the vector? ");
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = ReadNumber($"Element at index {i}=");
            }

            Console.WriteLine("How do you want array sorting (0-Ascending or 1-Descending)? ");

            int SortingInput;
            if (int.TryParse(Console.ReadLine(), out SortingInput))
            {
                if (Enum.IsDefined(typeof(Sorting), SortingInput))
                {
                    Sorting selectedSorting = (Sorting)Convert.ToInt32(SortingInput);
                    SortArray(selectedSorting, array);
                }
                else
                {
                    Console.Write("Sorting value is not valid!");
                    Console.WriteLine();
                }
            }
        }

        static void SortArray(Sorting mySorting, int[] array)
        {
            if (mySorting == Sorting.Ascending)
            {
                // Sort array in ASC order                
                Console.WriteLine();
                Console.Write("Sorted array in Ascending order: ");
                Array.Sort(array);
                for (int i = 0; i < array.Length; i++)
                {
                    if (i == array.Length - 1)
                    {
                        Console.Write($"{array[i]} ");
                    }
                    else
                    {
                        Console.Write($"{array[i]}, ");
                    }
                }
                Console.WriteLine();
            }
            else
            {
                // Sort array in DESC order                
                Console.WriteLine();
                Console.Write("Sorted array in Descending order: ");
                Array.Sort(array);
                Array.Reverse(array);
                for (int i = 0; i < array.Length; i++)
                {
                    if (i == array.Length - 1)
                    {
                        Console.Write($"{array[i]} ");
                    }
                    else
                    {
                        Console.Write($"{array[i]}, ");
                    }
                }
                Console.WriteLine();
            }
        }

        static int ReadNumber(string label)
        {
            Console.Write(label);
            string value = Console.ReadLine();
            int valueAsNumber = Convert.ToInt32(value);
            return valueAsNumber;
        }
    }
}
