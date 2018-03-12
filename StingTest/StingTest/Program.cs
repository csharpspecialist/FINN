using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = "00444855558361";
            string test2 = "0221985324";
            string test3 = "555372654";

            string answer = solution(words);
            string answer2 = solution(test2);
            string answer3 = solution(test3);


            Console.WriteLine(answer);
            Console.WriteLine(answer2);
            Console.WriteLine(answer3);
            Console.ReadLine();
            
        }

        public static string solution(string S)

        {
            double coder = Convert.ToDouble(S);                  

            string correctAnswer = String.Format("{0:000-000-000-000-00}", coder);       

            return correctAnswer;            
          
        }

    }
}
