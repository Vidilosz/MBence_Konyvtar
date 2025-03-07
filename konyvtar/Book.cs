using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konyvtar
{
	internal class Book
	{
		private string title;
		private string author;
		private int pageCount;
		private int releaseYear;

		public string Title { get => title; set => title = value; }
		public string Author { get => author; set => author = value; }
		public int PageCount { get => pageCount; set => pageCount = value; }
		public int ReleaseYear { get => releaseYear; set => releaseYear = value; }

		public Book(string title, string author, int pageCount, int releaseYear)
		{
			this.title = title;
			this.author = author;
			this.pageCount = pageCount;
			this.releaseYear = releaseYear;
		}

		public string GetBookByTitle(Book[])
		{

		}

		public void EditBookData()
		{
            Console.WriteLine("Title: ");
			title =Console.ReadLine();

			Console.WriteLine("Author: ");
			author =Console.ReadLine();

			Console.WriteLine("Page count: ");
			pageCount = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Release year: ");
			releaseYear = Convert.ToInt32(Console.ReadLine());
		}

		public override string? ToString()
		{
			return $"{title}/{author}/{pageCount}/{releaseYear}";
		}
	}
}
