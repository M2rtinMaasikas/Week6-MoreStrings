using System;

namespace HOCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab mitu 'h', 'o' ja 'l' tähte on lauses "Hello, world!"

            string hellow = "Hello world!".ToLower();

            int counter1 = 0;
            int counter = 0;
            int counter2 = 0;
            for (int i = 0; i < hellow.Length; i++)
            {
                if (hellow[i] == 'h')
                {
                    counter++;

                }
                else if (hellow[i] == 'l')
                {
                    counter1++;
                }
                else if (hellow[i] == 'o')
                {
                    counter2++;
                }



            }
            Console.WriteLine($"Hello worldis on {counter} 'h' {counter2} 'o' ja {counter1} 'l'");
        }
    }


}