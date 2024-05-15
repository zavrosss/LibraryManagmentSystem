using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using LibraryManagmentSystem.Data;
using System;
using System.Linq;

namespace LibraryManagmentSystem.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LibraryManagmentSystemContext(
                serviceProvider.GetRequiredService<DbContextOptions<LibraryManagmentSystemContext>>()))
            {
                if (context.Library.Any())
                {
                    return;
                }

                context.Library.AddRange(

                    new Library
                    {
                        Title = "Harry Potter",
                        Author = "J.K.Rowling",
                        PublicationDate = "1997",
                        Genre = "Fantastic",
                    },

                    new Library
                    {
                        Title = "Bridget Jones's Diary",
                        Author = "Helen Fielding",
                        PublicationDate = "1996",
                        Genre = "Romantic",
                    },

                    new Library
                    {
                        Title = "The Silence of the Lambs",
                        Author = "Thomas Harris",
                        PublicationDate = "1988",
                        Genre = "Thriller",
                    },

                    new Library
                    {
                        Title = "The Lord of the Rings",
                        Author = "J.R.R. Tolkien",
                        PublicationDate = "1954",
                        Genre = "Fantasy",
                    },

                    new Library
                    {
                        Title = "The Girl with the Dragon Tattoo",
                        Author = "Stieg Larsson",
                        PublicationDate = "1997",
                        Genre = "Thriller",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
