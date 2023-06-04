namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (double i = 50; i <= 70; i++)
            {
                while (i != 1)
                {
                    if (i % 2 == 0)
                    {
                        i /= 2;
                    }
                    else
                    {
                        i = (i * 3 + 1) / 2;
                    }
                }

                Console.WriteLine(i);
            }
        }
    }
}