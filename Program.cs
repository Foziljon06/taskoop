using Books.Classes;
namespace Books
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(" Welcome to the task ");
            Literature aBook  = new  Literature(name: " Muqaddima" );
            Console.WriteLine($" This book is {aBook.Name}");
            aBook.Author = " A famous person";
            aBook.Price = 10;
            aBook.PrintInfo(Author: " A Man ", Price : 20);

        }
    }
}
