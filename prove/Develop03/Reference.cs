public class Reference
{
    // This class will gather the information to create the block of scripture to memorize
    // Member variables
    private string _bookRef;
    private int _bookChap;
    private int _verseS;
    private int _verseE;
    private string _content;

    // Constructor
    public Reference()
    {
        _bookRef = "Proverbs";
        _bookChap = 3;
        _verseS = 5;
        _verseE = 6;
        _content = "Trust in the Lord with all thine heart; and lean not unto thine own understanding.\nIn all thy ways acknowledge him, and he shall direct thy paths.";
    }

    public string GenerateReference()
    {
        return $"{_bookRef} {_bookChap}:{_verseS}-{_verseE} {_content}";
    }
}