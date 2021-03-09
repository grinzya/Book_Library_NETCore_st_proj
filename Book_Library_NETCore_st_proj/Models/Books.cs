namespace Book_Library_NETCore_st_proj.Models
{
    public class Books
    {
        public int ID { get; set; }
        public string BookName { get; set; }

        public int AuthorID { get; set; }
        public Authors Author { get; set; }

        public int StockRemains { get; set; }

        public int GenreID { get; set; }
        public Genres Genre { get; set; }
    }
}
