using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

class Word
{

    private string _word;
    private bool _isHidden;

    public Word(string scripture)
    {
        _word = scripture;
        _isHidden = false;
    }
    public void Hide() //may be unessisary
    {
        _isHidden = true;
    }

    public bool IsHidden() // may be unessisary
    {
        return _isHidden;
    }

    public string GiveWord()
    {
        return _word;
    }
}