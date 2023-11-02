using System;
namespace Project
{
    public class Queuing
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Shopping System\n");
            Menu();
        }
        static void Menu()
        {
            Console.WriteLine("The following are the ITEMS vailable in the Shop\n1.Tissues\n2.Soap\n3.Clothes\n4.Shoes\n5.Quit\n");
            Console.WriteLine("Enter your Choice from the Above Options.");
            int x = int.Parse(Console.ReadLine());
            switch(x)
            {
                case 1:
                    Choice();
                    Exit();
                    break;
                case 2:
                    Choice();
                    Exit();
                    break;
                case 3:
                    Choice();
                    Exit();
                    break;
                case 4:
                    Choice();
                    Exit();
                    break;
                case 5:
                    Exit();
                    break;
                default:
                    Console.WriteLine("Enter the Correct Option from the One Above\n");
                    Exit();
                    Choice();
                    break;
            }
        }
        static void Choice()
        {
            Console.WriteLine("Enter the Unit of the Product You Would Like to Buy");
            double unit = double.Parse(Console.ReadLine());

            if (unit > 4)
            {
                Console.WriteLine("Sorry You cannot Buy morethan 4 Units: ");
                return;
            }
            else
            {
                Console.WriteLine("Enter the Quantity of the Products you anticipate to buy: ");
                double quantity = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the Code of the Product You are Purchasing: ");
                string code = Console.ReadLine();

                Console.WriteLine("Below Shows the List of your Order");
                Console.WriteLine(unit + "Units");
                Console.WriteLine(quantity + "Quantities");
                Console.WriteLine(code + "Code");

                Console.WriteLine("Thanks");

            }

        }
        static void Exit()
        {
            Console.WriteLine("Would You Like to Exit?\n1.Yes\n2.No");
            int y = int.Parse(Console.ReadLine());
            switch(y)
            {
                case 1:
                    Console.WriteLine("Thanks for Using Our System!");
                    break;
                case 2:
                    Menu();
                    break;    
            }
        }
    }
}