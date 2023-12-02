using System;
using System.Collections.Generic;

namespace QuizGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Quiz Game!");

            // Define quiz questions and answers
            Dictionary<string, string> quiz = new Dictionary<string, string>
            {
                { "What is the capital of France?", "Paris" },
                { "Which planet is known as the Red Planet?", "Mars" },
                { "What is the largest mammal in the world?", "Blue Whale" }
            };

            int score = 0;

            // Iterate through quiz questions
            foreach (var question in quiz)
            {
                Console.WriteLine("\n" + question.Key);
                Console.Write("Your answer: ");
                string userAnswer = Console.ReadLine();

                // Check user's answer
                if (string.Equals(userAnswer, question.Value, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Correct!\n");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Incorrect. The correct answer is {question.Value}.\n");
                }
            }

            // Display final score
            Console.WriteLine($"Quiz completed! Your final score is: {score} out of {quiz.Count}");

            // Ask user if they want to play again
            Console.Write("Do you want to play again? (yes/no): ");
            string playAgain = Console.ReadLine();

            if (string.Equals(playAgain, "yes", StringComparison.OrdinalIgnoreCase))
            {
                Main(args); // Restart the game
            }
            else
            {
                Console.WriteLine("Thank you for playing!");
            }
        }
    }
}
