using System;
using System.Text;


namespace hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Secret words
            string[] secretWords = { "gift", "towel", "soap", "monkey", "college", "basket", "latitude", "crow", "germ", "skeleton", "taxes", "energy", "electricity", "password", "competition", "thunder" };
            
            bool repeatGame = false;

            do
            {
                Console.Clear();
                Console.WriteLine("======= Welecome in Hangman game =======");
                Console.WriteLine();
                Console.WriteLine("gusse the word\n");

                Random random = new Random();

                int raIndex = random.Next(secretWords.Length);

                string secretWord = secretWords[raIndex];


                //Build secret word
                StringBuilder answerBuilder = new StringBuilder();

                for (int i = 0; i < secretWord.Length; i++)
                {
                    answerBuilder.Append('_');
                }

                bool isWin = false;

                Console.WriteLine(answerBuilder.ToString());
                Console.WriteLine();


                //Playe the game
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"Round {i}");
                    Console.WriteLine();
                    Console.WriteLine("Write a letter or your gusse word...");

                    string answer;

                    AnswerAndCheck(out answer, answerBuilder);


                    while (answer.Length == 1 && secretWord.Contains(answer) && !isWin)
                    {
                        for (int index = 0; index < secretWord.Length; index++)
                        {
                            if (secretWord[index] == answer[0]) answerBuilder[index] = answer[0];
                        }

                        //
                        if (!answerBuilder.ToString().Contains('_'))
                        {
                            isWin = true;
                            Win(secretWord);
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine(answerBuilder);
                            Console.WriteLine();
                            Console.WriteLine("good go on...");
                            AnswerAndCheck(out answer, answerBuilder);
                        }

                    }


                    if (answer.Length == 1 && !secretWord.Contains(answer))
                    {
                        Console.WriteLine();
                        Console.WriteLine("this is worng try another.......");
                        Console.WriteLine();
                    }




                    if (answer.Length > 1 && answer == secretWord)
                    {
                        isWin = true;
                        Win(secretWord);
                    }

                    if (isWin) break;
                }

                if (!isWin)
                {
                    Console.WriteLine("Sorry you loss .... ☹️☹️");
                    Console.WriteLine();
                    Console.WriteLine($"The secret word is: {secretWord}");
                    Console.WriteLine("Good luck later..... 🤷‍♂️");
                }


                Console.WriteLine();
                Console.WriteLine("Do you want to play agine (y / n)");

                char selected = Console.ReadKey(true).KeyChar;

                while (selected != 'y' && selected != 'n')
                {
                    Console.Beep();
                    Console.WriteLine("Sorry I didn't understant your answer just press (y) or (n)");
                    selected = Console.ReadKey(true).KeyChar;
                }

                switch (selected)
                {
                    case 'y':
                        repeatGame = true;
                        break;

                    case 'n':
                        Console.WriteLine();
                        Console.WriteLine("Thank for using Hngman game ...... GoodBye!");
                        repeatGame = false;
                        break;

                    default: Console.WriteLine("Worng answer....");
                        break;
                }



            } while (repeatGame);
        }

        static void AnswerAndCheck(out string answer,StringBuilder answerBuilder)
        {
            answer = Console.ReadLine()?.ToLower() ?? string.Empty;

            while (answer == string.Empty)
            {
                Alert("Sorry but you have to insert somting.....!");
                Console.WriteLine();
                Console.WriteLine("Write a letter or your gusse word...");
                answer = Console.ReadLine() ?? string.Empty;
            }

            while (answer.Length == 1 && answerBuilder.ToString().Contains(answer))
            {
                Alert("Sorry but this letter has already gussed .. try another..!");
                Console.WriteLine();
                Console.WriteLine("Write a letter or your gusse word...");
                answer = Console.ReadLine() ?? string.Empty;
            }
        }


        static void Alert(string message)
        {
            Console.Beep();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        static void Win(string word)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Great..... \n You win .. 🙂🎉");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine($"The secret word is: {word}");
        }

    }
}