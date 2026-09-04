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

            try
            {
                int Numerator;
                int Denominator;

                Console.WriteLine("Enter the Numerator : ");
                Numerator = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the Denominator : ");
                Denominator = int.Parse(Console.ReadLine());

                double Division = Numerator / Denominator;

                Console.WriteLine($"Divison Result = {Division}");

            }
            catch (DivideByZeroException)
            {

                Console.WriteLine("You cannot divide by zero");

            }
            catch (FormatException)
            {
                Console.WriteLine("Please insert integers");
            }
            finally
            {
                Console.WriteLine("Done");
            }

            #endregion



        }
    }
}
