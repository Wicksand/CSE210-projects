using System.Collections.Concurrent;
using System.Reflection;
using System.Runtime.CompilerServices;

class Reference
{
    private string _book;
    private string _chapter;
    private string _verseSt;
    private string _verseEnd;
    private Passage _passage;

    public Reference(string book, string chapter, string verseSt, Passage passage)
    {
        _book = book;
        _chapter = chapter;
        _verseSt = verseSt;
        _verseEnd = "";
        _passage = passage;
    }
    public Reference(string book, string chapter, string verseSt, string verseEnd, Passage passage)
    {
        _book = book;
        _chapter = chapter;
        _verseSt = verseSt;
        _verseEnd = verseEnd;
        _passage = passage;
    }

    public void Display()
    {
        Console.WriteLine($"{GetReference()} {_passage.GetPassage()}");
    }

    public string GetReference()
    {

        if (_verseEnd == "")
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