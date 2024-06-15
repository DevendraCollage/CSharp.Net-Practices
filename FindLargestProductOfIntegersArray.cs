/*
 * Author - Devendra Parmar
 * Program - Write a C# program to find the pair of adjacent elements that has the highest product of an array of integers.
 */

namespace FIndLargestProductOfArrayIntegers
{
    internal class Program
    {
        // Function to check the highest product of an array given by the user
        public static int adjacent_Elements_Product(int[] passArray)
        {
            int max = passArray[0] * passArray[1];

            // Check the array length less 2 than double the poduct of an array
            for (int x = 1; x <= passArray.Length - 2; x++)
            {
                max = Math.Max(max, passArray[x] * passArray[x + 1]);
            }

            return max;
        }
        static void Main(string[] args)
        {
            // Read the size of the array from the user
            Console.Write("Enter the size of the array : ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // Initilize the array and set the size
            int[] arr = new int[size];

            // Read the array elements from the user
            Console.WriteLine("Enter the array elements below : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("[{0}] : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Call the function an print the result
            Console.WriteLine(adjacent_Elements_Product(arr));
        }
    }
}
