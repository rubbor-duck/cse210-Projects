    string input = null;
    
    Scritpure scritpure = new Scritpure();

    Reference reference = new Reference();

    Console.Write("Please enter the Chapter name and number: ");
    reference.SetChapterNameNumber(Console.ReadLine());

    Console.Write("Please enter the verse number/verse range (1 or 4-16): ");
    string temp = Console.ReadLine();
    string[] verses = temp.Split("-");

    if (verses.Length == 2)
    {
        reference.SetStartingVerseRange(verses[0]);
        reference.SetEndingVerseRange(verses[1]);
    }

    else if (verses.Length == 1)
    {
        reference.SetSingleVerse(verses[0]);
    }

    reference.SetReference();

    Console.Write("Please enter the verses: ");
    string verse = Console.ReadLine();
    scritpure.SetScripture(verse);

    Console.WriteLine($"{reference.GetReference()}: {scritpure.GetScripture()}");

    Console.WriteLine($"Press enter to hide a word, or type 'quit' to exit the program");

    while ((input != "quit") && (scritpure.IsCompletelyHidden() == false))
    {
        input = Console.ReadLine();
        Console.Clear();

        if (input == "")
        {
            scritpure.SelectRandomHidden();
            Console.WriteLine($"{reference.GetReference()}| {scritpure.GetScripture()}");
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