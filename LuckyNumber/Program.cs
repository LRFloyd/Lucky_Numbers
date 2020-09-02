using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucky_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool playAgain = true;

            //I added a Do-While loop at the very beginning of the game and made the condition to continue or quit based on the bool 'playAgain.
            //Since I want the program to be run at least one time I saw it best to use this loop and if the user wants to quit before, during or doesnt want to play again the option is there.
            //If the bool is true the game will loop, but if false it will end and depending on where 'quit is typed specific messages will be show
            do
            {
                //global variables application will be able to use in the Main method

                //strings
                string message = "Welcome to LUCKY NUMBERS, a game thats all about LUCK!";
                string resume;
                string lowUserNumS = " ";
                string highUserNumS = " ";
                string userLuckyNumS = " ";
                string winnings = " ";
                string testNum = " ";

                //boolean 
                bool help = false;

                //ints arrays and ints
                int[] userLuckyNumA = new int[6];
                int[] jackpotRandomNum = new int[6];
                int testNumb;
                int lowUserNumI;
                int highUserNumI;
                int userLuckyNumI;
                int jackpotNum;
                int matches = 0;
                int jackpot = 1500000000; 

                //Random number Generator
                Random jackpotRandom = new Random();

                //Console will print the hard coded Welcome and How to play messages.
                //Then ask the user for input 
                //Finally the console will clear the screen for new text

                //Intro
                Console.WriteLine("Hello User, Please enter your name");
                string userName = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Hello {0}, {1}\n", userName, message);
                Console.WriteLine("Please press any key to contine");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("In this game you will make a range of numbers, \nsetting a high and low number first.\n");
                Console.WriteLine("Then based on the range you made, \nyou'll choose an additional six numbers to guess \nwhat you think is the 'LUCKY NUMBERS' to win a jackpot!\n");
                Console.WriteLine("Please press any key to contine");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("The larger the range, the greater your chances are of winning! \nYour winning is based on the number of numbers guessed correctly.\n");
                Console.WriteLine("Please press any key to continue");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("The current jackpot winning is $1,500,000,000.00!!!!\n");
                Console.WriteLine("{0} Are you ready to play LUCKY NUMBERS?\n", userName);
                Console.WriteLine("Please enter 'Yes', 'Quit' or 'Help' to end the game");
                resume = (Console.ReadLine().ToLower());
                Console.Clear();

                //Console is asking for user input to proceed into the game
                //The user has the options to proceed, quit or ask for help

                if (resume == "help")
                {
                    Console.WriteLine("Here is an example,\n \n{0} if you guess three out of six numbers correctly \nthen you'll get three sixths or half the amount of winnings!\n", userName);
                    Console.WriteLine("If the winning was $1000.00, you'll recieve $500.00.! \n{0} you only need LUCKY NUMBER IS NEEDED TO WIN!\n", userName);
                    Console.WriteLine("Please press any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("{0} Are you ready to play LUCKY NUMBERS?\n", userName);
                    Console.WriteLine("Please enter 'Yes' or 'Quit' to end the game\n");
                    resume = (Console.ReadLine().ToLower());
                    Console.Clear();
                }
                else if (resume == "quit")
                {
                    playAgain = false;
                    return;
                }


                if (resume == "quit")
                {
                    playAgain = false;
                    return;
                }
                
                //The user is now asked for the starting number
               Console.WriteLine("{0}, Please enter a starting number.\nThis is your lowest number in your range.", userName);
               lowUserNumS = Console.ReadLine();
               int.TryParse(lowUserNumS, out lowUserNumI);

                    //if the starting number,(string) isnt able to be properly converted(into an int) to be stored for later...
                    //then the console will ask for a number in the loop
                    
                        while (int.TryParse(lowUserNumS, out lowUserNumI) != true)
                        {
                            Console.WriteLine("You have entered an invalid entry, please enter a number");
                            lowUserNumS = Console.ReadLine();
                            int.TryParse(lowUserNumS, out lowUserNumI);
                        }
                        
                    //the console ask for input and try the input before attempting to store it for later use
                    Console.WriteLine("Please enter an ending number. \nThis is the highest number in your range.");
                    highUserNumS = Console.ReadLine();
                    int.TryParse(highUserNumS, out highUserNumI);

                    //console checks to the user input and test it to make sure the input is a value
                    //if not the console prompts the user for a proper entry until the user enters a value
                    
                    while (int.TryParse(highUserNumS, out highUserNumI) != true)
                    {
                        Console.WriteLine("please enter a number");
                        highUserNumS = Console.ReadLine();
                        int.TryParse(highUserNumS, out highUserNumI);
                    }
                    //console checks to see if the user input ending number is the same as the starting number 
                    //if it is the loop prompts to user to change the input to another number 
                    //console also checks to make sure the user enters a number not characters

                    while (highUserNumS == lowUserNumS)
                    {
                        Console.WriteLine("you have duplicate numbers, please enter a different number than number: {0}", lowUserNumS);
                        highUserNumS = Console.ReadLine();
                        int.TryParse(highUserNumS, out highUserNumI);
                    }                 
                    
                    userLuckyNumA[0] = lowUserNumI;
                    userLuckyNumA[5] = highUserNumI;
                
                
                Console.WriteLine("Great! {0}, {1} is the lowest and {2} is the highest number in your range.\n",userName,lowUserNumS,highUserNumS);
                Console.Clear();
                
                Console.WriteLine("Please enter 4 numbers that you think are the LUCKY NUMBERS\n",userName);
                   
                    //this loop will store the 6 numbers the user enters
                    for (int i = 1; i < 5 ; i++)
                    {                        
                        Console.WriteLine("Please enter another lucky number");
                        userLuckyNumS = Console.ReadLine();
                        int.TryParse(userLuckyNumS, out userLuckyNumI);
                        
                        //if the user enters a character that isnt a value the user will be asked for another input of an actual number
                        while ((int.TryParse(userLuckyNumS, out userLuckyNumI) != true) || ( testNum == userLuckyNumS) || (userLuckyNumA.Contains(userLuckyNumI) == true))
                        {
                            Console.WriteLine("Sorry, that entry was invalid entry. Please enter a number");
                            userLuckyNumS = Console.ReadLine();
                            int.TryParse(userLuckyNumS, out userLuckyNumI);
                        }
                        //this loop will check to see if the user input a number the same as the high or low starting numbers
                        while ((userLuckyNumI <= lowUserNumI)||(userLuckyNumI >= highUserNumI))
                        {
                            Console.WriteLine("Please enter an number other than your lowest {0} and highest {1} range numbers", lowUserNumS, highUserNumS);
                            userLuckyNumS = Console.ReadLine();
                            int.TryParse(userLuckyNumS, out userLuckyNumI);
                        }
                        testNum = userLuckyNumS;
                       userLuckyNumA[i] = int.Parse(userLuckyNumS);
                    }
                    Console.WriteLine("You've entered your numbers lets continue!");
                    Console.ReadKey();
                    Console.Clear();
                    
                

                Console.WriteLine("Now lets see what the actual numbers are to win that Jackpot!");
                Console.WriteLine("Please press any key to continue");
                Console.ReadKey();
                

                //the console will begin to print the lucky numbers                               
                for (int i = 0; i < jackpotRandomNum.Length; i++)
                {
                    testNumb = jackpotRandom.Next(lowUserNumI, highUserNumI);
                    while ((jackpotRandomNum.Contains(testNumb) == true) || (testNumb < lowUserNumI) ||( testNumb > highUserNumI))
                    {
                        testNumb = jackpotRandom.Next(lowUserNumI, highUserNumI);
                    }

                    jackpotRandomNum[i] = testNumb;

                    for (int j = 0; j < 1; j++)
                    {
                        if (userLuckyNumA.Contains(testNumb) == true)
                        {
                            matches++;
                            Console.WriteLine("Lucky Number:" + testNumb);
                        }
                    }
                }
                //the console will check if the user stored variables are equal to the jackpot variables 
                //the console will increase the int 'matches'  
                //if matches is greated then 0 the console will show the user their winning
                if (matches > 0)
                {                    
                    Console.WriteLine("You have guessed {0} out of 6 numbers correctly!", matches);
                    jackpot = (jackpot *(matches/6 ));
                    winnings = Convert.ToString(jackpot);
                    Console.WriteLine("Congradulations your win ${0}", winnings);
                }
                else if (matches < 0)
                {                    
                    Console.WriteLine(" You have guessed 0 out of 6 numbers correctly!");
                    Console.WriteLine(" Congradulations your win $0.00, sorry try again");
                }
                
                //the console will ask the user to play again
                Console.WriteLine("would you like to play again? Please enter 'Yes' to play again or 'Quit' to exit");
                resume = (Console.ReadLine().ToLower());

                if(resume == "yes")
                {
                    playAgain = true;
                }
                else if(resume == "quit")
                {
                    Console.WriteLine("Thanks for playing!");
                    playAgain = false;
                }
            } while (playAgain == true);                                                                                   
        }
    }
}
