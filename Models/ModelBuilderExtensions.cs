using System;
using Microsoft.EntityFrameworkCore;

namespace CRUD_WEB_API_SP_MVC.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(
                new Author {Id = 1, FirstName = "Wiliam", LastName = "John", BookId = 2, DateOfBirth = DateTime.Today},
                new Author {Id = 2, FirstName = "Tony", LastName = "Kichwa", BookId = 1, DateOfBirth = DateTime.Today},
                new Author
                {
                    Id = 3, FirstName = "Kondela", LastName = "Roucah", BookId = 2, DateOfBirth = DateTime.Today
                },
                new Author
                {
                    Id = 4, FirstName = "Kninn", LastName = "Johnstone", BookId = 1, DateOfBirth = DateTime.Today
                },
                new Author {Id = 5, FirstName = "Faith", LastName = "Kimba", BookId = 3, DateOfBirth = DateTime.Today}
            );

            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1, BookGenre = Genre.Drama, Title = "Dolphins TheJohn Linked", AuthorId = 1,
                    ReleaseDate = DateTime.Today, BestSeller = false
                },
                new Book
                {
                    Id = 2, BookGenre = Genre.Fiction, Title = "Johnny Walker", AuthorId = 1, ReleaseDate = DateTime.Now, BestSeller = true
                },
                new Book
                {
                    Id = 3, BookGenre = Genre.NonFiction, Title = "Bonus Life", AuthorId = 3,
                    ReleaseDate = DateTime.Now, BestSeller = false
                },
                new Book
                {
                    Id = 4, BookGenre = Genre.Fiction, Title = " Life Of A Thief", AuthorId = 4,
                    ReleaseDate = DateTime.Now, BestSeller = false
                },
                new Book
                {
                    Id = 5, BookGenre = Genre.History, Title = "Hitra Moustauche Hist", AuthorId = 5,
                    ReleaseDate = DateTime.Now, BestSeller = true
                }
            );
        }
    }
}