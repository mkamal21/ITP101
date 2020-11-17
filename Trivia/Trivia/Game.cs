using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Trivia
{
   
    class Game
    {
        string gameName = "Trivia Game by Mohammed Kamal";
        Player player;
        public Game()
        {
            player = new Player();

            Title = gameName;
            Console.Title = ("Welcome to" + gameName);
            WriteLine("Are you ready");
            WriteLine("Press any key to begin.");
            ReadKey();//wait for key press

            Clear();

            Play();
            ReadKey();
            Console.ReadLine();

        }

        private void Play()

        {



            string[] questions = { "Micheal Jordan has 6 rings. \r\nTrue or False?",
            "9+10 = 21. \r\nTrue or False?",

            "Kanye created Yeezy. \r\nTrue or False?",

            "Steve Jobs created apple \r\nTrue or False?",

            "Obama is our presidnet. \r\nTrue or False?",

            "What player is on the NBA logo? \r\na.Jerry West. \r\nb.Tom Cruise. \r\nc.Lil Wayne. \r\nd. All of the above.",
            "Where is Derrick Rose from? \r\na.New York. \r\nb.Nort Carolina. \r\nc.Chicago. \r\nd.LA.",

            "What company includes 3 stripes? \r\na.Nike. \r\nb.Puma. \r\nc.Adidas. \r\nd.New Balance",

            "What logo is on the back of Iphones. \r\na.Apple logo. \r\nb.Razor logo. \r\nc.Nokia Logo.",

            "What Number did Kobe Bryant wear on his jersey? \r\na.8. \r\nb.24. \r\nc.All of the above." };

            string[] answers = { "True", "False", "True", "True", "False", "a", "c", "c", "a", "c" };
            string studentAnswer;
            int correctAnswer = 0;
            int qcounter = 0;
            int questionNum = 0;
            int answerNum = 0;
            while (questionNum < questions.Length)
            {
                Console.WriteLine(questions[questionNum], 10, 30);
                studentAnswer = Console.ReadLine();
                if (studentAnswer == answers[answerNum])
                {
                    Console.WriteLine("Correct!");
                    questionNum++;
                    answerNum++;
                    correctAnswer++;
                    qcounter++;
                }
                else
                {
                    Console.WriteLine("Incorrect.");
                    questionNum++;
                    answerNum++;
                    qcounter++;
                }
                Console.WriteLine();
                Console.WriteLine("Press ENTER for Next question.");
                Console.ReadLine();
                Console.Clear();

            }
            WriteLine(player.name + ", Your final score is: " + correctAnswer + "/" + qcounter + ".");
            Console.WriteLine();
            Console.WriteLine("Press ENTER to EXIT");

            Console.ReadKey(true);
        }
    }
}

    