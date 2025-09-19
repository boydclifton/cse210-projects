
using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;




    public Scripture(Reference reference, string text)
    {

        _reference = reference;


        _words = new List<Word>();


        string[] parts = text.Split(" ");


        foreach (string part in parts)
        {
            Word newWord = new Word(part);
            _words.Add(newWord);
        }
    }


    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();

        List<Word> _visibleWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                _visibleWords.Add(word);
            }
        }

        if (_visibleWords.Count == 0)
        {
            return;
        }

        for (int i = 0; i < numberToHide; i++)
        {

            if (_visibleWords.Count == 0)
            {
                break;
            }

            int index = rand.Next(_visibleWords.Count);
            Word wordToHide = _visibleWords[index];
            wordToHide.Hide();
            _visibleWords.RemoveAt(index);
        }
    }


    public string GetDisplayText()
    {

        string referenceInfo = _reference.GetDisplayText();


        string wordsInfo = "";

        foreach (Word word in _words)
        {
            wordsInfo += word.GetDisplayText() + " ";
        }


        wordsInfo = wordsInfo.TrimEnd();


        return referenceInfo + " - " + wordsInfo;
    }






    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {

            if (word.IsHidden() == false)
            {
                return false;
            }
        }


        return true;
    }
}