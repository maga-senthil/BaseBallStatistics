using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class CreateArray
    {
        string[] playerName = new string[] { "Braun", "Villar", "Lucroy", "Perez", "Hill" };
        double[] scoreOne = new double[] { 113, 17, 2, 19, 350 };
        double[] scoreTwo = new double[] { 123, 28, 2, 9, 407 };
        double[] scoreThree = new double[] { 48, 101, 17, 3, 338 };
        double[] scoreFour = new double[] { 29, 63, 9, 1, 222 };
        double[] scoreFive = new double[] { 34, 72, 11, 0, 222 };
        double[][] scores;
        double result;
        public CreateArray()
        {
            scores = new double[][] { scoreOne, scoreTwo, scoreThree, scoreFour, scoreFive };
        }
        public void displayName()

        {
            for (int i = 0; i < playerName.Length; i++)
            {
                Console.WriteLine("player name is {0}", playerName[i]);

                for (int j = 0; j < scores.Length; j++)
                {

                    if (i == j)
                    {
                        calSluggPer(scores[j]);
                    }
                }
            }
           
    
        }

        public void calSluggPer(double[] score)
        {

            result = (score[0] + (2 * score[1]) + (3 * score[2]) + (4 * score[3])) / score[4];

            Console.WriteLine("players slugging percentage :{0}",result);

        }

    }
}