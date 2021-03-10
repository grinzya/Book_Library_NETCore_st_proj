using Book_Library_NETCore_st_proj.Models;
using System.Linq;

namespace Book_Library_NETCore_st_proj
{
    public static class SampleData
    {
        public static void Initialize(BookLibContext context)
        {
            if(!context.Genres.Any())
            {
                context.Genres.AddRange(
                    new Genres
                    {
                        GenreName = "Приключения"
                    },
                    new Genres
                     {
                         GenreName = "Мистика"
                     }
                    );
                context.SaveChanges();
            }

            if(!context.Authors.Any())
            {
                context.Authors.AddRange(
                    new Authors
                    {
                        Name = "Морис",
                        LastName = "Леблан"
                    },
                    new Authors
                    {
                        Name = "Эдгар",
                        LastName = "По"
                    }
                    );
                context.SaveChanges();
            }

            if(!context.Books.Any())
            {
                context.Books.AddRange(
                    new Books
                    {
                        AuthorID = 1,
                        BookName = "Приключения Арсена Люпена",
                        GenreID = 1,
                        StockRemains = 20
                    },
                    new Books
                    {
                        AuthorID = 2,
                        BookName = "Маска красной смерти",
                        GenreID = 2,
                        StockRemains = 10
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
