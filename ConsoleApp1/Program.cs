using System;
using System.Text;

namespace A2
{
    class Program
    {
        static void Main()
        {
            // Q01:
            

            string title = "clean code";

            string upperTitle = title.ToUpper();

            Console.WriteLine(title);
            Console.WriteLine(upperTitle);


            
            // Q02:
         

            string book1 = "Clean Code";
            string book2 = "Clean Code";

            Console.WriteLine(
                Object.ReferenceEquals(book1, book2)
            );


            
            // Q03:
            

            StringBuilder bookList = new StringBuilder();

            bookList.Append("Book List");
            bookList.Append(" - Updated");

            Console.WriteLine(bookList);


           
            // Q04:
           

            bookList.Replace("Book List", "Library");

            Console.WriteLine(bookList);


          
            // Q05
          

            string bookTitle = "Clean Code";
            int pages = 464;

            string sentence = "Book: " + bookTitle + ", Pages: " + pages;

            Console.WriteLine(sentence);


            
            // Q06
            

            string interpolatedSentence = $"Book: {bookTitle}, Pages: {pages}";

            Console.WriteLine(interpolatedSentence);


            
            // Q07

            string formattedSentence = string.Format(
                "Book: {0}, Pages: {1}",
                bookTitle,
                pages
            );

            Console.WriteLine(formattedSentence);


            // Q08

            int bookPages = 464;

            if (bookPages > 300)
            {
                Console.WriteLine("Long Book");
            }
            else
            {
                Console.WriteLine("Short Book");
            }


            
            // Q09

            int availableBookPages = 464;
            bool isAvailable = true;

            if (availableBookPages > 300 && isAvailable == true)
            {
                Console.WriteLine("You can borrow this book");
            }


            // Q10

            string selectedTitle = "Refactoring";

            switch (selectedTitle)
            {
                case "Clean Code":
                    Console.WriteLine("Great choice!");
                    break;

                case "Refactoring":
                    Console.WriteLine("Nice pick!");
                    break;

                default:
                    Console.WriteLine("Never heard of it");
                    break;
            }


        
            // Q11

            int pagesCount = 464;

            string sizeLabel = pagesCount > 300
                ? "Long Book"
                : "Short Book";

            Console.WriteLine(sizeLabel);


            // Books Array
            

            string[] books =
            {
                "Clean Code",
                "The Pragmatic Programmer",
                "Refactoring"
            };


            
            // Q12

            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + books[i]);
            }


            
            // Q13

            int index = 0;

            while (index < books.Length)
            {
                Console.WriteLine(books[index]);

                index++;
            }


            // Q14
            int counter = 0;

            do
            {
                Console.WriteLine("Checking book...");

                counter++;

            } while (counter < 3);


            // Q15

            foreach (string book in books)
            {
                Console.WriteLine(book);
            }

            // Q16
            foreach (string book in books)
            {
                if (book == "Refactoring")
                {
                    break;
                }

                Console.WriteLine(book);
            }


            // Q17

            foreach (string book in books)
            {
                if (book == "The Pragmatic Programmer")
                {
                    continue;
                }

                Console.WriteLine(book);
            }

            // Q18

            PrintFirstBook(books);
        }
   

        // PrintFirstBook Method
        static void PrintFirstBook(string[] books)
        {
            if (books.Length == 0)
            {
                return;
            }

            Console.WriteLine(books[0]);
        }
    }
}
