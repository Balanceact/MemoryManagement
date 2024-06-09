namespace MemoryManagement
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number" 
                    + "\n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParenthesis"
                    + "\n5. ReverseText"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    case '5':
                        ReverseText();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
                // 0. Teori och fakta
                // Svar 0.1: Stacken är en trave av lådor där den översta i högen är den enda som går att nå för stunden.
                //           Heapen är en hög av information där allt är nåbart samtidigt. Referenstyper bor på Heapen och den har ingen koll på vad som förväntas hända härnäst.
                // Svar 0.2: Value Types är enkla på det sättet att de lagrar ett värde. Reference Types är mer komplicerade då de lagrar en referens till något annat.
                // Svar 0.3: Se Svar 0.2, med förtydligande i form av att 'y = x' för en Reference Type betyder att x referens sätts på y och att allt som senare sker med y också
                //           sker med det objekt på Heapen som nu både x och y refererar till.
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to the main menu.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            //List<string> theList = new List<string>();
            //string input = Console.ReadLine();
            //char nav = input[0];
            //string value = input.substring(1);

            //switch(nav){...}

            bool subMenu = true;
            List<string> thelist = new List<string>();
            Console.WriteLine("Use 'q' to quit, '+' to add to the list and '-' to remove from the list.");
            do
            {
                string input = Console.ReadLine();
                char nav = input[0];
                string value = input.Substring(1);
                switch (nav)
                {
                    case '+':
                        thelist.Add(value);
                        Console.WriteLine($"Current Capacity: {thelist.Capacity}");
                        break;
                    case '-':
                        thelist.Remove(value);
                        Console.WriteLine($"Current Capacity: {thelist.Capacity}");
                        break;
                    case 'q':
                        subMenu = false;
                        break;
                    default:
                        Console.WriteLine("Use only q, + or -");
                        break;
                }
            } while (subMenu);
            // Svar 1.1: Se ovan.
            // Svar 1.2: När första objektet läggs till så ökar listans kapacitet från 0 till 4, därefter ökar kapaciteten varje gång listan överskrider den innevarande kapaciteten.
            // Svar 1.3: Första gången så ökar kapaciteten från 0 till 4, därefter så dubbleras listans kapacitet efter behov.
            // Svar 1.4: För att DefaultCapacity är hårdkodat till 4 och dokumentationen beskriver att listan därefter kommer att ökas med multipler av 2.
            // Svar 1.5: Nej.
            // Svar 1.6: När listan behöver begränsas i kapacitet.
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
            bool subMenu = true;
            Queue<string> theQueue = new Queue<string>();
            Console.WriteLine("Use 'q' to quit, '+' to add to the queue and '-' to remove from the queue.");
            do
            {
                string input = Console.ReadLine();
                char nav = input[0];
                string value = input.Substring(1);
                switch (nav)
                {
                    case '+':
                        theQueue.Enqueue(value);
                        Console.WriteLine($"Current Count: {theQueue.Count}");
                        break;
                    case '-':
                        theQueue.Dequeue();
                        Console.WriteLine($"Current Count: {theQueue.Count}");
                        break;
                    case 'q':
                        subMenu = false;
                        break;
                    default:
                        Console.WriteLine("Use only q, + or -");
                        break;
                }
            } while (subMenu);
        }
        // Svar 2.1: a. Queue<string> theQueue = new Queue<string>();
        //           b. theQueue.Enqueue("Kalle");
        //           c. theQueue.Enqueue("Greta");
        //           d. theQueue.Dequeue();
        //           e. theQueue.Enqueue("Stina");
        //           f. theQueue.Dequeue();
        //           g. theQueue.Enqueue("Olle");
        //           h. theQueue.Dequeue();
        //           i. theQueue.Dequeue();
        // Svar 2.2: +Kalle
        //           Current Count: 1
        //           +Greta
        //           Current Count: 2
        //           -
        //           Current Count: 1
        //           +Stina
        //           Current Count: 2
        //           -
        //           Current Count: 1
        //           +Olle
        //           Current Count: 2
        //           -
        //           Current Count: 1
        //           -
        //           Current Count: 0

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
            bool subMenu = true;
            Stack<string> theStack = new Stack<string>();
            Console.WriteLine("Use 'q' to quit, '+' to add to the stack and '-' to remove from the stack.");
            do
            {
                string input = Console.ReadLine();
                char nav = input[0];
                string value = input.Substring(1);
                switch (nav)
                {
                    case '+':
                        theStack.Push(value);
                        Console.WriteLine($"Current Count: {theStack.Count}");
                        break;
                    case '-':
                        theStack.Pop();
                        Console.WriteLine($"Current Count: {theStack.Count}");
                        break;
                    case 'q':
                        subMenu = false;
                        break;
                    default:
                        Console.WriteLine("Use only q, + or -");
                        break;
                }
            } while (subMenu);
        }
        // Svar 3.1: a. Stack<string> theStack = new Stack<string>();
        //           b. theStack.Push("Kalle");
        //           c. theStack.Push("Greta");
        //           d. theStack.Pop();
        //           e. theStack.Push("Stina");
        //           f. theStack.Pop();
        //           g. theStack.Push("Olle");
        //           h. theStack.Pop();
        //           i. theStack.Pop();
        // Svar 3.2: Se ReverseText() nedan.


        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

        }

        static void ReverseText()
        {
            Stack<char> theStack = new Stack<char>();
            Console.WriteLine("Input a string to be reversed.");
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length ; i++)
            {
                theStack.Push(input[i]);
                //Console.WriteLine($"{i} {theStack.Peek()}");
            }
            for (int i = theStack.Count; i > 0 ; i--)
            {
                Console.Write($"{theStack.Pop()}");
            }
            Console.WriteLine("");
        }

    }
}

