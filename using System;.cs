{
            int Savings = 5000;
            int SavingsinFood = 1000;
            int SavingsinSchool = 300;
            int SavingsinTransportation = 500;
    

            Console.WriteLine("\nFINANCE TRACKER");
         
                {
                    Console.WriteLine("\nMENU");
                    Console.WriteLine("1. View Savings");
                    Console.WriteLine("2. View Budget");
                    Console.WriteLine("Enter 0 to Exit");

                    Console.Write("\nEnter your choice: ");
                    string? userInput = Console.ReadLine();

                    while (userInput != "0")
                    {
                        switch (userInput)
                    {
                        case "1":
                            Console.WriteLine("\nYour Savings is " + Savings);

                            Console.WriteLine("\nMENU");
                            Console.WriteLine("1. View Savings");
                            Console.WriteLine("2. View Budget");
                            Console.WriteLine("Enter 0 to Exit");

                            Console.Write("\nEnter your choice: ");
                            userInput = Console.ReadLine();
                            break;

                        case "2":
                            Console.WriteLine("\nMENU");
                            Console.WriteLine("1. View Savings in Food");
                            Console.WriteLine("2. View Savings in School");
                            Console.WriteLine("3. to View Savings in Transportation");
                            
                            Console.Write("\nEnter your choice: ");
                            string? userChoice = Console.ReadLine();
                    
                                if (userChoice == "1") 
                                {
                                    Console.WriteLine("\nYour Savings in Food is " + SavingsinFood);
                                    Console.WriteLine("\nMENU");
                                    Console.WriteLine("1. View Savings");
                                    Console.WriteLine("2. View Budget");
                                    Console.WriteLine("Enter 0 to Exit");

                                    Console.Write("\nEnter your choice: ");
                                    userInput = Console.ReadLine();


                                }

                                else if (userChoice == "2") 
                                {
                                    Console.WriteLine("\nYour Savings in School is " + SavingsinSchool);
                                    Console.WriteLine("\nMENU");
                                    Console.WriteLine("1. View Savings");
                                    Console.WriteLine("2. View Budget");
                                    Console.WriteLine("Enter 0 to Exit");

                                    Console.Write("\nEnter your choice: ");
                                    userInput = Console.ReadLine();
                                    

                                }

                                else if (userChoice == "3") 
                                {
                                    Console.WriteLine("\nYour Savings in Transportation is " + SavingsinTransportation);
                                    Console.WriteLine("\nMENU");
                                    Console.WriteLine("1. View Savings");
                                    Console.WriteLine("2. View Budget");
                                    Console.WriteLine("Enter 0 to Exit");

                                    Console.Write("\nEnter your choice: ");
                                    userInput = Console.ReadLine();

                                }
                                else
                                {
                                    Console.WriteLine("\nInvalid Choice. Please try again.");

                                    Console.WriteLine("\nMENU");
                                    Console.WriteLine("1. View Savings in Food");
                                    Console.WriteLine("2. View Savings in School");
                                    Console.WriteLine("3. to View Savings in Transportation");
                                    
                                    Console.Write("\nEnter your choice: ");
                                    userChoice = Console.ReadLine();
                                }

                        break;

                        default:
                            Console.WriteLine("\nInvalid input. Please try again.\n");
                            Console.WriteLine("\nMENU");
                            Console.WriteLine("1. View Savings");
                            Console.WriteLine("2. View Budget");
                            Console.WriteLine("Enter 0 to Exit");

                            Console.Write("\nEnter your choice: ");
                            userInput = Console.ReadLine();
                        break;

                        
                    

        }
                    }
    }
}
