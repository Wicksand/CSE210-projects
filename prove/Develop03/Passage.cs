using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.XPath;

class Passage
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private Random _random = new Random();
    private List<string> _scriptures;
   
    public Passage()
    {
        _scriptures = new List<string>();
        _scriptures.Add("Mosiah#2#17#And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God.");
        _scriptures.Add("Proverbs#3#5#6#Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
        _scriptures.Add("Moroni#7#33#34#And Christ hath said: If ye will have faith in me ye shall have power to do whatsoever thing is expedient in me. And he hath said: Repent all ye ends of the earth, and come unto me, and be baptized in my name, and have faith in me, that ye may be saved.");
        int index = _random.Next(_scriptures.Count);
        ParseScripture(_scriptures[index]);
    }
    private void ParseScripture(string scripture)
    {
        string[] parts = scripture.Split('#');

        string Book = parts[0];
        int Chapter = int.Parse(parts[1]);
        int VerseStart = int.Parse(parts[2]);

        if (int.TryParse(parts[3], out _))
        {
            int VerseEnd = int.Parse(parts[3]);
            string script = parts[4];
            ConvertToWords(script);
            _reference = new Reference(Book, Chapter, VerseStart, VerseEnd);
        }
        else
        {
            string script = parts[3];
            ConvertToWords(script);
            _reference = new Reference(Book, Chapter, VerseStart);
        }

    }

    private void ConvertToWords(string scripture)
    {
        string[] words = scripture.Split(' ');
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int count)
    {
        int wordsLeft = 0;
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                wordsLeft++;
            }
        }

        int toHide = count;
        if (toHide > wordsLeft)
        {
            toHide = wordsLeft;
        }
        int hideCounter = 0;

        while (hideCounter < toHide)
        {
            int value = _random.Next(_words.Count);
            if (!_words[value].IsHidden())
            {
                _words[value].Hide();
                hideCounter++;
            }
        }
    }

    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;

    }
    public void Displayscript()
    {
        _reference.Display();

        foreach (Word word in _words)
        {
            Console.Write($"{word.GiveWord()} ");
        }
    }
}
    
