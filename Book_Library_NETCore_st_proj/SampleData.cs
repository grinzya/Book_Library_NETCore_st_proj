using Book_Library_NETCore_st_proj.Models;
using System.Linq;

namespace Book_Library_NETCore_st_proj
{
    public static class SampleData
    {
        public static void Initialize(BookLibContext context)
        {
            if(!context.Books.Any())
            {
                context.Books.AddRange(
                    new Books
                    {
                        AuthorID = 1,
                        BookName = "Приключения Арсена Люпена",
                        GenreID = 1,
                        StockRemains = 20
                    }
                    );
            }
        }
    }
}
