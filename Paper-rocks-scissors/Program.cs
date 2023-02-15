
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose your weapon:");
        Console.WriteLine("**************************************************************************\n");
        Console.WriteLine("1. Paper\n");
        Console.WriteLine("2. Rock\n");
        Console.WriteLine("3. Scissors\n");

        string userChoice = Console.ReadLine();
        bool gameLoop = true;
       
        while(gameLoop)
        {
            Random randomChoice = new Random();
            int computerChoice = randomChoice.Next(1, 4);

            switch (computerChoice)
            {
                case 1:

                    if (userChoice == "1")
                    {
                        //tie
                        Console.WriteLine("User - rock");
                        Console.WriteLine("Computer - rock\n");
                        Console.WriteLine("Tie");
                        Console.WriteLine("---------------------------------");
                    }

                    else if (userChoice == "2")
                    {
                        Console.WriteLine("User - paper");
                        Console.WriteLine("Computer - rock\n");
                        Console.WriteLine("User - win");
                        Console.WriteLine("---------------------------------");
                    }

                    else if (userChoice == "3")
                    {
                        Console.WriteLine("User - scissors");
                        Console.WriteLine("Computer - rock\n");
                        Console.WriteLine("Computer - win");
                        Console.WriteLine("---------------------------------");
                    }
                    break;

                case 2:

                    if (userChoice == "1")
                    {
                        //tie
                        Console.WriteLine("User - paper");
                        Console.WriteLine("Computer - paper\n");
                        Console.WriteLine("Tie");
                        Console.WriteLine("---------------------------------");
                    }

                    else if (userChoice == "2")
                    {
                        Console.WriteLine("User - rock");
                        Console.WriteLine("Computer - paper\n");
                        Console.WriteLine("User - win");
                        Console.WriteLine("---------------------------------");
                    }

                    else if (userChoice == "3")
                    {
                        Console.WriteLine("User - paper");
                        Console.WriteLine("Computer - rock\n");
                        Console.WriteLine("User - win");
                        Console.WriteLine("---------------------------------");
                    }
                    break;

                case 3:

                    if (userChoice == "1")
                    {
                        //tie
                        Console.WriteLine("User - scissors");
                        Console.WriteLine("Computer - scissors\n");
                        Console.WriteLine("Tie");
                        Console.WriteLine("---------------------------------");
                    }

                    else if (userChoice == "2")
                    {
                        Console.WriteLine("User - scissors");
                        Console.WriteLine("Computer - paper\n");
                        Console.WriteLine("User - win");
                        Console.WriteLine("---------------------------------");
                    }

                    else if (userChoice == "3")
                    {
                        Console.WriteLine("User - paper");
                        Console.WriteLine("Computer - scissors\n");
                        Console.WriteLine("Computer - win");
                        Console.WriteLine("---------------------------------");
                    }
                    break;

                default:

                    Console.WriteLine("Invalid entry!");

                    break;

            }
            Console.Write("Do you wanna play again? Y/N:");
            var n = Console.ReadLine();
            var y = Console.ReadLine(); 
            if (n == "N")
                break;
            if(y == "Y")
            {
                Console.WriteLine("Select your weapon:");
                gameLoop = true;
                
            }


        }
       


    }
}