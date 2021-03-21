using System;
using System.Collections.Generic;
using System.Linq;

namespace Collections_MinMaxAvgMode
{
    class Program
    {

        // Ask the user to enter all of their exam grades.  Once they are done, calculate the minimum score, 
        // the maximum score, the mode score and the average score for all of their scores.  
        //Perform this using at least 2 Loops (can be the same type of loop) and not any built in functions.
        static void Main(string[] args)
        {
            List<int> examscores = new List<int>();

            string score1;
            int score;
            do
            {
                Console.WriteLine("Enter your exam grade");
                score1 = Console.ReadLine();
                score = Convert.ToInt32(score1);

                examscores.Add(score);

                Console.WriteLine("Do you have another exam score to add? >>");
                score1 = Console.ReadLine();

            } while (score1.ToLower()[0] == 'y');

            int i, max, min, n;

            // max and min
            n = examscores.Count;

            max = examscores[0];
            min = examscores[0];

            for (i = 1; i < n; i++)
            {
                if (examscores[i] > max)
                {
                    max = examscores[i];
                }
                if (examscores[i] < min)
                {
                    min = examscores[i];
                }
            }
            Console.Write("Maximum exam score = {0}\n", max);
            Console.Write("Minimum exam score = {0}\n\n", min);


            // average 
            int sumscores = 0;

            for (i = 0; i < n; i++)
            {
                sumscores = sumscores + examscores[i];
            }

            int avg;

            avg = sumscores / n;

            Console.WriteLine("Average exam score = {0}\n", avg);

            // mode

            Dictionary<int, int> counts = new Dictionary<int, int>();
            foreach (int a in examscores)
            {
                if (counts.ContainsKey(a))
                    counts[a] = counts[a] + 1;
                else
                    counts[a] = 1;
            }

            int result = int.MinValue;
            int maxvalue = int.MinValue;
            foreach (int key in counts.Keys)
            {
                if (counts[key] > maxvalue)
                {
                    maxvalue = counts[key];
                    result = key;
                }
            }

            Console.WriteLine("The exam mode score = {0}\n ", result);

        }
    }
}