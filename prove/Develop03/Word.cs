using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;

public class Word
{
    private string _text = null;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public string GetWord()
    {
        string text = _text;
        return text;
    }

    public bool GetHidden()
    {
        return _isHidden;
    }

    public void SetHidden()
    {
        _isHidden = true;
    }

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