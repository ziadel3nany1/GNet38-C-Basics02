namespace FirstAssignment
{
    class Book
    {
        public string Title;
        public int Pages;
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            #region Question 1
            // 1. Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a variable of type object. Print it.
            Book book = new Book();
            book.Title = "Harry Potter";
            book.Pages = 50;
            object obj = book;
            Console.WriteLine(obj);
            #endregion

            #region Question 2
            //Using the Book class above, print the result of calling ToString(), Equals() (compare book with itself), GetHashCode(), and GetType() on book.

            Console.WriteLine(book.ToString());
            Console.WriteLine(obj.Equals(book));
            Console.WriteLine(book.GetHashCode());
            Console.WriteLine(book.GetType());

            #endregion

            #region Question 3
            //Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it
            // it is a compile-time error
            // int Pages = 464;
            #endregion

            #region Question 4
            //4.Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by zero", and then prints "Done" in a finally block.
            try
            {
                int zero = 0;
                int result = 10 / zero;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            finally
            {
                Console.WriteLine("Done");
            }

            #endregion

            #region Question 5
            //5.Declare an int pages = 300; then store it in a double variable without using a cast.
            int Pages = 300;
            double Pages_To_Double = Pages;
            Console.WriteLine(Pages_To_Double);

            #endregion

            #region Question 6

            //6.Declare a double price = 49.99; then convert it into an int using a cast.

            double Price = 49.99;
            int Price_To_Int = (int)Price;
            Console.WriteLine(Price_To_Int);

            #endregion

            #region Question 7

            //7.Given string pagesText = "464";, convert it into an int using the Convert class.
            string PagesText = "464";
            int Pages_To_Int = Convert.ToInt32(PagesText);
            Console.WriteLine(Pages_To_Int);

            #endregion

            #region Question 8
            //8.Given string yearText = "2023";, convert it using int.Parse(). Then given string badText = "abc";
            //, use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.

            string YearText = "2023";
            int Year = int.Parse(YearText);
            Console.WriteLine(Year);

            string BadText = "abc";
            int.TryParse(BadText, out int Text_To_Int);
            Console.WriteLine(Text_To_Int);

            #endregion

            #region Question 9
            //9.Given int pages = 464;, convert it into a string using ToString() and print its type using GetType() to prove it's now a string.

            Pages = 464;
            string Pages_In_String = Pages.ToString();
            Console.WriteLine(Pages_In_String);
            Console.WriteLine(Pages_In_String.GetType());

            #endregion

            #region Question 10
            //10.Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int variable, and print both.

            int Copies = 100;
            object For_Boxing = Copies;

            int For_Unboxing = (int)For_Boxing;
            Console.WriteLine(For_Boxing);
            Console.WriteLine(For_Unboxing);

            #endregion
        }

    }
}