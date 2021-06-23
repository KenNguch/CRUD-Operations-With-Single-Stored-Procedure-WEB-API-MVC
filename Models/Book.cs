using System;

namespace CRUD_WEB_API_SP_MVC.Models
{
    public enum Genre
    {
        Fiction,
        NonFiction,
        History,
        Drama,
    }

    public class Book
    {
        public int Id { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public bool BestSeller { get; set; }
        public Genre BookGenre { get; set; }
    }
}