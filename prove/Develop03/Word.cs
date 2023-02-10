using System;

// Hold a information for a single word

class Word 
{
    // ATTRIBUTES
    private string _word;
    private bool _hidden = false; // Default - word is not hidden

    // CONSTRUCTOR
    public Word (string word)
    {
        _word = word;
    }

    // METHODS
    public string GetWord() 
    {
        return _word;
    }

    public bool GetHidden() 
    {
        return _hidden;
    }

    public void HideWord() // Hide _word and replace letters with _'s
    {
        _hidden = true;

        char[] letters = _word.ToCharArray();

        for(int i = 0; i < letters.Length; i++)
            {
                letters[i] = '_';
            }
        
        _word = new String(letters);
    }
}