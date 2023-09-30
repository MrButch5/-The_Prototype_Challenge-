//Creating while true statment to keep running

while (true)
{
    //Printing a message to the console for them to respond with a number between 0 - 100
    Console.Write("Site Director. How many CI are raiding. Respond with a number between 0 and 100 ");
    //Getting the users input from a string and converting it into a integer
    int directorInput = Convert.ToInt32(Console.ReadLine());
    //if directorInput is greater than 100 or less than 0 then write to console choose a proper number
    if (directorInput > 100 || directorInput < 0)
    {
        Console.WriteLine("Site Director. Choose a proper number.");
        //continue program to get a actual number
        continue;
    }
    //Clear console once proper number is chosen
    Console.Clear();
    //Write a prompt for the user asking them to make a guess
    Console.Write("Assistant Director, Guess the Site Directors number of how many CI are raiding ");
    //get the users input and conver the string into an integer
    int assistantDirectorGuess = Convert.ToInt32(Console.ReadLine());
    //if the assistantDirectorGuess is equal to directorInput then
    //write message to Console Good work assistant director
    if (assistantDirectorGuess == directorInput)
    {
        Console.WriteLine("Good work Assistant Director ");
        //once proper conditions have been met break;
        //aka stop the program
        break;
    }
    //if they guess wrong tell the user they are wrong and to fix it, continue the program
    else
        Console.WriteLine("Wrong choice assistant director...fix it. ");
    continue;
}