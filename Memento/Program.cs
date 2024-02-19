
#region main

Book book = new Book()
{
    Title = "Togarma'nın Çocukları",
    Author = "Ibn-i Fadlan",
    ISBN = "1234_1234_1234_1234"
};

book.ShowBook();
Thread.Sleep(1500);

CareTaker history = new CareTaker();
history.Memento = book.CreateUndo();

book.ISBN = "4321_4321_4321_4321";

book.ShowBook();
Thread.Sleep(1500);

book.RestoreFromUndo(history.Memento);

book.ShowBook();
Thread.Sleep(1500);

#endregion


class Book
{
    private string _title;
    private string _author;
    private string _isbn;
    private DateTime _lastEdited;

    public string Title
    {
        get => _title;
        set
        {
            _title = value;
            SetLastEdited();
        }
    }
    public string Author
    {
        get => _author;
        set
        {
            _author = value;
            SetLastEdited();
        }
    }
    public string ISBN
    {
        get => _isbn;
        set
        {
            _isbn = value;
            SetLastEdited();
        }
    }

    private void SetLastEdited()
    {
        _lastEdited = DateTime.UtcNow;
    }

    public Memento CreateUndo()
    {
        return new Memento(_title, _author, _isbn, _lastEdited);
    }

    public void RestoreFromUndo(Memento memento)
    {
        _title = memento.Title;
        _author = memento.Author;
        _isbn = memento.ISBN;
        _lastEdited = memento.LastEdited;
    }

    public void ShowBook()
    {
        Console.WriteLine($"BookInfo");
        Console.WriteLine("Title: {0}\nAuthor: {1}\nISBN: {2}\nLast Edited: {3}\n",
            _title, _author, _isbn, _lastEdited);
    }
}

class Memento
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public DateTime LastEdited { get; set; }

    public Memento(string title, string author, string iSBN, DateTime lastEdited)
    {
        Title = title;
        Author = author;
        ISBN = iSBN;
        LastEdited = lastEdited;
    }
}

class CareTaker
{
    public Memento Memento { get; set; }
}
