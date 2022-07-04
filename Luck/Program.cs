// See https://aka.ms/new-console-template for more information



Console.WriteLine("Welcome in Lucky Games!" +
    "\nPlease enter your Name:");
var userName = Console.ReadLine();
Console.WriteLine("Please enter your date of birth (Format : dd.mm.yyyy):");
var userDateOfBirth = Console.ReadLine();

if (!DateTime.TryParse(userDateOfBirth, out DateTime validDate))
{
    Console.WriteLine("You have insterted wrong data! Please enter correct date of birth!");
    userDateOfBirth = Console.ReadLine();
}


Console.WriteLine("Thank You! Now It's time to have some fun! Choose suitable number to play game! " +
    "\n1 - Lotto" +
    "\n2 - Lucky Date" +
    "\n3 - Lucky Day" +
    "\n4 - Lucky Number" +
    "\nIf you want to end the game press bye");

while (true)
{
    var userInput = Console.ReadLine();


    switch (userInput)
    {
        case "1":
            Luck.Lotto.drawNumbers();
            break;
        case "2":
            Luck.LuckyDate.drawLuckyDate();
            break;
        case "3" :
            Luck.LuckyDay.drawDay();
            break;
        case "4":
            Luck.LuckyNumber.drawLuckyNumber();
            break;
        case "N":
            Luck.LuckyDay.drawDay();
            break;
        case "bye":
            Console.WriteLine("Thank You for you're time!" +
                "\n Hope to see you soon! Bye!");
            break;
        default:
            Console.WriteLine("You haven't insert right number. Try again!");
            break;
    }
}

