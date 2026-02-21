using System.Globalization;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;

public class Word
{
    private string _text = null;
    private bool _isHidden;

    // constructor that requires a string, and automatically sets the _isHidden tag to be false
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // sets the word
    public void SetWord(string word)
    {
        _text = word;
    }

    // returns the word to be displayed
    public string GetWord()
    {
        string text = _text;
        return text;
    }

    // returns the current status of the _isHidden tag
    public bool GetHidden()
    {
        return _isHidden;
    }

    // Sets the _isHidden tag to true
    public void SetHidden()
    {
        _isHidden = true;
    }

    // replaces the word with a blanked out verse if the _isHidden tag is true
    public string ReplaceWord()
    {
        if (_isHidden == true)
        {
            int x = _text.Length;
            int loop = 0;
            string blankedword = null;

            while (loop != x)
            {
                blankedword += "_";
                loop += 1;
            }
            
            return blankedword;
        }

        return _text;
    }

}