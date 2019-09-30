using System;

namespace ATM
{
    class Program
    {
        
            //int amt = 10000, amtwithdraw, current, pin = 4040, pin1, pin2;

            //read pin
            //Console.WriteLine("Enter your pin");
            //pin1 = Int32.Parse(Console.ReadLine());

            static void Main (string[] args)
            {
               
                int amt = 10000, amtwithdraw, current, pin = 4040, pin1, pin2;

                Console.WriteLine("Enter your pin");
                pin1 = Int32.Parse(Console.ReadLine());

            if (pin1 == pin)
                {
                    Console.WriteLine("1. Check balance");
                    Console.WriteLine("2. Withdraw money");
                    Console.WriteLine("3. Deposit money");
                    Console.WriteLine("4. Change pin");
                    Console.WriteLine("******************");
                    Console.WriteLine("Enter you choice");
                    Console.WriteLine("******************");
                    int choice = Int32.Parse(Console.ReadLine());


                    switch (choice)
                    {
                        case 1:
                        Console.WriteLine("The current balance in your account is " + amt);
                            break;

                        case 2:
                            Console.WriteLine("Enter the amount you want to withdraw");
                            amtwithdraw = Int32.Parse(Console.ReadLine());

                            if (amtwithdraw % 100 == 0)
                            {
                                Console.WriteLine("Please collect the cash");
                                current = amt - amtwithdraw;

                                Console.WriteLine("The current balance is now " + current);
                            }
                            else if (amtwithdraw % 100 != 0)
                            {
                                Console.WriteLine("Please enter the amount to withdraw in the multiples of 100");
                            }
                            else
                            {
                                Console.WriteLine("Your account does not have sufficient balance");
                            }
                            break;

                        case 3:
                            Console.WriteLine(" Enter the amount to deposit");

                            amtwithdraw = Int32.Parse(Console.ReadLine());

                            current = amt + amtwithdraw;

                            Console.WriteLine("The current balance is " + current);
                            break;

                        case 4:
                            Console.WriteLine("Enter your previous pin");
                            int prepin = Int32.Parse(Console.ReadLine());

                            if (prepin == pin)
                            {
                                Console.WriteLine("Enter your new pin");
                                pin2 = Int32.Parse(Console.ReadLine());
                                pin1 = pin2;

                                Console.WriteLine("Your pin is changed");

                            }
                            else
                            {
                                Console.WriteLine("Pin is wrong");
                                Console.WriteLine("Enter the correct pin");
                            }
                            break;

                        default:
                            Console.WriteLine("Please select the correct option");
                            break;

                    }
                


            }
        }
    }
}
