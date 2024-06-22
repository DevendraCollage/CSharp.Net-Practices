namespace MatchTheStringWordWithParentheses
{
    internal class Program
    {
        // Function to check the string has an parenthesis or not
        public static string reverse_remove_parenthese(string str)
        {
            int lid = str.LastIndexOf('('); // Get the any parenthesis last over index

            if (lid == -1)
            {
                return str;
            }
            else
            {
                int rid = str.IndexOf(')', lid);
                return reverse_remove_parenthese(
                str.Substring(0, lid) +
                new string(str.Substring(lid + 1, rid - lid - 1).Reverse().ToArray()) +
                str.Substring(rid + 1));
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(reverse_remove_parenthese("ab(dc)ef"));
        }
    }
}
