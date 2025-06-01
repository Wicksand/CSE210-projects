using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

class Word
{

    private string _word;

    public Word()
    {

    }

    public Word(string scripture) {
        scripture.Split("#");
    }

    private bool IsHiddenLetter(string check)
    {
        if (check == "_")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private void HideLetters(string word)
    {
        string divWord = word.Split();
        divWord.Count();
        
        
    }
}