    string input = null;
    
    Scritpure scritpure = new Scritpure();

    Reference reference = new Reference();

    Console.WriteLine($"{reference}: {scritpure.GetScripture}");

    Console.WriteLine($"Press enter to hide a word, or type 'quit' to exit the program");

    while ((input != "quit") && (scritpure.IsCompletelyHidden() == false))
    {
        input = Console.ReadLine();

        if (input == "")
        {
            scritpure.SelectRandomHidden();
            scritpure.GetScripture();
        }

        else if (input == "quit")
        {
            continue;
        }

        else
        {
            Console.WriteLine("Please press enter to hide a word");
        }
    }