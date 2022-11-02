using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaGame
{
    internal class Game
    {
        public string Name { get; set; }

        public Player GamePlayer { get; set; } = new Player();

        public List<TriviaQuestion> Questions { get; set; } = new List<TriviaQuestion>();

        public void Start()
        {
            Greeting();

            SetupQuestion();

            AskQuestions();

            End();
        }
        public void End()
        {
            Console.WriteLine($"{GamePlayer.Name}, out of {Questions.Count} questions you got {GamePlayer.Score} correct!");
        }


        public void SetupQuestion()
        {
            TriviaQuestion question1 = new TriviaQuestion()
            {
                Question = "What color is the sun?",
                Answer = "yellow" 
            };
            Questions.Add(question1);

            TriviaQuestion question2 = new TriviaQuestion()
            {
                Question = "What color is the grass?",
                Answer = "green"
            };
            Questions.Add(question2);

            TriviaQuestion question3 = new TriviaQuestion()
            {
                Question = "What color is the sky?",
                Answer = "blue"
            };
            Questions.Add(question3);

        }
        public void AskQuestions()
        {
            foreach (TriviaQuestion question in Questions)
            {
                Console.WriteLine(question.Question);

                string answer = Console.ReadLine();

                if (answer.ToLower() == question.Answer.ToLower())
                {
                    Console.WriteLine("you got it!");
                    GamePlayer.Score++;

                }
                else
                {
                    Console.WriteLine($"Sorry, that was not right. The correct answer was {question.Answer}!");
                }
            }



        }

        public void Greeting()
        {
            Console.WriteLine($"Welcome to the {Name}");

            GamePlayer = new Player();
            Console.WriteLine("What is your name?");

            string userInput = Console.ReadLine();

            GamePlayer.Name = userInput;
            //GamePlayer.Score = 0;

            Console.WriteLine($"Welcome {GamePlayer.Name}! You have {GamePlayer.Score} points.");

        }
    }
}
