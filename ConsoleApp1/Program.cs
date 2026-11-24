Book myBook = new Book();

// Q1
// Console.WriteLine(myBook.password);

// Q2
Console.WriteLine(myBook.copiesInStock);

// Q3
myBook.Title = "Clean Code";
Console.WriteLine(myBook.Title);

// Q4
myBook.BookGenre = Genre.Science;
Console.WriteLine(myBook.BookGenre);

// Q5
Console.WriteLine((int)Genre.Fiction);
Console.WriteLine((int)Genre.NonFiction);
Console.WriteLine((int)Genre.Science);

// Q6
int genreNumber = 1;
Genre castedGenre = (Genre)genreNumber;
Console.WriteLine(castedGenre);

// Q7
Genre genre = Genre.Fiction;
string genreString = genre.ToString();
Console.WriteLine(genreString);

// Q8
string genreText = "Science";
Genre parsedGenre = (Genre)Enum.Parse(typeof(Genre), genreText);
Console.WriteLine(parsedGenre);

// Q9
string invalidGenreText = "Mystery";
if (Enum.TryParse(invalidGenreText, out Genre resultGenre))
{
    Console.WriteLine(resultGenre);
}
else
{
    Console.WriteLine("Unknown genre");
}

enum Genre
{
    Fiction,
    NonFiction,
    Science
}

class Book
{
    private string password = "secret";
    internal int copiesInStock = 5;
    public string Title { get; set; }
    public string Author { get; set; }
    public int Pages { get; set; }
    public Genre BookGenre { get; set; }

    public Book()
    {
    }

    public Book(string title, string author, int pages)
    {
        Title = title;
        Author = author;
        Pages = pages;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, Pages: {Pages}");
    }
}

