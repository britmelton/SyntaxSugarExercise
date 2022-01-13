using System;

namespace SyntaxSugarExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var answer = 4;
            var response = (answer < 9) ? answer + " is less than nine" : answer + " greater than or equal to nine";
           Console.Write(response); 

            var i = 1;
            var positiveMessage = (i > 0) ? "\nyou are positive" : "\nyour are not positive";
            Console.WriteLine(positiveMessage);

        }
    }
}
