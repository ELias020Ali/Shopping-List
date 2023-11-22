main();

int main()
{
    List<string> stockMenu = new List<string> { "Bananas", "Chocolate bars", "Pears", "Oranges", "Coconuts", "Coca-cola", "Coffee" };
    while (true)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("VISUAL STUDIO SUPERMARKET");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Do you want to check whether an item is in stock or to alter it?: ");
        string userinput = Console.ReadLine();
        if (userinput == "check")
        {
            shopping();
        }
        else if (userinput == "alter")
        {
            alterStock(stockMenu);
        }
        else if (userinput == "quit")
        {
            return 0;
        }
    }

    void shopping()
    {
        List<string> itemList = new List<string>();

        List<string> outofStock = new List<string> { "milk", "sushi", "ice cream", "apples", "crisps", "falafel" };
        Console.WriteLine("Make a list to see whether we have any of the items in stock");
        Console.WriteLine("Add an item: ");
        while (true)
        {

            string userinput = Console.ReadLine();
            if (userinput == "quit")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("---------------------------------------------------------------------------");
                break;
            }
            else
            {
                itemList.Add(userinput);

            }
        }
        foreach (string item in itemList)
        {
            foreach (string outOfStockitem in outofStock)
            {
                if (item == outOfStockitem)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(item + " is not available");
                }
            }
        }
    }

    void alterStock(List<string> items)
    {
        string userinput = "start";
        while (userinput != "quit")
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Select the option you want to pick");
            Console.WriteLine("\n1. Add\n2.remove");
            userinput = Console.ReadLine();
            switch (userinput)
            {
                case "1":
                    Console.WriteLine("What do you want to add?: ");
                    string addItem = Console.ReadLine();
                    items.Add(addItem);
                    break;
                case "2":
                    Console.WriteLine("What do you want to remove?: ");
                    string delItem = Console.ReadLine();
                    items.Remove(delItem);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input");
                    break;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("The current stock is: ");
            foreach (string item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}