namespace PrintPrimeNumbersInStrictlyDescendingOrder
{
    internal class Program
    {
        // Function to chcek the number is prime or not
        public static bool isPrime(uint n)
        {
            if (n < 1) 
            {
                return false;
            }

            bool flag = false;
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    flag = true;
                    break;
                }
            }

            if (flag)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        static void Main(string[] args)
        {
            //Console.Write("Enter the Number here : ");
            //int num = Convert.ToInt32(Console.ReadLine());

            uint z = 0; 
            int nc;

            var p = new uint[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var nxt = new uint[128];

            while (true)
            {
                nc = 0; 

                foreach (var x in p)
                {
                    if (isPrime(x))
                    {
                        Console.Write("{0,8}{1}", x, ++z % 5 == 0 ? "\n" : " ");
                    }

                    for (uint y = x * 10, l = x % 10 + y++; y < l; y++)
                        nxt[nc++] = y;
                }

                if (nc > 1)
                {
                    Array.Resize(ref p, nc);
                    Array.Copy(nxt, p, nc);
                }
                else
                {
                    break;
                }
            }

            // Output the number of descending primes found
            Console.WriteLine("\n{0} descending primes found", z);
        }
    }
}
