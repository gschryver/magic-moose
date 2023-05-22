using System;

Main();

void Main()
{
    Console.WriteLine("Welcome to the Magic Moose 8-Ball Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();

    while (true) // will run until user hits enter or does not provide input 
    {
        MooseSays("What is your question?");
        string question = Console.ReadLine();

        if (question.Length == 0) // if question is empty, break out of loop
        {
            break;
        }

        // RESPONSES
        // One approach is to use a switch statement
        // Another approach is to use an array of strings
        // A third approach is to use a list of strings
        // We're going to use an array of strings

        Random random = new Random();
        string[] responses =
        {
            "As I see it, yes.",
            "Ask again later.",
            "Better not tell you now.",
            "Cannot predict now.",
            "Concentrate and ask again.",
            "Don't count on it.",
            "It is certain.",
            "It is decidedly so.",
            "Most likely.",
            "My reply is no.",
            "My sources say no.",
            "Outlook not so good.",
            "Outlook good.",
            "Reply hazy, try again.",
            "Signs point to yes.",
            "Very doubtful.",
            "Yes.",
            "Without a doubt.",
            "Yes - definitely.",
            "You may rely on it."
        };
        int randomNumber = random.Next(0, responses.Length); // Next() generates a random number between two numbers (0 and responses.length). We use the length of the array as the max number.
        string response = responses[randomNumber];
        MooseSays(response); // moose ascii art will include the response
    
    }
}

void MooseSays(string message)
{
    Console.WriteLine(
        $@"
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
          \_/ |  |   './  ( 8 )  \.'
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
    "
    );
}
