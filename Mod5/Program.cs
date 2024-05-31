namespace Mod5 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Task 1-----\n");
            Journal journal1 = new Journal("Science Today", 1990, "Science Magazine", "123-456-7890", "contact@sciencetoday.com", 100);
            Journal journal2 = new Journal("Tech World", 2000, "Technology Magazine", "098-765-4321", "info@techworld.com", 150);

            journal1.DisplayData();
            journal2.DisplayData();

            Console.WriteLine("\nAfter adding employees:");
            journal1 += 10;
            journal1.DisplayData();

            Console.WriteLine("\nComparison of journals based on the number of employees:");
            Console.WriteLine(journal1 == journal2 ? "Both journals have the same number of employees." : "The journals have a different number of employees.");
            Console.WriteLine(journal1 < journal2 ? "Journal1 has fewer employees than Journal2." : "Journal1 has more or the same number of employees as Journal2."); ;

            Console.WriteLine("\n\n-----Task 2-----\n");
            Store store1 = new Store("TechStore", "123 Tech Ave", "Electronics", "123-456-7890", "contact@techstore.com", 2500);
            Store store2 = new Store("BookStore", "456 Book St", "Books", "098-765-4321", "info@bookstore.com", 1800);

            store1.DisplayData();
            store2.DisplayData();

            Console.WriteLine("\nAfter increasing area:");
            store1 += 300;
            store1.DisplayData();

            Console.WriteLine("\nComparison of stores based on area:");
            Console.WriteLine(store1 == store2 ? "Both stores have the same area." : "The stores have different areas.");
            Console.WriteLine(store1 < store2 ? "Store1 is smaller than Store2." : "Store1 is larger or equal to Store2.");

            Console.WriteLine("\n\n-----Task 3-----\n");
            ReadingList readingList = new ReadingList();

            readingList.AddBook(new Book("1984", "George Orwell", 1949));
            readingList.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", 1960));

            readingList.DisplayBooks();

            Book bookToCheck = new Book("1984", "George Orwell", 1949);
            Console.WriteLine(readingList.ContainsBook(bookToCheck) ? "Book is in the list." : "Book is not in the list.");

            readingList.RemoveBook(bookToCheck);

            readingList.DisplayBooks();
        }
    }
}
