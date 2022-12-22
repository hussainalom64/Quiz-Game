using System;

namespace QuizGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Welcome message
            Console.WriteLine("Welcome to SimpleQuizzes.");
            Console.WriteLine("This is a multi-choice quesion game.");
            Console.WriteLine("To answer, input only, A, B, C, D.");
            Console.WriteLine("After each question, your score will be displayed.");
            Console.WriteLine("To start the game press any key.");
            Console.ReadKey();

            //Setup the questions
            string[][] questions =
            {
                //Format: question, answer, option A, B, C, D
                new string[]
                {
                    "What is the currency used in the UK?", "D", "Euros", "USD", "UKP", "Pounds"
                },
                new string[]
                {
                    "What is the capital of Japan?", "B", "Paris", "Tokyo", "Kyoto", "Tokhyo"
                },
                new string[]
                {
                    "What is the biggest planet in the solar system?", "A", "Jupiter", "Mars", "Earth", "Ju"
                },
                new string[]
                {
                    "What is the capital of Germany", "C", "Rome", "Munich", "Berlin", "Paris"
                }
            };

            //Keeping track of the players score
            int score = 0;

            //Ask the questions
            for(int i = 0; i < questions.Length; i++) 
            {
                //Get the question
                string[] question = questions[i];

                //Display the question
                //Reason why there is an empty WriteLine is so its better presented with spaces
                Console.WriteLine();
                Console.WriteLine(question[0]);
                Console.WriteLine("A. " + question[2]);
                Console.WriteLine("B. " + question[3]);
                Console.WriteLine("C. " + question[4]);
                Console.WriteLine("D. " + question[5]);

                //Prompt the user to enter their answer
                Console.WriteLine("Please enter your answer: ");
                string answer = Console.ReadLine().ToUpper();
                
                //Checking their answer
                if(answer == question[1])
                {
                    Console.WriteLine("Well done, you answered correctly!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Wrong answer, the correct answer is " + question[1]);
                }
                Console.WriteLine("Your current score is " + score + " / " + questions.Length);
            }

            //Final score
            Console.WriteLine();
            Console.WriteLine("Congratulations you have finished the quiz! Your final score is: " + score + " / " + questions.Length + ".");
        }
    }
}