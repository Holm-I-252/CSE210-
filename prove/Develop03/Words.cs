public class Words
{
    private string _word;
    private bool _isHidden;

    public Words(string word)
    {
        _word = word;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Reveal()
    {
        _isHidden = false;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            _word = new string('_', _word.Length);
            return _word;
        }
        return _word;
    }
}