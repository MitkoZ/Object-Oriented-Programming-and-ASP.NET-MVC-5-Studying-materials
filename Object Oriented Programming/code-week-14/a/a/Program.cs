using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace a
{
    class Program
    {
        static List<string> questions = new List<string>() {
            "How to get food?",
            "Why are we here?",
            "Where do we go to lunch?"
        };
        static List<string> answers = new List<string>();

        static void DoTimeOut()
        {
            string answer = Console.ReadLine();
            answers.Add(answer);
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < questions.Count; i++)
            {
                Console.Clear();
                Console.WriteLine(questions[i]);

                Thread thread = new Thread(new ThreadStart(DoTimeOut));
                thread.Start();

                for (int k = 0; k < 5; k++)
                {
                    if (answers.Count > i)
                        break;

                    Thread.Sleep(1000);
                }

                if (answers.Count <= i)
                {
                    answers.Add("");
                    thread.Abort();
                }
            }

            for (int i = 0; i < answers.Count; i++)
            {
                Console.WriteLine(questions[i] + ":" + answers[i]);
            }

            Console.ReadKey(true);
        }
    }
}
