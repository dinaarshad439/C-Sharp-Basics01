using System.Xml.Serialization;

namespace C_Basics01
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region (Q1) created Book object from class Book and store it in variable type object

            Book b = new Book();
            Console.WriteLine("Enter Book title : ");
            b.Title = Console.ReadLine();
            Console.WriteLine("Enter Book Pages : ");
            int.TryParse(Console.ReadLine(), out int num);
            b.Pages = num;
            object obj = b;
            Console.WriteLine(obj);

            #endregion

        }
    }
}
