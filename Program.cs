using System;

namespace CSharp_Shell
{

    public class Program
    {
        public static int zog(int a, int b)
        {

        int rusult = a + b;

            Console.WriteLine($"Your Result {a}+{b} = {rusult}");

            return rusult;

         }
        public static int biyog(int a, int b)
        {

            int rusult = a - b;
            Console.WriteLine($"Your Result {a}-{b} = {rusult}");
            return rusult;
        }
        public static int gun(int a, int b)
        {

            int rusult = a * b;
            Console.WriteLine($"Your Result {a}*{b} = {rusult}");
            return rusult;
        }
        public static int bag(int a, int b)
        {

            int rusult = a / b;
            Console.WriteLine($"Your Result {a}/{b} = {rusult}");
            return rusult;

        }
        public static void Main()
        {
            Console.WriteLine("Enter Your First Number:");

            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Your second Number:");

            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("What You Want : \n \tA - Addition \n \tB - Subtraction \n \tC - Multiplication \n \tD - Division");
            string type = Console.ReadLine().ToUpper();

            if(type.Equals("A"))
            {
                Program.zog(num1,num2);

            }
            else if (type.Equals("B"))
            {
                Program.biyog(num1, num2);

            }
            else if (type.Equals("C"))
            {
                Program.gun(num1, num2);

            }
            else if (type.Equals("D"))
            {
                Program.bag(num1, num2);

            }

            else
            {
                Console.WriteLine("Envalid");
            }

            Console.WriteLine("Wanna CAlCULaTE Again ? \n\t YES \n\t NO");
            string bd = Console.ReadLine().ToLower();

            if (bd == "yes")

            {
                Main();
            }
            else
            {
                Console.WriteLine("Okay Good Bye!");
            }

            



        }
    }
}