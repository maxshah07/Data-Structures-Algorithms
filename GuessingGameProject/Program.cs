using GuessingGameProject;

//Note be careful of issues with computer numbers, especially with integer division
//Console.WriteLine(9 / 10);
//Console.WriteLine((decimal)9 / 10);

//SecretNumber secretNumber = new SecretNumber(0, 10);
//int guess = AlgorithmA.Guess(secretNumber, printTrace: true);

//if (guess == secretNumber.CheckSecretNumber)
//{
//    Console.WriteLine($"Congratulations! You guessed the secret number {guess} in {secretNumber.NumGuesses} guesses.");
//}
//else
//{
//    Console.WriteLine($"Sorry, you did not guess the secret number. The secret number was {secretNumber.CheckSecretNumber}.");
//}

int repetitions = 20;
int[] problemSizes = new int[] { 10, 100, 1_000, 10_000, 100_000, 1_000_000, 1_000_000_000 };

List<int> guessesRequired;

Console.WriteLine("Testing AlgorithmB\n");

foreach (int size in problemSizes)
{
    guessesRequired = new List<int>();

    for (int i = 0; i < repetitions; i++)
    {
        SecretNumber sn = new SecretNumber(0, size);
        int g = AlgorithmB.Guess(sn);

        if (g != sn.CheckSecretNumber)
        {
            throw new ApplicationException($"AlgorithmA failed to guess the secret number for problem size {size}.");
        }

        guessesRequired.Add(sn.NumGuesses);
    }

    Console.WriteLine($"Problem size: {size}, Mean (Average) Num Guesses: {guessesRequired.Average()}");
}

Console.WriteLine("\nTesting AlgorithmA\n");

foreach (int size in problemSizes)
{
    guessesRequired = new List<int>();

    for (int i = 0; i < repetitions; i++)
    {
        SecretNumber sn = new SecretNumber(0, size);
        int g = AlgorithmA.Guess(sn);

        if (g != sn.CheckSecretNumber)
        {
            throw new ApplicationException($"AlgorithmA failed to guess the secret number for problem size {size}.");
        }

        guessesRequired.Add(sn.NumGuesses);
    }

    Console.WriteLine($"Problem size: {size}, Mean (Average) Num Guesses: {guessesRequired.Average()}");
}