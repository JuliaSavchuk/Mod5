namespace Mod5
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }

        public override string ToString()
        {
            return $"{Title} by {Author} ({Year})";
        }

        public override bool Equals(object obj)
        {
            if (obj is Book book)
            {
                return Title == book.Title && Author == book.Author && Year == book.Year;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Title, Author, Year);
        }

        public static bool operator ==(Book b1, Book b2)
        {
            return b1.Equals(b2);
        }

        public static bool operator !=(Book b1, Book b2)
        {
            return !b1.Equals(b2);
        }
    }

}
