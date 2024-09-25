class Book
{
  public string _name;
  public string _auther;
  public bool _renting;
  public Book(string name, string auther, bool isRenting = false)
  {
    _name = name;
    _auther = auther;
    _renting = isRenting;
  }
}

class Library
{
  public Dictionary<int, Book> _bookDict = new Dictionary<int, Book>();

  public Library()
  {
    _importDefaultBooks();
  }

  public void ShowBookList()
  {
    foreach (var singleBookDict in _bookDict)
    {
      Console.WriteLine(singleBookDict.Value._name);
    }
    Console.WriteLine("");
  }

  public void SearchBooks(string keyword, bool isRenting = false)
  {
    var result = _bookDict
      .Where(x => x.Value._name == keyword)
      .Where(x => x.Value._renting == isRenting);

    foreach (KeyValuePair<int, Book> book in result)
    {
      Console.WriteLine(string.Join(" ", book.Value._name));
    }
    Console.WriteLine("");
  }

  public void FindRentingBooks(bool rent)
  {
    var result = _bookDict.Where(x => x.Value._renting == rent);
    foreach (KeyValuePair<int, Book> book in result)
    {
      Console.WriteLine(string.Join(" ", book.Value._name));
    }
    Console.WriteLine("");
  }

  public void ImportBookWithNextId(Book book, bool isRenting = false)
  {
    _bookDict.Add(_bookDict.Count + 1, book);
  }

  void _importDefaultBooks()
  {
    ImportBookWithNextId(new Book("Maps of meaning", "J"));
    ImportBookWithNextId(new Book("Welden", "S"));
    ImportBookWithNextId(new Book("하늘과 바람과 별과 인간", "김상욱", true));
    ImportBookWithNextId(new Book("카라마조프가의 형제들", "도스토"));
    ImportBookWithNextId(new Book("죄 와 벌", "도스토", true));
  }
}