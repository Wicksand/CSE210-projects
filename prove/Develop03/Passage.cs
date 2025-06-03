using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.XPath;

class Passage
{

    public string Book { get; private set; }
    public string Chapter { get; private set; }
    public string VerseStart { get; private set; }
    public string VerseEnd { get; private set; }
    private List<Word> _words = new List<Word>();

    private static Random _random = new Random();

    private List<string> _scriptures = new List<string>
    {
        "Mosiah#2#17#And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God.",
        "Proverbs#3#5#6#Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.",
        "Moroni#7#33#34#And Christ hath said: If ye will have faith in me ye shall have power to do whatsoever thing is expedient in me. And he hath said: Repent all ye ends of the earth, and come unto me, and be baptized in my name, and have faith in me, that ye may be saved."
    };
    public Passage(string scripture)
    {
            ParseScripture(scripture);
    }
    private void ParseScripture(string scripture)
    {
        string[] parts = scripture.Split('#');
    
        Book = parts[0];
        Chapter = parts[1];
        VerseStart = parts[2];

        if (int.TryParse(parts[3], out _))
        {
            VerseEnd = parts[3];
            string script = string.Join('#', parts.Skip(4));
            ConvertToWords(script);
        }
        else
        {
            VerseEnd = "";
            string script = string.Join('#', parts.Skip(3));
            ConvertToWords(script);
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

    public string GetPassage()
    {
        string passageTxt = "";

        for (int count = 0; count < _words.Count; count++)
        {
            passageTxt += _words[count].GiveWord();

            if (count < _words.Count - 1)
            {
                passageTxt += " ";
            }
        }
        return passageTxt;
    }
    public string PickRandom() {
        int id = _random.Next(_scriptures.Count);
        return _scriptures[id];
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
}
    
