using System;

namespace EnthusiasticMoose
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();

            //Calls the moose function
            MooseSays("H I, I'M E N T H U S I A S T I C !");
            MooseSays("I really am enthusiastic");

            //Ask the question
            CanadaQuestion();
            EnthusiasticQuestion();
            LoveCSharpQuestion();
            SecretQuestion();
        }

        static void CanadaQuestion(){
            // As a question
            bool isTrue = MooseAsks("Is Canada real?");
            string CanadaResponse = isTrue ? ("Really? It seems very unlikely.") : ("I  K N E W  I T !!!");
            MooseSays(CanadaResponse);
            // if (isTrue)
            //     {
            //     MooseSays("Really? It seems very unlikely.");
            //     }
            //     else
            //     {
            //     MooseSays("I  K N E W  I T !!!");
            //     }
            }

        static void EnthusiasticQuestion(){
            bool isEnthusiastic = MooseAsks("Are you enthusiastic?");
            string EnthusiasticResponse = isEnthusiastic ? ("Yay!") : ("You should try it!");
            Console.WriteLine(EnthusiasticResponse);

            // if (isEnthusiastic)
            // {
            //     MooseSays("Yay!");
            // }
            // else
            // {
            //     MooseSays("You should try it!");
            // }
        }

        static void LoveCSharpQuestion(){
            // As a question
            bool doesLoveCSharp = MooseAsks("Do you love C# yet?");
            string loveResponse = doesLoveCSharp ? ("Good job sucking up to your instructor!") : ("You will...oh, yes, you will...");
            MooseSays(loveResponse);

            // if (doesLoveCSharp)
            // {
            //     MooseSays("Good job sucking up to your instructor!");
            // }
            // else
            // {
            //     MooseSays("You will...oh, yes, you will...");
            // }
        }

        static void SecretQuestion(){
            bool isEverythingFine = MooseAsks("Do you want to know a secret?");
            string isFineResponse = isEverythingFine ? ("ME TOO!!!! I love secrets...tell me one!") : ("Oh, no...secrets are the best, I love to share them!");
            MooseSays(isFineResponse);


            // if (isEverythingFine)
            // {
            //     MooseSays("ME TOO!!!! I love secrets...tell me one!");
            // }
            // else
            // {
            //     MooseSays("Oh, no...secrets are the best, I love to share them!");
            // }
        }

                static void MooseSays(string message)
                {
                    Console.WriteLine($@"
                                            _.--^^^--,
                                            .'          `\
        .-^^^^^^-.                      .'              |
        /          '.                   /            .-._/
        |             `.                |             |
        \              \          .-._ |          _   \
        `^^'-.         \_.-.     \   `          ( \__/
                |             )     '=.       .,   \
            /             (         \     /  \  /
            /`               `\        |   /    `'
            '..-`\        _.-. `\ _.__/   .=.
                |  _    / \  '.-`    `-.'  /
                \_/ |  |   './ _     _  \.'
                    '-'    | /       \ |
                            |  .-. .-.  |
                            \ / o| |o \ /
                            |   / \   |    {message}
                            / `^`   `^` \
                            /             \
                            | '._.'         \
                            |  /             |
                            \ |             |
                            ||    _    _   /
                            /|\  (_\  /_) /
                            \ \'._  ` '_.'
                            `^^` `^^^`
                    ");
                } 
                static bool MooseAsks(string question) {
                Console.Write($"{question} (Y/N): ");
                string answer = Console.ReadLine().ToLower();

                while (answer != "y" && answer != "n")
                {
                    Console.Write($"{question} (Y/N): ");
                    answer = Console.ReadLine().ToLower();
                }

                if (answer == "y")
                {
                    return true;
                }
                else
                {
                    return false;
                }
                }
    }

    
}