using System.Xml.Serialization;

namespace C_Basics01
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region (Q1) created Book object from class Book and store it in variable type object

            //Book b = new Book();
            //Console.WriteLine("Enter Book title : ");
            //b.Title = Console.ReadLine();
            //Console.WriteLine("Enter Book Pages : ");
            //int.TryParse(Console.ReadLine(), out int num);
            //b.Pages = num;
            //object obj = b;
            //Console.WriteLine(obj);

            #endregion


            #region (Q2) Calling ToString , Equals , GetHashCode , GetType Functions

            //Book b = new Book();
            //Console.WriteLine("Enter Book title : ");
            //b.Title = Console.ReadLine();
            //Console.WriteLine("Enter Book Pages : ");
            //int.TryParse(Console.ReadLine(), out int num);
            //b.Pages = num;
            //Console.WriteLine($"Book details : {b.ToString()}");
            //Console.WriteLine(b.Equals(b));
            //Console.WriteLine(b.GetHashCode());
            //Console.WriteLine(b.GetType());

            #endregion


            #region (Q3) Checking the error Type

            // its compile time error as data type int accept only integers not anything else

            #endregion


            #region (Q4) Handling the divide by zero exception

            //try
            //{
            //    int Numerator;
            //    int Denominator;

            //    Console.WriteLine("Enter the Numerator : ");
            //    Numerator = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter the Denominator : ");
            //    Denominator = int.Parse(Console.ReadLine());

            //    double Division = Numerator / Denominator;

            //    Console.WriteLine($"Divison Result = {Division}");

            //}
            //catch (DivideByZeroException)
            //{

            //    Console.WriteLine("You cannot divide by zero");

            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Please insert integers");
            //}
            //finally
            //{
            //    Console.WriteLine("Done");
            //}

            #endregion


            #region (Q5) Convert integers to decimals
            //Console.WriteLine("Enter number of pages : ");
            //int.TryParse(Console.ReadLine(), out int Num);
            //int Pages = Num;
            //double Decimal = Pages;
            //Console.WriteLine($"Result = {Decimal}");
            #endregion


            #region (Q6) Convert decimals to integars using cast
            //Console.WriteLine("Enter Price : ");
            //double.TryParse(Console.ReadLine(), out double Num);
            //double Price = Num;
            //int Integar = (int)Price;
            //Console.WriteLine($"Converting Result = {Integar}");
            #endregion


            #region (Q7) Convert text of number (string) to integars

            //try
            //{
            //    Console.WriteLine("Enter nmuber of pages : ");
            //    string PagesText = Console.ReadLine();
            //    Convert.ToInt32(PagesText);
            //    Console.WriteLine($"Number of pages : {PagesText}");
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Invalid Input");
            //}

            #endregion


            #region (Q8)  Convert a valid string using int.Parse() and handle an invalid string using int.TryParse().
            //string YearText = "2023";
            //int Year = int.Parse(YearText);
            //Console.WriteLine($"The year is : {Year}");

            //string BadText = "abc";
            //bool Result = int.TryParse(BadText, out int Num);

            //if (!Result)
            //{
            //    Console.WriteLine($"Valid number ,{Num}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid number");
            //}
            #endregion


            #region (Q9) Convert integar numbers to string and print its type
            Console.WriteLine("Enter the number of pages ; ");
            int.TryParse(Console.ReadLine(), out int Num);
            int Pages = Num;
            string TextPages = Pages.ToString();
            Console.WriteLine(TextPages.GetType());
            #endregion









        }
    }
}
