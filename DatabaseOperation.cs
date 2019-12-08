using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using EFCoreWebDemo;
using System.Linq;
using System;

public class DatabaseOperation {

    public void insertDataIntoDb(EFCoreDemoContext context) {
        var author1 = new Author { FirstName = "Stephen", LastName = "King" };
            var booksList1 = new List<Book> {
                new Book { Title = "It", Author = author1 },
                new Book { Title = "Carrie", Author = author1 },
                new Book { Title = "Misery", Author = author1 }
            };

            var author2 = new Author { FirstName = "Rabindranath", LastName = "Tagore" };
            var booksList2 = new List<Book> {
                new Book { Title = "Gora", Author = author2 },
                new Book { Title = "Chokher Bali", Author = author2 },
                new Book { Title = "Gitanjali", Author = author2 }
            };

            context.AddRange(booksList1);
            context.AddRange(booksList2);
            context.SaveChanges();
    }

    public void amendDataIntoDb(EFCoreDemoContext context, string FirstName) {
        var author = context.Authors.First(a => a.FirstName == FirstName);
        author.LastName = "Thakur";
        context.SaveChanges();
    }

    public void cancelDataIntoDb(EFCoreDemoContext context, string FirstName) {
        context.Remove(context.Authors.Single(a => a.FirstName == FirstName));
        context.SaveChanges();
    }

    public void findDatafromDb(EFCoreDemoContext context, string FirstName) {

        var authorAndBookList = (from a in context.Authors
                join b in context.Books on a.AuthorId equals b.AuthorId
                where a.FirstName == FirstName
                select new {
                    firstName = a.FirstName,
                    book = b.Title
                }); 

        foreach(var a in authorAndBookList) {
            Console.WriteLine("Author : " + a.firstName);
            Console.WriteLine("Book : " + a.book);
        }

    }

    public void findAllDatafromDb(EFCoreDemoContext context) {
        var authorAndBookList = (from a in context.Authors
                join b in context.Books on a.AuthorId equals b.AuthorId
                select new {
                    firstName = a.FirstName,
                    book = b.Title
                }); 

        foreach(var a in authorAndBookList) {
            Console.WriteLine("Author : " + a.firstName);
            Console.WriteLine("Book : " + a.book);
        }
    }
}