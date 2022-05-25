using System;
using System.Collections.Generic;

Book book1 = new Book()
{
    Author = "Stephen King", Title = "The Shining", PublishDate = new DateTime(1990, 2, 14), NumberOfPages = 200
};
Book book2 = new Book()
{
    Author = "Sylvia Plath", Title = "The Bell Jar", PublishDate = new DateTime(2002, 10, 20), NumberOfPages = 250
};
Book book3 = new Book()
{
    Author = "Martin Fowler", Title = "Refactoring", PublishDate = new DateTime(2013, 5, 21), NumberOfPages = 180
};

List<Book> bookList = new List<Book>();

bookList.Add(book1);
bookList.Add(book2);
bookList.Add(book3);

foreach (var book in bookList)
{
    Console.WriteLine($"{book.Title} by {book.Author}");
}

public class Book 
{
    public string Author { get; set; }
    public string Title { get; set; }
    public DateTime PublishDate { get; set; }
    public int NumberOfPages { get; set; }
}