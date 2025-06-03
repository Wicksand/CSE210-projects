using System.Collections.Concurrent;
using System.Reflection;
using System.Runtime.CompilerServices;

class Reference
{
    private string _book;
    private int _chapter;
    private int _verseSt;
    private int _verseEnd;

    public Reference(string book, int chapter, int verseSt)
    {
        _book = book;
        _chapter = chapter;
        _verseSt = verseSt;
        _verseEnd = -1;

    }
    public Reference(string book, int chapter, int verseSt, int verseEnd)
    {
        _book = book;
        _chapter = chapter;
        _verseSt = verseSt;
        _verseEnd = verseEnd;
    }

    public void Display()
    {
        Console.WriteLine($"{GetReference()}");
    }

    public string GetReference()
    {

        if (_verseEnd == -1)
        {
            string reference = $"{_book} {_chapter}: {_verseSt}";
            return reference;
        }
        else
        {
            string reference = $"{_book} {_chapter}: {_verseSt}-{_verseEnd}";
            return reference;
        }
    }
}