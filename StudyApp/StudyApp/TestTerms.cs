/*
 * Mohammed Kamal 
 * Used Progammingisfun.com
 * 11/3/2020
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;

namespace StudyAppWithData
{
    class TestTerms
    {
       
        public int score = 0;
        public int total = 15;

        public void askQuestions()
        {
            
            string termfile = "Terms.txt";

            string[] terms = File.ReadAllLines(termfile);


            string definitionsfile = "Definitions.txt";

            string[] Definitions = File.ReadAllLines(definitionsfile);




            Random random = new Random();
            int randomindex;

            string answer = "";

                for (int i = 0; i < Definitions.Length; i++)
                {

                    Clear();
                    WriteLine($"Write the term for: ");
                    randomindex = random.Next(0, Definitions.Length);
                    
                    
                    WriteLine(Definitions[randomindex]);

                    answer = ReadLine();

                

                    if (answer.ToLower() == terms[randomindex])
                    {
                        ForegroundColor = ConsoleColor.Blue;
                        WriteLine("Correct!");

                        ResetColor();

                        score++;
                        ReadKey();
                    }

                    else
                    {
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine($"Nope! It's actually {terms[randomindex]}.");

                        ResetColor();

                        ReadKey();
                    }
                    Clear();
                }
            


            
        }
       
    }
}
