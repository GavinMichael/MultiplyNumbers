using System;

namespace HelloWorld
{
    class Program
    {
        public static void Main()
        {
            Start:;
            try
            {
                

                Random r = new Random();
                int x = r.Next(1, 10);
                int y = r.Next(1, 10);
                //Console.WriteLine(x);
                //Console.WriteLine(y);
                Console.WriteLine("What is {0} multiplied by {1}", x, y);
                int answer = x * y;
                int userAnswer = Convert.ToInt32(Console.ReadLine());
                if (answer == userAnswer)
                {

                    Console.WriteLine("Correct");
                }
                else
                {
                    Console.WriteLine("Incorrect! {0} is the correct answer",answer);
                }

                goto Start;
            }
            catch (Exception)
            {

                Console.WriteLine("NOOOOOOOOOOOOOOooooooooooooo...........");

            }
            goto Start;
        }
    }
}
