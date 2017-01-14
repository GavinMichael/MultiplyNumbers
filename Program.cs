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
            //while (true)
            //{
            //    try
            //    {
            //        double x;
            //        double y;
            //        Console.WriteLine("Enter a number");
            //        x = Convert.ToDouble(Console.ReadLine());
            //        Console.WriteLine("Enter the number you wish to multiply {0} by", x);
            //        y = Convert.ToDouble(Console.ReadLine());
            //        double result = x * y;
            //        Console.WriteLine("The result is : {0}", result);
            //    }
            //    catch (Exception)
            //    {
            //        string notNum1 = "Numéros s'il vous plaît";
            //        string notNum2 = "Only numbers please";
            //        string notNum3 = "That isn't a number silly!";

            //        Random r = new Random();
            //        int randomNumber = r.Next(0, 3);
            //        switch (randomNumber)
            //        {
            //            case 0:
            //                Console.WriteLine(notNum1);
            //                break;
            //            case 1:
            //                Console.WriteLine(notNum2);
            //                break;
            //            case 2:
            //                Console.WriteLine(notNum3);
            //                break;
            //        }                 
            //    }
            //}

        }
    }
}