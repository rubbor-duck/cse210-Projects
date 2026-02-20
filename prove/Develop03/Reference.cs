class Reference
{
    private string _reference = null;
    private string _verseNumber = null;
    private string _chapterNameNumber = null;
    private string _startingVerseRange = null;
    private string _endingVerseRange = null;

    public Reference()
    {
        
    }

    public Reference(string chapterNameNumber, string singleVerse)
    {
        _reference = $"{chapterNameNumber}:{singleVerse}";
    }
 
    public Reference(string chapterNameNumber, string startingVerseRange, string endingVerseRange)
    {
        _reference = $"{chapterNameNumber}:{startingVerseRange}-{endingVerseRange}";
    }

    public void SetChapterNameNumber(string temp)
    {
        _chapterNameNumber = temp;
    }

    public void SetSingleVerse(string temp)
    {
        _verseNumber = temp;
    }

    public void SetStartingVerseRange(string temp)
    {
        _startingVerseRange = temp;
    }

    public void SetEndingVerseRange(string temp)
    {
        _endingVerseRange = temp;
        _verseNumber = $"{_startingVerseRange}-{_endingVerseRange}";
    }

    public void SetReference()
    {
        _reference = $"{_chapterNameNumber}:{_verseNumber}";
    }

    public string GetReference()
    {
        string temp = _reference;

        return temp;
    }

}