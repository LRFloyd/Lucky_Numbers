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

                
            } while (playAgain == true);                                                                                   
        }
    }
}
