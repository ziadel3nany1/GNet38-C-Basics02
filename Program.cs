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

        }

    }
}