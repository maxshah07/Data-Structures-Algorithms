using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGameProject
{
    public class AlgorithmB
    {
        public static int Guess(SecretNumber secretNumber, bool printTrace = false)
        {
            int low = secretNumber.Min;
            int high = secretNumber.Max - 1; //Max is exclusive

            while (low <= high)
            {
                int middle = (low + high) / 2;
                int guessResult = secretNumber.Guess(middle);

                if (guessResult == 0) { return middle; } //Found the secret number
                else if (guessResult < 0)
                {
                    //Guess is too low
                    low = middle + 1; //We can eliminate the middle number and all numbers below it

                }
                else if (guessResult > 0)
                {
                    //Guess is too high
                    high = middle - 1; //We can eliminate the middle number and all numbers above it
                }
            } 
            
            throw new ApplicationException("Secret number not found within the specified range.");
        }
    }
}
