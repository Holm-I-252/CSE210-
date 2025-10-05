public class Scripture
{
    private Reference _reference;
    private string _text;
    private List<Words> _wordsList = new List<Words>();


    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _text = text;
        _wordsList = SetWordsList();
    }

    public string GetScripture()
    {
        return $"{_reference.GetReference()}: \"{string.Join(" ", _wordsList.Select(w => w.GetDisplayText()))}\"";
    }

    public List<Words> SetWordsList()
    {
        foreach (var word in _text.Split(' '))
        {
            Words w = new Words(word);
            _wordsList.Add(w);
        }
        return _wordsList;
    }

    public void HideWords()
    {
        Random random = new Random();
        int wordsToHide = random.Next(1, 4);
        int totalWords = _wordsList.Count;

        for (int i = 0; i < wordsToHide && i < totalWords; i++)
        {
            int index = random.Next(totalWords);
            _wordsList[index].Hide();
        }
    }
    
}