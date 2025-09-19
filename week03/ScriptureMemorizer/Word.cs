using System;
using System.Collections.Generic;

public class Word
{
    private string _word;
    private bool _isHidden;

    public Word(string text)
    {
        _word = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden == true)
        {
            string invisibleWord = "";
            for (int i = 0; i < _word.Length; i++)
            {
                invisibleWord += "_";
            }
            return invisibleWord;
        }

        else
        {
            return _word;
        }
    }
}