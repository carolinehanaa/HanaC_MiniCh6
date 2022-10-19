/* Caroline Hana
10-18-2022
Odd or Even
Mini Challenge 6
Peer Review- 
*/

Console.Clear();
string? playAgain = "yes";
while (playAgain == "yes")
{

    int number;

    Console.WriteLine("Enter a number I will tell you if its even or odd:");
    string? number1 = Console.ReadLine();

    bool validNum = Int32.TryParse(number1, out number);

    int remainder = number % 2;

    if (!validNum)
    {
        Console.WriteLine("Invalid Number");
        playAgain = "yes";
    }
    else if (remainder == 0)
    {
        Console.WriteLine("{0} is an even number", number);
    }
    else if (remainder == 1)
    {
        Console.WriteLine("{0} is an odd number", number);
    }

    string? answer = "";
    while (answer != "yes" && answer != "no")
    {
        Console.WriteLine("Would you like to play again? (yes or no)");
        answer = Console.ReadLine();
        answer = answer.ToLower();
             if(answer == "yes")
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