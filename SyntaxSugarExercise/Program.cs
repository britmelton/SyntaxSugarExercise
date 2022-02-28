using System;

namespace SyntaxSugarExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Class Exercise Instructions
            //in class exercise 
            /*Given the following code, change the code to implement inferred typing, string interpolation, and the ternary operator.
            int answer = 4;
            string response;
            if (answer < 9) 
            {
                response = answer + " is less than nine";
            }
	        else
	        {
	            response = answer + “greater than or equal to nine”;
	        } */
            #endregion

            var answer = 4;
            var response = (answer < 9) ? answer + " is less than nine" : answer + " greater than or equal to nine";
           Console.Write(response); 

            //bonus practice 
            var i = 1;
            var positiveMessage = (i > 0) ? "\nyou are positive" : "\nyour are not positive";
            Console.WriteLine(positiveMessage);

        }
    }
}
