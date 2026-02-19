using System.ComponentModel.DataAnnotations;
using System.Data;

class Scritpure
{
    private List<Word> _scritpure = new List<Word>();
    private int _random;
    private List<int> _usedRandom = new List<int>();
    private Reference reference1 = new Reference();

    public Scritpure(){}

    public Scritpure(string reference, string verse)
    {
         string[] words = verse.Split(" ");
         
         foreach (string word in words)
            {
                
                
                
            }

         reference1.SetReference(reference);
         
    }

    public void GetScripture()
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

        Console.WriteLine($"{reference1}: {verse}");
    }

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

    public int TotalWords()
    {
        int textamount = _scritpure.Count();
        return textamount;
    }

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