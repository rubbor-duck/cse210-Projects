using System.ComponentModel.DataAnnotations;
using System.Data;

class Scritpure
{
    private List<Word> _scritpure = new List<Word>();
    private int _random;
    private List<int> _usedRandom = new List<int>();
    private Reference reference1 = new Reference();

    // blank constructor for the class
    public Scritpure(){}

    // verse constructor to set up the verse into a list
    public Scritpure(string verse)
    {
         string[] words = verse.Split(" ");
         
         foreach (string x in words)
        {
            Word newer = new Word(x);
            _scritpure.Add(newer);
        }
         
    }

    // sets the _scritpure, similar to the verse constructor
    public void SetScripture(string verse)
    {
         string[] words = verse.Split(" ");
         
         foreach (string x in words)
        {
            Word newer = new Word(x);
            _scritpure.Add(newer);
        }
         
    }

    // displays the _scritpure, hidding words that have the hidden tag checked
    public string GetScripture()
    {
        string verse = null;
        foreach (Word word in _scritpure)
        {
            if (word.GetHidden() == false)
            {
                string lastword = $"{word.GetWord()} ";
                verse = verse + lastword;
            }
            
            else
            {
                string lastword = $"{word.ReplaceWord()} ";
                verse = verse + lastword;
            }
        } 

        return verse;
    }

    // randomly selects a word to be hidden, skipping over those that have already had the hidden tag checked off
    public void SelectRandomHidden()
    {
        Random random = new Random();
        _random = random.Next(0, TotalWords());


        if (IsCompletelyHidden() == false)

        {
            for (;;)
            {
                if (_scritpure[_random].GetHidden() == false)
                {
                    _scritpure[_random].SetHidden();
                    break;
                }
            
                else
                {
                    _random = random.Next(0, TotalWords());
                }
            }
        }
       
    }

    // an internal function that counts the total words in a verse
    public int TotalWords()
    {
        int textamount = _scritpure.Count();
        return textamount;
    }

    // checks if the verse is completely hidden
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _scritpure)
        {
            if (word.GetHidden() == false)
            {
                return false;
            }   
        }

        return true;
    }

}