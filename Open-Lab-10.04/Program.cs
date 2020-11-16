using System;

namespace Open_Lab_10._04
{
    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR2 = new Book();
            Console.WriteLine(LOTR2.Print);

            Console.WriteLine();

            Book LOTR3 = new Book("The Fellowship of the Ring", 400);
            Console.WriteLine(LOTR3.Print);

            Console.WriteLine();

            Book HOBBIT = new Book("Hobbit", "J. R. R. Tolkien", 2012, "Adventure, Fantasy", 430);
            Console.WriteLine(HOBBIT.Print);
        }
    }
}
