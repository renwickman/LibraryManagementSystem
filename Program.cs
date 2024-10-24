using System;
using System.Collections.Generic;

namespace LibraryManagementSystem{
  class Program {
    static void Main() {
      // Initialize library
      Library l = new Library();

      // Add some sample books
      Book b1 = new Book();
      b1.Title = "1984";
      b1.Author = "George Orwell";

      Book b2 = new Book();
      b2.Title = "To Kill a Mockingbird";
      b2.Author = "Harper Lee";

      Book b3 = new Book();
      b3.Title = "1984";
      b3.Author = "George Orwell";

      // Console.WriteLine(b1.Title);
      // Console.WriteLine(b1.Author);
      l.AddBook(b1);
      l.AddBook(b2);
      l.AddBook(b3);

      // Search for a book
      l.SearchBooksByTitle("1984");

      // Display all books
      l.DisplayAllBooks();

    }
  }
}