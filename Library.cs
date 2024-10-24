using System;
using System.Collections.Generic;

namespace LibraryManagementSystem{
  class Library {
    private List<Book> books = new List<Book>();

    // Book book = new Book();
    
    public void AddBook(Book book){
      books.Add(book);
    }

    public void SearchBooksByTitle(string s){
      List<Book> results = new List<Book>();
      foreach (Book b in books){
        if (b.Title.Contains(s)){
          results.Add(b);
          Console.WriteLine($"{b.Title} - {b.Author}");
        }
        
      }
  
    }

    public void DisplayAllBooks(){
      foreach (Book b in books){
        Console.WriteLine(b.Title);
        Console.WriteLine(b.Author);
        Console.WriteLine("");
      }
      
    }
    
  }
}