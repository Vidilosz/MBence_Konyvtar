namespace konyvtar
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Book konyv1= new Book("Háború és béke","Lev Tolsztoj", 1300, 1835);
            Console.WriteLine(konyv1);
			konyv1.EditBookData();
			Console.WriteLine(konyv1);

            Book[] books =
        {
            new Book("A Gyűrűk Ura", "J.R.R. Tolkien", 1178, 1954),
            new Book("Harry Potter", "J.K. Rowling", 309, 1997),
            new Book("1984", "George Orwell", 328, 1949)
        };
            Book foundBook = Book.GetBookByTitle(books, "1984");
            if (foundBook != null)
            {
                Console.WriteLine($"Megtalált könyv: {foundBook.Title}, {foundBook.Author}, {foundBook.PageCount} oldal, {foundBook.ReleaseYear}.");
            }
            else
            {
                Console.WriteLine("A könyv nem található.");
            }

        }
	}
}
