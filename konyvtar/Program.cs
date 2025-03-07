namespace konyvtar
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Book konyv1= new Book("Háború és béke","Lev Tolsztoj", 1300, 1835);

			konyv1.EditBookData();
			Console.WriteLine(konyv1);

        }
	}
}
