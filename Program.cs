//aisha mashrah
//10/19/22
//
int easyLvl = 101;
            int mediumLvl = 501;
            int hardLvl = 1001;
            int winningNum = 0;
            int gameMaxNum = 0;
            int numGuess = 0;
            string userInput;
            string? option;
            bool validNum = false;
            int guessCount = 0;
            Console.Clear();
            Console.WriteLine("What level would you like to play?");
            Console.WriteLine("Easy - Guessing from 1 - 10");
            Console.WriteLine("Medium - Guessing from 1 - 50");
            Console.WriteLine("Hard - Guessing from 1 - 100");
            Console.WriteLine("Please pick from Easy, Medium, or Hard");
            option = Console.ReadLine();

           
            while (option != "Easy" && option != "Medium" && option != "Hard")
            {
               
                Console.WriteLine("You entered in an invalid choice.");
                Console.WriteLine("Please pick from Easy, Medium, or Hard");
                option = Console.ReadLine();
            }
            Console.WriteLine("You selected " + option);
            //Pick a random number based on level
            Random random = new Random();
            //Generate the winning Number
            if (option == "Easy")
            {
                winningNum = random.Next(0, easyLvl);
                gameMaxNum = easyLvl - 1;
            }
            if (option == "Medium")
            {
                winningNum = random.Next(0, mediumLvl);
                gameMaxNum = mediumLvl - 1;
            }
            if (option == "Hard")
            {
                winningNum = random.Next(0, hardLvl);
                gameMaxNum = hardLvl - 1;
            }
            

            // while (validNum == false)
            while (validNum == false)
            {
                //Keep asking them to enter in a valid number
                Console.WriteLine("Enter a number from 1 to " + gameMaxNum);
                //Get the input as a string
                userInput = Console.ReadLine();
                //Then validate
                //Hello
                validNum = Int32.TryParse(userInput, out numGuess);
                //validNum = false
                //numGuess = 0
                if (validNum == true)
                {
                    //Check if the range is valid
                    if ((numGuess <= gameMaxNum) && (numGuess >= 1))
                    {
                        //It is a valid guess
                        validNum = true;
                    }
                    else
                    {
                        Console.WriteLine("Please pick a valid number.");
                        validNum = false;
                    }
                }else{
                    Console.WriteLine("You entered something that wasn't a number. Please pick a number");
                }


            }
            if (numGuess == winningNum)
            {
                //Congrats your awesome
                Console.WriteLine("You win!!! The winning number was " + winningNum);
            }
            else if (numGuess > winningNum)
            {
                Console.WriteLine("Your number is too high!!!");
            }
            else
            {
                Console.WriteLine("You guess is too low!!!");
            }