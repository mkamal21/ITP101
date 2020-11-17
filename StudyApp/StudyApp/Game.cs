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
   
    class Game
    {

        Player player = new Player();
        TestTerms studyterms = new TestTerms();

        public string input = "";
        public string coolTitle;


        public Game()
        {
            Title = "Study Time: A Cool Study Application by Mohammed Kamal";
            Start();

        }

        public void Play()
        {

            Test();
            End();
        }

        public void Start()
        {
            coolTitle = @"
  _________ __            .___          _____                  
 /   _____//  |_ __ __  __| _/__.__.   /  _  \ ______ ______   
 \_____  \\   __\  |  \/ __ <   |  |  /  /_\  \\____ \\____ \  
 /        \|  | |  |  / /_/ |\___  | /    |    \  |_> >  |_> > 
/_______  /|__| |____/\____ |/ ____| \____|__  /   __/|   __/  
        \/                 \/\/              \/|__|   |__|     
                        ";
            WriteLine(coolTitle);
            WriteLine("Welcome to my study application! \nLet's start off with asking some stuff about yourself.");
            player.askPlayerinfo();
            WriteLine("-------------------------");
            WriteLine("Read the rules: \nThere will be a definition.\nYou will have to type out a word that matches that definition. " +
                "\nAll answers are singular form. \nYou'll get a point if you answer each correctly. If you answer something incorrect you dont get a point.");
            WriteLine("-------------------------");
            WriteLine("Press enter to continue..:)");
            ReadKey();

            Clear();

            WriteLine($"So {player.playerName}, are you ready for the hardest test in the world?");
            input = input.ToLower();
            input = ReadLine();


            if (input == "yes" || input == "y" || input == "yeah")
            {
                Play();
            }

            else
            {
                WriteLine("Woooow you're not ready come on, go back to studying.");
                ReadKey();
            }
        }

        public void Test()
        {
            studyterms.askQuestions();
            WriteLine($"Your current score is {studyterms.score} out of {studyterms.total}.");
        }

        public void End()
        {
            WriteLine($"Are you interested in playing again?");
            input = ReadLine();

            if (input.ToLower() == "yes" || input.ToLower() == "y" || input.ToLower() == "ye" | input.ToLower() == "yeah")
            {
                Play();
            }

            else
            {
                WriteLine("I hope you had fun studying!");
                ReadKey();
            }

        }


    }
}
