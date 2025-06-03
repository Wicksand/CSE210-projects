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
    public void Hide() 
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GiveWord()
    {
        if (IsHidden())
        {
            string returnValue = "";
            for (int i = 0; i < _word.Length; i++)
            {
                returnValue += "_";
            }
            return returnValue;
        }
        else
        {
            return _word;
        }
    }
}