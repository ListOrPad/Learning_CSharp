using System;

namespace СSharp_Player_s_Guide_Book
{
    internal class Program
    {
        /// <summary>
        /// Input function like in Python: You enter text in paranthesis
        /// Then a variable you assign with this method, stores any input as string
        /// </summary>
        static string Input(string text)
        {
            Console.Write(text);

            string input = Console.ReadLine();

            return input;
        }

        static void Main(string[] args)
        {
            ////Consolas and Telim exercise.
            //Console.WriteLine("Bread is ready.");
            //Console.WriteLine("Who is the bread for?");
            //string whoGotBread = Console.ReadLine();
            //Console.WriteLine("Noted: " + whoGotBread + " got bread.");


            //// Comment-3000
            //Console.WriteLine("What kind of thing are we talking about?");
            ////a and b variables store user input
            //string a = Console.ReadLine();
            //Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
            //string b = Console.ReadLine();
            //Console.WriteLine("The " + b + " " + a + " of Doom 3000!");


            ////The Triangle farmer math challenge
            //Console.WriteLine("The triangle base is:");
            //double triangleBase = Convert.ToDouble(Console.ReadLine()); //Input base
            //Console.WriteLine("The triangle height is:");
            //double triangleHeight = Convert.ToDouble(Console.ReadLine()); //Input height
            ////Counts and displays the triangle area size
            //double area = triangleBase * triangleHeight / 2;
            //Console.WriteLine("The triangle area is: " + area);


            ////The four sisters and the duckbear challenge
            //Console.WriteLine("How many eggs were gathered today?");
            //int eggsGathered = Convert.ToInt32(Console.ReadLine());
            ////how many eggs will each sister get
            //int eachSisterGets = eggsGathered / 4;
            //Console.WriteLine("Today each sister gets " + eachSisterGets + " chocolate eggs");
            ////how many eggs will duckbear get
            //int duckBearGets = eggsGathered % 4;
            //Console.WriteLine("then duckbear will get " + duckBearGets + " chocolate eggs");


            ////The Dominion of Kings challenge
            ////Collecting data of how much estates, duches and provinces does user have
            //Console.WriteLine("How many estates do you have?");
            //int estates = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("How many duches do you have?");
            //int duches = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("How many provinces  do you have?");
            //int provinces = Convert.ToInt32(Console.ReadLine());
            ////converting data to score
            //estates *= 1;
            //duches *= 3;
            //provinces *= 6;
            //int score = estates + duches + provinces;
            //Console.WriteLine("Your total score is: " + score);


            //// how does x++ and ++x works? exp 1
            //int x;
            //x = 5;
            //int y = ++x;
            //Console.WriteLine(y);
            //x = 5;
            //int z = x++;
            //Console.WriteLine(z);
            //Console.WriteLine(x);


            ////exp 2, Press any key to continue
            //Console.WriteLine("Press any key to continue");
            //Console.ReadKey(true);


            //exp 3 , adjusting your console

            Console.Clear();
            Console.Title = "c# player guide";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Press any key to start");
            Console.ReadKey(true);


            ////exp 4 , if you want to add " or other special symbol that compiles differently
            //Console.WriteLine("This is how we type \"quotation marks\"");        //you can use "\" at the beginning
            ////Or you can use @ if you want to instruct the compiler to treat everything exactly as it looks
            ////For some reason doesn't work with "
            //Console.WriteLine(@"another way to type \ ");
            ////There are also \n, \r and \t escape sequences for strings
            //Console.WriteLine("\ttab \nnew line \n\rgo back to the start of the line");


            ////exp 5 , string interpolation
            //int x = 5;
            //Console.WriteLine($"I'd like to have {x} eggs");


            ////exp 6 Allignment, adding blank space before and after text using string interpolation
            //Console.WriteLine("input 1:");
            //string thing1 = Console.ReadLine();
            //Console.WriteLine($"#1 {thing1, 20}");
            //Console.WriteLine("input 2:");
            //string thing2 = Console.ReadLine();
            //Console.WriteLine($"{thing2, -20} #2");

            ////Formating using string interpolation
            ////Everything going after : is a format
            //Console.WriteLine($"{Math.PI:0.000}");  //cuts the amount of decimal numbers to three after a comma
            //Console.WriteLine($"{Math.PI:#.##}"); //Better to use ## than 00
            ////how to show current health in %:
            //float maxHealth = 100;
            //float currentHealth = 37.2f;
            //Console.WriteLine($"{currentHealth/maxHealth:#.##%}");
            ////you also can use P1 - P10(percents) or F - F10(format) after format sign (:)
            //currentHealth = 37.23f;
            //Console.WriteLine($"{currentHealth/maxHealth:P4}"); //shows 4 digits after a dot in percents



            ////The Defense of Consolas challenge ⚔️⚔️⚔️

            ////Getting info about Uncoded One forces target
            //Console.Write("Target Row? ");
            //int targetRow = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Target Column? ");
            //int targetColumn = Convert.ToInt32(Console.ReadLine());

            ////Defining where to place our defenders to block the attack
            //Console.WriteLine("Deploy to:");
            //Console.WriteLine($"({targetRow}, {targetColumn - 1})");
            //Console.WriteLine($"({targetRow - 1}, {targetColumn})");
            //Console.WriteLine($"({targetRow}, {targetColumn + 1})");
            //Console.WriteLine($"({targetRow + 1}, {targetColumn})");

            //Console.Beep();



            ////exp 7 if statements p1
            //int score = Convert.ToInt32(Console.ReadLine());
            //char grade = '?';
            //if (score == 100)
            //{
            //    grade = 'S';
            //}
            //Console.WriteLine(grade);



            ////exp 8, counting grades
            //Console.WriteLine("Enter your score");
            //int score = Convert.ToInt32(Console.ReadLine());
            //if (score >= 90)
            //{ Console.WriteLine("Perfect! (A)"); }
            //else if (score >= 80)
            //{ Console.WriteLine("Good! (B)"); }
            //else if (score >= 70)
            //{ Console.WriteLine("Try harder! (C)"); }
            //else if (score >= 60)
            //{ Console.WriteLine("You could do better. (C)"); }
            //else
            //    Console.WriteLine("Awful (F)");



            ////Repair the Clocktower challenge
            //Console.WriteLine("Enter your time, seconds");
            //int number = Convert.ToInt32(Console.ReadLine());

            //if (number % 2 == 0)             //IF YOU PRESS TAB AFTER IF OR ELSE IT AUTOMATICALLY TYPES IN CURLY BRACKETS
            //    Console.WriteLine("Tick");
            //else                             //Or        else (number % 2 == 0)
            //    Console.WriteLine("Tock");



            ////exp 9, and == &&;     or == ||
            //int shields = 35;
            //int armor = 80;

            //if (shields > 0 || armor > 0)
            //    Console.WriteLine("You're alive, slash some mobs");



            ////exp 10, nested if statements
            //int shields = 35;
            //int armor = 80;
            //if (shields <= 0)
            //{
            //    if (armor >= 0)
            //        Console.WriteLine("Shields are gone but you still have armor");
            //    else
            //        Console.WriteLine("Armor and shields are gone, you're dead");
            //}
            //else
            //{
            //    Console.WriteLine("Shields are up, no worries");
            //}



            //// The Watchtower challenge
            //Console.WriteLine("Mark the x coordinate");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Mark the y coordinate");
            //int y = Convert.ToInt32(Console.ReadLine());

            ////if on the west
            //if (x < 0)
            //{
            //    if (y > 0)
            //        Console.WriteLine("The enemy is to the north-west!");
            //    if (y == 0)
            //        Console.WriteLine("The enemy is to the west!");
            //    if (y < 0)
            //        Console.WriteLine("The enemy is to the south-west!");
            //}
            ////if on the middle
            //if (x == 0)
            //{
            //    if (y > 0)
            //        Console.WriteLine("The enemy is to the north!");
            //    if (y == 0)
            //        Console.WriteLine("The enemy is HERE!");
            //    if (y < 0)
            //        Console.WriteLine("The enemy is to the south!");
            //}
            ////if on the east
            //if (x > 0)
            //{
            //    if (y > 0)
            //        Console.WriteLine("The enemy is to the north-east!");
            //    if (y == 0)
            //        Console.WriteLine("The enemy is to the east!");
            //    if (y < 0)
            //        Console.WriteLine("The enemy is to the south-east!");
            //}



            ////exp 11 switch statement
            //Console.WriteLine("Pick a choice (1-4)");
            //int choice = Convert.ToInt32(Console.ReadLine());

            //switch (choice)
            //{
            //    case 1:
            //        Console.WriteLine("Your first choice");
            //        break;
            //    case 2:
            //        Console.WriteLine("The second choice");
            //        break ;
            //    case 3:
            //        Console.WriteLine("this is your third choice");
            //        break;
            //    case 4:
            //        Console.WriteLine("Your last variant");
            //        break;
            //    default:
            //        Console.WriteLine("This is not something you can choose, try the other key(number 1-4)");
            //        break;
            //}


            ////exp 12 switch expression
            //Console.WriteLine("Pick a choice (1-4)");
            //int choiceNumber = Convert.ToInt32(Console.ReadLine()); //input choice variant

            //string choice;
            //choice = choiceNumber switch
            //{
            //    1 => "Your first choice",
            //    2 => "The second choice",
            //    3 => "This is your third choice",
            //    4 => "Your last variant",
            //    _ => "You can't choose this. Try the other key(1-4)"
            //};
            //Console.WriteLine(choice);



            ////Buying inventory challenge 💰💰💰 (With a discount :] )

            ////Find out the buyers name
            //Console.WriteLine("- What is your name?");
            //Console.Write("- My name is ");
            //string customerName = Console.ReadLine();

            ////Making a list of items available and assigning index to them
            //if (customerName == "ListOrPad")
            //    Console.WriteLine("Oh, it's you, my friend... what would you like?");
            //else
            //    Console.WriteLine($"Alright, {customerName}, The following items are available:");
            //Console.WriteLine("1 - Rope");
            //Console.WriteLine("2 - Torches");
            //Console.WriteLine("3 - Climbing Equipment");
            //Console.WriteLine("4 - Clean Water");
            //Console.WriteLine("5 - Machete");
            //Console.WriteLine("6 - Canoe");
            //Console.WriteLine("7 - Food Supplies");

            ////Choose which item you want to buy, input index
            //Console.Write("What number do you want to see the price of? ");
            //int itemIndex = Convert.ToInt32(Console.ReadLine());

            ////converting item index to item name
            //string itemName;
            //itemName = itemIndex switch
            //{
            //    1 => "Rope",
            //    2 => "Torches",
            //    3 => "Climbing equipment",
            //    4 => "Clean Water",
            //    5 => "Machete",
            //    6 => "Canoe",
            //    7 => "Food Supplies",
            //    _ => "No such a thing"
            //};

            ////defining how much you have to pay for certain item
            //float price;
            //price = itemName switch
            //{
            //    "Rope" => 10,
            //    "Torches" => 15,
            //    "Climbing Equipment" => 25,
            //    "Clean Water" => 1,
            //    "Machete" => 30,
            //    "Canoe" => 200,
            //    "Food Supplies" => 2,
            //    "No such a thing" => 0
            //};

            ////Is there a discount? Tell the final price for an item
            //if (customerName == "ListOrPad" && itemName != "No such a thing")
            //{
            //    price /= 2;
            //    Console.WriteLine($"The price for {itemName} is {price} gold. There is a discount for friends!");
            //}
            //else if (itemName == "No such a thing")
            //{
            //    Console.WriteLine("There is no such a thing");
            //}
            //else
            //{
            //    Console.WriteLine($"The price for {itemName} is {price} gold");
            //}



            ////exp 13 simplest while loop, assigning a number to a player

            //int playerNum = -1;

            //while (playerNum < 0 || playerNum > 10)
            //{
            //    Console.WriteLine("Say the number between 0 and 10");
            //    string guyTellNum = Console.ReadLine();
            //    playerNum = Convert.ToInt32(guyTellNum);
            //}
            //Console.WriteLine($"The players number is {playerNum}");

            ////do... while loop variant

            //int playerNum;    //don't forget to declare a variable before code block so you could use it after the block

            //do
            //{
            //    Console.WriteLine("Say the number between 0 and 10");
            //    string guyTellNum = Console.ReadLine();
            //    playerNum = Convert.ToInt32(guyTellNum);
            //}
            //while (playerNum < 0 || playerNum > 10);



            //// exp 14 for loop
            //for (int x = 1; x < 5; x++) //(initialization statement; condition to evaluate; updating action)
            //    Console.WriteLine(x);



            ////exp 15, I don't like this number (break/continue practice)

            ////the program should make a comment on an entered number
            ////if it's 13 it tells that it is a bad input
            ////after picking a number, program should ask for a number again without an end
            ////until user decides to quit
            ////to quit the user should use "exit" or "quit" input

            //while (true)
            //{
            //    Console.WriteLine("Tell me any number, but not 13");

            //    string input = Console.ReadLine();
            //    if (input == "quit" || input == "exit") //break out of the loop on this condition
            //        break;

            //    int favNum = Convert.ToInt32(input);

            //    if (favNum == 13)
            //    {
            //        Console.WriteLine("I don't like this number, pick something else.");
            //        continue;                                                               //Continue starts the loop over
            //    }
            //    Console.WriteLine($"I like this number. It's the one before {favNum + 1}");

            //}


            ////exp 16 , nested loops

            //int totalRows = 10;
            //int totalColumns = 5;

            //for (int currentRow = 1; currentRow <= totalRows; currentRow++)
            //    for (int currentColumn = 1; currentColumn <= totalColumns; currentColumn++)
            //        Console.WriteLine("*");



            //// The Prototype challenge 🦆🦆🦆
            //int number;
            //do
            //{
            //    Console.Write("User 1, enter a number between 0 and 100 ");
            //    number = Convert.ToInt32(Console.ReadLine());
            //}
            //while (number < 0 || number > 100);

            //Console.WriteLine("Press any button to continue.");
            //Console.ReadKey(true);
            //Console.Clear();


            //Console.WriteLine("User 2, guess the number.");
            //int guess;
            //Console.Write("What is your guess? ");
            //do
            //{
            //    guess = Convert.ToInt32(Console.ReadLine());

            //    if (guess < number)
            //    {
            //    Console.WriteLine("wrong, try a higher number");
            //    Console.Write("What's your next guess? " );
            //    }   

            //    if (guess > number)
            //    {
            //        Console.WriteLine("wrong, try a lower number");
            //        Console.Write("What's your next guess? " );
            //    }
            //}
            //while (guess != number);
            //Console.WriteLine("You guessed right!");



            //// The Magic Canon challenge 🔫🔫🔫


            //for (int turn = 1; turn > 0 && turn <= 100; turn++)
            //{
            //    string attackType;
            //    if (turn % 3 == 0 && turn % 5 == 0)
            //    {
            //        attackType = "COMBO";
            //        Console.ForegroundColor = ConsoleColor.Yellow;
            //        Console.WriteLine($"{turn}. {attackType}");
            //    }
            //    else if (turn % 3 == 0)
            //    {
            //        attackType = "Fire";
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine($"{turn}. {attackType}"); //we need a variable that contains attackType
            //    }

            //    else if (turn % 5 == 0)
            //    {
            //        attackType = "Electric";
            //        Console.ForegroundColor = ConsoleColor.Blue;
            //        Console.WriteLine($"{turn}. {attackType}"); //we need a variable that contains attackType
            //    }
            //    else
            //    {
            //        Console.ForegroundColor = ConsoleColor.White;
            //        Console.WriteLine($"{turn}. normal");
            //    }
            //}




            //// exp 17 Arrays, pt.1

            //int[] array = new int[15];
            //array[0] = 12;
            //array[1] = 15;
            //array[2] = 18;
            //Console.WriteLine(array[1]);


            ////exp 18 Arrays, pt.2

            //Console.WriteLine("Enter the length of an array");
            //int length = Convert.ToInt32(Console.ReadLine());
            //int[] array = new int[length];

            //for (int index = 0; index < array.Length; index++)
            //{
            //    array[index] = 1;
            //    Console.WriteLine(array[index]);
            //}


            ////exp 19, more array examples, the smallest number in an array

            //int[] array = new int[] { 4, -18, 78, -9, -42, 15 };
            //int smallestNumber = int.MaxValue;

            //for (int index = 0; index < array.Length; index++)
            //{

            //    if (array[index] < smallestNumber)
            //        smallestNumber = array[index];

            //}
            //Console.WriteLine(smallestNumber);


            // exp 20, more array examples pt.2 , the average value of numbers in the array

            // sum up all the numbers and divide them by number of items in the array

            //int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };   //average is 4.5
            //int total = 0;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    total += array[i];
            //}
            //float average = Convert.ToSingle(total) / array.Length;  // (float)total / array.Length;
            //Console.WriteLine(average);



            ////The Replicator of D'To challenge 👥👥👥

            //Console.WriteLine("Enter 5 numbers you want to replicate");
            //int[] array1 = new int[5];
            //array1[0] = Convert.ToInt32(Console.ReadLine());
            //array1[1] = Convert.ToInt32(Console.ReadLine());
            //array1[2] = Convert.ToInt32(Console.ReadLine());
            //array1[3] = Convert.ToInt32(Console.ReadLine());
            //array1[4] = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine();
            //Console.WriteLine("Lists:");
            //Console.WriteLine(); //to separate input and output

            //int[] array2 = new int[5];

            //for (int i = 0; i < 5; i++)
            //{
            //    array2[i] = array1[i];
            //    Console.Write($"{array1[i]} ");
            //    Console.WriteLine($"{array2[i]} ");
            //}


            ////exp 21, writing multiple things from the list?
            //int[] array1 = new int[] { 11, 22, 33, 44, 55, 66, 77, 88, 99, 100 };
            //Console.WriteLine($"{array1[0]}, {array1[3]}, {array1[6]}, {array1[8]}");
            //int[] array2 = new int[10];
            //array2 = array1;
            //Console.WriteLine($"{array2[0]}, {array2[3]}, {array2[6]}, {array2[8]}");



            ////exp Replecator of D'To challenge 2. Make it better.

            //int[] original = new int[5];
            //Console.WriteLine("Enter five numbers");

            //for (int item = 0; item < 5; item++)                            //This type of loop always used to run
            //                                                                //some code for 5(in this case) times
            //{
            //    int number = Convert.ToInt32(Console.ReadLine());
            //    original[item] = number;
            //}
            //;
            //Console.WriteLine();

            //int[] copy = new int[5];
            //for (int index = 0; index < 5; index++)
            //    copy[index] = original[index];
            //for (int index = 0; index < 5; index++)
            //    Console.WriteLine($"{original[index]} and {copy[index]}");



            ////The Laws of Freach challenge 👥👥👥
            ////the smallest number in the array pt.2

            //int[] container = new int[] { 4, -18, 78, -9, -42, 15 };
            //int smallestNumber = int.MaxValue;

            //foreach (int index in container)
            //    if (smallestNumber > index)
            //        smallestNumber = index;
            //Console.WriteLine(smallestNumber);



            ////the average value of numbers in the array pt.2

            //int[] container = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            //int total = 0;
            //foreach (int number in container)
            //    total += number;
            //float average = (float)total / container.Length;
            //Console.WriteLine(average);



            ////exp 22, multi-dimensional arrays

            //int[,] matrix = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            //Console.WriteLine(matrix[2, 0]); //get 5


            ////exp 22.5, jagged arrays. (when you need different number of components in each index)
            //int[][] matrix = new int[3][];
            //matrix[0] = new int[] { 2, 3, 4 };
            //matrix[1] = new int[] { 1, 7, 9, 135 };
            //matrix[2] = new int[] { 11, 12, 33, 42, 15 };
            //Console.WriteLine(matrix[2][3]);  //should be 42



            ////the replicator of D'To recall practice
            //int[] original = new int[5];
            //Console.WriteLine("Give me 5 numbers");
            //for (int item = 0; item < 5; item++)
            //    original[item] = Convert.ToInt32(Console.ReadLine());
            //int[] copy = new int[5];
            //for (int index = 0; index < 5; index++)                           // it's one 'for' loop less
            //{                                                                // than the original solution!
            //    copy[index] = original[index];
            //    Console.WriteLine($"{original[index]} and {copy[index]}");
            //}



            ////exp 23, some basic method play

            //CountToTen();               //it can be before or it can be after the method body

            //void CountToTen()
            //{
            //    for (int current = 1; current <= 10; current++)
            //        Console.WriteLine(current);
            //}

            //// exp 23.1, DON'T DO THIS
            //string text = Console.ReadLine();           //don't declare a variable that's used in method
            //                                            //outside the method

            //void ReadText()                   //you can use 'static void MethodName' to be safe
            //{
            //    Console.WriteLine(text);      //DON'T DO THIS, it's better not to make a method inside other method
            //}

            //ReadText();



            ////exp 24 more methods 
            //static void CountBetween(int start, int end)
            //{
            //    for (int current = start; current <= end; current++ )
            //        Console.WriteLine(current);
            //}
            //CountBetween(10, 15);



            ////exp 25
            //Console.WriteLine("How hight should I count?");
            //int chosenNum = GetNumber();
            //Console.WriteLine("Where to start?");
            //Count(chosenNum);

            //static int GetNumber()
            //{
            //    string input = Console.ReadLine();
            //    int number = Convert.ToInt32(input);
            //    return number;
            //}
            //static void Count(int countToNumber)
            //{
            //    for (int current = GetNumber(); current <= countToNumber; current++)
            //        Console.WriteLine(current);
            //}



            ////exp 26, simple methods with expressions
            //void SomeThing() => Console.WriteLine(2 + 1);
            //int SomeThingInt(int value) => value * 2 + 1;           //only one line of code!!!



            ////Taking a number challenge ©️©️©️
            //// 1st method
            //static int AskForNumber(string text)
            //{
            //    Console.WriteLine(text);
            //    int response = Convert.ToInt32(Console.ReadLine());
            //    return response;
            //}

            //// 1st method USE
            //int result = AskForNumber("How tall are you?");
            //Console.WriteLine("No you're lying, you're about 10 sm shorter," +
            //$" your height should be about {result - 10} sm");

            ////2nd method
            //static int AskForNumberInRange(string text, int min, int max)
            //{

            //    while (true)
            //    {
            //        string inputNumber = Input(text);
            //        int number = Convert.ToInt32(inputNumber);
            //        if (number >= min && number <= max)
            //            return number;
            //        else
            //            Console.WriteLine("Number is out of range. Try again.");

            //    }
            //}
            //// 2nd method USE
            //Console.WriteLine(AskForNumberInRange("Set the number between 0 and 100 ", 0, 100));



            ////exp 27 making an Input python method
            //string var = Input("your first input ");
            //string var1 = Input("your second input ");

            //int x = Convert.ToInt32(var);
            //int y = Convert.ToInt32(var1);

            //Console.WriteLine(x + y);



            ////The Countdown challenge ⏬⏬⏬
            //static void Countdown(int startNumber, int endNumber)
            //{
            //    if (startNumber <= endNumber)
            //        return;
            //    Console.WriteLine(startNumber);
            //    Countdown(startNumber - 1, endNumber);
            //}

            //Countdown(10, 0);



            //BOSS FIGHT: Hunting the Manticore 🐼🐼🐼

            //initializing start stats
            int manticoreHP = 10;
            int cityHP = 15;

            // Player 1 setting the Manticore position
            int manticoreRange;
            while(true)
            {
                Console.Write("Player 1, how far away from the city do you want to station the Manticore? (1 - 100)  ");
                manticoreRange = Convert.ToInt32(Console.ReadLine());
                if (manticoreRange <= 100 && manticoreRange >= 0)
                    break;
            }
            Console.Clear();

            //Player 2 turn, setting round loop and displaying status of the battle
            Console.WriteLine("Player 2, it is your turn");
            for (int round = 1; manticoreHP > 0 && cityHP > 0; round++)
            {
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine($"STATUS:  Round: {round}  City: {cityHP}  Manticore: {manticoreHP}");

                //Canon attack damage and its type
                int canonDamage;
                string damageType;
                if (round % 3 == 0 && round % 5 == 0)
                {
                    canonDamage = 10;
                    damageType = "COMBO";
                }
                else if (round % 3 == 0)
                {
                    canonDamage = 3;
                    damageType = "Fire";
                }
                else if (round % 5 == 0)
                {
                    canonDamage = 3;
                    damageType = "Electric";
                }
                else
                {
                    canonDamage = 1;
                    damageType = "Normal";
                }

                //The canon is expected to deal {3} {fire} damage message
                Console.Write($"The canon is expected to deal {canonDamage} ");
                ElementColor(damageType);
                Console.Write($"{damageType} ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("damage this round");

                //changing color of damage type word Method
                void ElementColor(string damageType)
                {
                    if (damageType == "Normal")
                        Console.ForegroundColor = ConsoleColor.White;
                    if (damageType == "COMBO")
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    if (damageType == "Fire")
                        Console.ForegroundColor = ConsoleColor.Red;
                    if (damageType == "Electric")
                        Console.ForegroundColor = ConsoleColor.Blue;
                }

                int shot;
                do
                {
                    shot = Convert.ToInt32(Input("Enter desired canon range  "));
                    if (shot == manticoreRange)
                    {
                        manticoreHP -= canonDamage;
                        Console.WriteLine("This round was a DIRECT HIT!");
                    }
                    else if (shot > manticoreRange)
                    {
                        Console.WriteLine("That round OVERSHOT the target");
                    }
                    else if (shot < manticoreRange)
                    {
                        Console.WriteLine("That round FELL SHORT of the target");
                    }

                }
                while (shot > 100 && shot < 0);

                //While manticore is alive city suffers 1 HP loss every turn
                if (manticoreHP > 0)
                    cityHP--;

                //conditions of winning or loosing and final message
                if (cityHP <= 0)
                {
                    Console.WriteLine("YOU'VE LOST");
                    Console.WriteLine("City of Consolas has fallen.");
                    Console.WriteLine("Try again? \n(press something)");
                    Console.ReadKey(true);
                }
                else if (manticoreHP <= 0)
                {
                    Console.WriteLine("VICTORY!");
                    Console.WriteLine("Manticore was destroyed!");
                    Console.WriteLine("The city of Consolas has been saved!");

                }
            }
        }
            //LVL UP
            //OOP PROGRAMMING 
            
    }
}