using System.Collections.Concurrent;
using System.Reflection;
using System.Runtime.CompilerServices;

class Reference
{
    private string _book;

    private string _title;

    private string _chapter;

    private string _verseSt;

    private string _verseEnd;

    public Reference()
    {

    }

    public Reference(string book, string chapter, string verseSt)
    {
        _book = book;
        _chapter = chapter;
        _verseSt = verseSt;
        _verseEnd = "";
    }
    public Reference(string book, string chapter, string verseSt, string verseEnd)
    {
        _book = book;
        _chapter = chapter;
        _verseSt = verseSt;
        _verseEnd = verseEnd;
    }

    // public void Display()
    // {

    // }

    public string GetReference()
    {
        string reference = "";

        if (_verseEnd == "")
        {
            reference = $"{_book} {_chapter} {_verseSt}";
            return reference;
        }
        else
        {
            reference = $"{_book} {_chapter} {_verseSt}-{_verseEnd}";
            return reference;
        }
    }
}