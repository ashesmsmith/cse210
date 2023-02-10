using System;

// Hold and display the information needed for the reference

class Reference
{
    // ATTRIBUTES
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd;

    // CONSTRUCTORS
    public Reference (string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verse;
        _verseEnd = 0;
    }

    public Reference (string book, int chapter, int start, int end)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = start;
        _verseEnd = end;
    }
    
    // METHOD
    public string DisplayReference()
    {
        if (_verseEnd == 0)
        {
            string reference = ($"{_book} {_chapter}:{_verseStart}");
            return reference;
        }

        else
        {
            string reference = ($"{_book} {_chapter}:{_verseStart}-{_verseEnd}");
            return reference;
        }
    }
}