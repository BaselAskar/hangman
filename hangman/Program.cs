using System;
using System.Drawing;
using System.Formats.Asn1;
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
                //TimerWrite("************ Welcome in Hangman game ************");
                TimerWrite("************ ", 100);
                TimerWrite("Welcome in Hangman game");
                TimerWrite(" ************", 100);
                Console.WriteLine();
                PrintShape(Graphics.smileFace, ConsoleColor.Yellow);



                Console.WriteLine();
                TimerWrite("Enter your name: ", 200);

                string? myName = Console.ReadLine();

                while (string.IsNullOrEmpty(myName))
                {
                    Console.WriteLine("Sorry I didn't understand what's your name!");
                    Console.Write("Your Name: ");
                    myName = Console.ReadLine();
                }

                Console.Clear();

                //TimerWrite($"************ Welcome {myName} ************");
                TimerWrite("************ ", 100);
                TimerWrite($"Welcome {myName}");
                TimerWrite(" ************", 100);
                Console.WriteLine();
                TimerWrite("Let's Start");
                Thread.Sleep(3000);



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
                int round = 1;


                //Play the game
                do
                {
                    Console.Clear();
                    Console.WriteLine($"************ Welcome {myName} ************");
                    Console.WriteLine();
                    PrintShape(Graphics.gallows[round - 1]);
                    Console.WriteLine();
                    Console.Write("          ");
                    Console.WriteLine(answerBuilder.ToString());
                    Console.WriteLine();


                    Console.WriteLine($"Round {round} \n");
                    Console.WriteLine("Write a letter or your gusse word...");

                    string answer;

                    AnswerAndCheck(out answer, answerBuilder);

                    if (answer.Length == 1 && secretWord.Contains(answer))
                    {
                        for (int index = 0; index < secretWord.Length; index++)
                        {
                            if (secretWord[index] == answer[0])
                            {
                                answerBuilder[index] = answer[0];
                            }

                            if (!answerBuilder.ToString().Contains('_'))
                            {
                                isWin = true;
                            }
                        }

                        continue;
                    }
                    else if (answer.Length > 1 && secretWord == answer)
                    {
                        isWin = true;
                    }


                    round++;


                } while (round <= 10 && !isWin);


                Console.Clear();

                if (isWin)
                {
                    Console.WriteLine($"************ Welcome {myName} ************");
                    Console.WriteLine("\r");
                    PrintShape(Graphics.headrt, ConsoleColor.Red);
                    Console.WriteLine();
                    Win(secretWord);
                }
                else
                {
                    Console.WriteLine($"************ Welcome {myName} ************");
                    Console.WriteLine("\r");
                    PrintShape(Graphics.gallows[10]);
                    Console.WriteLine();
                    PrintShape(Graphics.sadFace,ConsoleColor.Yellow);
                    Console.WriteLine();
                    Console.WriteLine($"The secret word is {secretWord}");
                    Console.WriteLine("Goodluck....");
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

                    default:
                        Console.WriteLine("Worng answer....");
                        break;
                }


            } while (repeatGame);
        }

        static void AnswerAndCheck(out string answer, StringBuilder answerBuilder)
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

        static void TimerWrite(string message,int millisecondTimeout = 250)
        {
            foreach(char letter in message)
            {
                Thread.Sleep(millisecondTimeout);
                Console.Write(letter);
            }
        }

        static void PrintShape(string[] shape, ConsoleColor lineColor = ConsoleColor.White)
        {
            Console.ForegroundColor = lineColor;
            foreach(string line in shape)
            {
                Console.WriteLine(line);
            }
            Console.ResetColor();
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
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Great..... \n You win .. 🙂🎉");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine($"The secret word is: {word}");
        }

    }
}