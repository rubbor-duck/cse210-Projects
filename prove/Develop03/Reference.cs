class Reference
{
    private string _reference = null;
    private string _verseNumber = null;
    private string _chapterNameNumber = null;
    private string _startingVerseRange = null;
    private string _endingVerseRange = null;

    // three different construtors, one for blank, one for a single verse, and on for multiple verses
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

    // sets the chpater name and number
    public void SetChapterNameNumber(string temp)
    {
        _chapterNameNumber = temp;
    }

    // sets the single verse to _verseNumber
    public void SetSingleVerse(string temp)
    {
        _verseNumber = temp;
    }

    // sets the starting verse number of a verse range
    public void SetStartingVerseRange(string temp)
    {
        _startingVerseRange = temp;
    }

    // sets the ending verse number of a verse range, and sets both verse ranges to _verseNumber
    public void SetEndingVerseRange(string temp)
    {
        _endingVerseRange = temp;
        _verseNumber = $"{_startingVerseRange}-{_endingVerseRange}";
    }

    // combines the _chapterNameNumber, and _verseNumber to a single reference string
    public void SetReference()
    {
        _reference = $"{_chapterNameNumber}:{_verseNumber}";
    }

    // returns the reference string
    public string GetReference()
    {
        string temp = _reference;

        return temp;
    }

}