using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using EFCoreWebDemo;

public class DatabaseOperation {

    public void insertDataIntoDb(DbContext context) {
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

    public void amendDataIntoDb(string FirstName) {

    }

    public void cancelDataIntoDb(string FirstName) {

    }

    public void findDatafromDb(string FirstName) {

    }

    public void findAllDatafromDb() {

    }


}