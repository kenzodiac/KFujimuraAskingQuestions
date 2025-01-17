﻿//Kenneth Fujimura
//10-18-2022
//GitHub Challenge # 3 - Asking Questions
//Console program greets the user, asks the user two questions, stores those answers as strings, and then display the answers in a single sentence back to the user.
//Peer Review by: Everything worked I liked how I was able to put a very specific time like AM or PM. The code looked clean and was able to understand it the only critique I have for it is that I am able to type in anything for the time I woke up I think it would of been good if there was validation for it so that they are only able to type a number for the time also was when I push enter it also leaves the answers blank, other then that everything else looked good.

Console.Clear();

Console.WriteLine("Hello! I have some questions for you. Please indulge me.");

bool playAgain = true;

//play again while loop
while (playAgain == true) {
    //user inputs
    Console.Write("\nWhat is your name? Please enter on the keyboard and press enter when you are finished: ");
    string userName = Console.ReadLine();

    Console.Write("\nVery good. Now, please tell me what time you woke up today? ");
    string wakeUpTime = Console.ReadLine();

    //program output
    Console.WriteLine("\nSo you're telling me that your name is \"" + userName + "\", and that you woke up at \"" + wakeUpTime + "\"? Cool beans!");

    //play again prompt with input validation
    Console.Write("\nWould you like to answer my questions again? Y/N: ");
    bool answerCheck = true;
    while (answerCheck == true) {
        string playAgainInput = Console.ReadLine().ToLower();
        if (playAgainInput == "y" || playAgainInput == "yes") {
            answerCheck = false;
            continue;
        } else if (playAgainInput == "n" || playAgainInput == "no"){
            playAgain = false;
            answerCheck = false;
        } else {
            Console.Write("\nI do not understand. Please answer with 'Y' for yes, or 'N' for no: ");
            answerCheck = true;
        }
    }
}
Console.WriteLine("\nArigato!");