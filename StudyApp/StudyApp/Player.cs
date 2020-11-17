/*
 * Mohammed Kamal 
 * Used Progammingisfun.com
 * 11/3/2020
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace StudyAppWithData
{
    class Player
    {
        public string playerName = "";
        public string playerAge = "";
        public string playerColor = "";


        public void askPlayerinfo()
        {
            WriteLine("What is your name?");
            playerName = ReadLine();

            WriteLine("How old are you?");
            playerAge = ReadLine();

            WriteLine("What is your favorite color?");
            playerColor = ReadLine();

            WriteLine($"Great! Your name is {playerName}, you are {playerAge} year(s) old, and your favorite color is {playerColor}.");
        }
    }
}
