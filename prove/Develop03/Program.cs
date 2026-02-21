    
    /* For the extra credit: 
    I had the hide word function skip over words that are already hidden 
    I also allowed the user to be able to put in their own scriputre/reference
    */

    string input = null;
    
    Scritpure scritpure = new Scritpure();

    Reference reference = new Reference();


    // asking the user for the reference and the verse range
    Console.Write("Please enter the Chapter name and number: ");
    reference.SetChapterNameNumber(Console.ReadLine());

    Console.Write("Please enter the verse number/verse range (1 or 4-16): ");
    string temp = Console.ReadLine();
    string[] verses = temp.Split("-");
    
    // checks if the verse range is multiple verses, or just a single verse
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

    // asking the user for the verses
    Console.Write("Please enter the verses: ");
    string verse = Console.ReadLine();
    scritpure.SetScripture(verse);
    Console.Clear();

    // displays the reference and the scripture
    Console.WriteLine($"{reference.GetReference()}: {scritpure.GetScripture()}");

    Console.WriteLine($"Press enter to hide a word, or type 'quit' to exit the program");

    /* the main loop that starts to hide the words in the scripture
        the loop checks if the user has inputed 'quit', then quits the loop
        if all the words are hidden, then the loop breaks
    */
    while ((input != "quit") && (scritpure.IsCompletelyHidden() == false))
    {
        input = Console.ReadLine();
        Console.Clear();

        // checks if input is just the enter key, then hides a random word, then displays it
        if (input == "")
        {
            scritpure.SelectRandomHidden();
            Console.WriteLine($"{reference.GetReference()}| {scritpure.GetScripture()}");
        }

        // checks if the input is 'quit'. if it is, then the program continues without doing anything
        else if (input == "quit")
        {
            continue;
        }

        // error code if the user inputs anything else
        else
        {
            Console.WriteLine("Please press enter to hide a word");
        }
    }