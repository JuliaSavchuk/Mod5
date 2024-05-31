namespace Mod5
{
    class ReadingList
    {
        private List<Book> books = new List<Book>();

        public Book this[int index]
        {
            get { return books[index]; }
            set { books[index] = value; }
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }

        public bool ContainsBook(Book book)
        {
            return books.Contains(book);
        }

        public void DisplayBooks()
        {
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
