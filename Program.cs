namespace home19June
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numbers =
            {
                "****\n" +
                "*  *\n" +
                "*  *\n" +
                "*  *\n" +
                "*  *\n" +
                "****\n",

                " **\n" +
                "* *\n" +
                "  *\n" +
                "  *\n" +
                "  *\n" +
                "****\n",

                " **\n" +
                "*  *\n" +
                "*  *\n" +
                "  *\n" +
                " *\n" +
                "****\n",

                " **\n"+
                "*  *\n" +
                "   *\n" +
                " ***\n" +
                "   *\n" +
                "****\n",

                 "*  *\n"+
                 "*  *\n" +
                 "*  *\n" +
                 "****\n" +
                 "   *\n" +
                 "   *\n",

                 "****\n"+
                 "*\n" +
                 "*\n" +
                 "****\n" +
                 "   *\n" +
                 "****\n",

                 "****\n"+
                 "*\n" +
                 "*\n" +
                 "****\n" +
                 "*  *\n" +
                 "****\n",

                "****\n" +
                "*  *\n" +
                "   *\n" +
                "   *\n" +
                "   *\n" +
                "   *\n",

                "****\n" +
                "*  *\n" +
                "*  *\n" +
                "****\n" +
                "*  *\n" +
                "****\n",

                "****\n" +
                "*  *\n" +
                "*  *\n" +
                "****\n" +
                "   *\n" +
                "   *\n",

            };

            Console.WriteLine("Enter the number: ");
            string? num = Console.ReadLine();

            Console.WriteLine("Numbers(0) or Stars(1): ");
            int style = Convert.ToInt32(Console.ReadLine());

            foreach (var digit in num)
            {
                int digitConverted = (int)char.GetNumericValue(digit);
                string numberPicture = numbers[digitConverted];

                if (style == 0) numberPicture = numberPicture.Replace('*', digit);
                Console.WriteLine(numberPicture);
            }

        }
    }
}