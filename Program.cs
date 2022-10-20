
Console.Clear();

string? playAgain = "yes";
while (playAgain == "yes")
{

    string? input;

    Console.WriteLine("Enter anything to reverse it:");
    input = Console.ReadLine();


    char[] reverseArray = input.ToCharArray();

    Array.Reverse(reverseArray);

    string revInput = new string(reverseArray);
 
    Console.WriteLine(revInput);
   
    string? answer = "";
    while (answer != "yes" && answer != "no")
    {
        Console.WriteLine("Would you like to play again? (yes or no)");
        answer = Console.ReadLine();
        answer = answer.ToLower();
        if (answer == "yes")
        {
            playAgain = answer;
        }
        else if (answer == "no")
        {
            playAgain = answer;
        }
        else
        {
            Console.WriteLine("Invalid Answer");
        }

    }


}


