namespace Books.Classes
{
    public class Literature
    {
        public string Name {get; set;}
        public string Author {get; set;}
        public int Price {get; set;}

        public Literature( string name )
        {
            Name = name;
            Author = "";
            Price = 0;
        }

        public void PrintInfo(string Author, int Price)
        {
            Console.WriteLine($"Detailes: \n Name : {Name} \n Author : {Author} \n Price : {Price}");
        }
    }
}