namespace SortArrayWithoutTouching_5Minus
{
    internal class Program
    {
        // Method to sort the number without touching -5
        public static int[] sort_numbers(int[] arr)
        {
            int[] num = arr.Where(x => x != 5).OrderBy(x => x).ToArray();
            int ctr = 0;
            return arr.Select(x => x >= 0 ? num[ctr++] : -5).ToArray();
        }
        static void Main(string[] args)
        {
            // Create the array of unsorted numbers
            int[] x = sort_numbers(new int[]{ -5, 12, 48, 85, -5, 45, 75, 96, 3 });

            // Now print the sorted array
            foreach(var i in x)
            {
                Console.WriteLine(i.ToString());
            }
        }
    }
}
