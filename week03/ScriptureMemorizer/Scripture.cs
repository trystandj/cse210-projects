using System;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text) {
        _reference = reference;
        _words = new List<Word>();
        string[] words = text.Split(' ');
        foreach (string word in words) {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWord(int numberToHide) {
        Random random = new Random();
        int hiddenCount = 0;
     
        while (hiddenCount < numberToHide) {
            int index = random.Next(_words.Count);

            if (!_words[index].IsHidden()) {
                _words[index].Hide();
                hiddenCount++;
            }
        }

            
    }

    public string GetDisplayTest() {
        string displayText = _reference.GetDisplayedReference() + "\n";
        foreach (Word word in _words) {
            displayText += word.GetText() + " ";
        }
        return displayText;
    }

    public bool IsCompletelyHidden() {
        foreach (Word word in _words) {
            if (!word.IsHidden()) {
                return false;
            }
        }
        return true;
    }
}

