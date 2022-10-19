/* Caroline Hana
10-19-2022
Reverse it Mini Challenge 7
Peer Review - 
*/

Console.Clear();

string? playAgain = "yes";
while (playAgain == "yes")
{

    string? input;
    int num;

    Console.WriteLine("Enter a number to reverse:");
    input = Console.ReadLine();

    bool validNum = Int32.TryParse(input, out num);

    char[] reverseArray = input.ToCharArray();

    Array.Reverse(reverseArray);

    string revInput = new string(reverseArray);
   if(!validNum)
   {
      Console.WriteLine("Invalid Number");
      playAgain = "yes";
   }else
   {
    Console.WriteLine(revInput);
   }

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


