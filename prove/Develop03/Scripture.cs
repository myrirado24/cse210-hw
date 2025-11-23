using System;

public class Scripture
{
    private string _book = "";
    private int _charpter;
    private int _firstVerse;
    private int _lastVerse;

    public Reference()
    {
        _book = "";
        _charpter = 0;
        _firstVerse = 0;
        _lastVerse = 0;
    }

    public Reference(string book, int chapter, int _firstVerse)
    {
        _book = book;
        _charpter = chapter;
        _firstVerse = firstVerse;
        _lastVerse = 0;
    }
}