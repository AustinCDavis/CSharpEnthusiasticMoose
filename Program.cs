using System;

Main();

void Main()
{
    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();

    // Let the moose speak!
    MooseSays("H I, I'M  E N T H U S I A S T I C !");
    MooseSays("I really am enthusiastic");

    // As a question
    CanadaQuestion();
    EnthusiasticQuestion();
    CSharpChallengeQuestion();
    SecretQuestion();
}

bool MooseAsks(string question)
{
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

void AskQuestion(string question, string yResponse, string nResponse)
{
    bool isTrue = MooseAsks(question);

    string response = isTrue ? yResponse : nResponse;
    MooseSays(response);
}


void MooseSays( string message)
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

//List of questions function
//calling Ask question function with ternary format of (question, yresponse, nresponse)
void CanadaQuestion()
{
    AskQuestion("Is Canada real?", "Really? It seems very unlikely.", "I  K N E W  I T !!!");
}

void EnthusiasticQuestion()
{
    AskQuestion("Are you enthusiastic?", "Yay!", "You should try it!");
}

void CSharpChallengeQuestion()
{
    AskQuestion("Do you think C# is a challenge?", "Good job sucking up to your instructor!", "You will...oh, yes, you will...");
}

void SecretQuestion()
{
    AskQuestion("Do you want to know a secret?", "ME TOO!!!! I love secrets...tell me one!", "Oh, no...secrets are the best, I love to share them!");
}