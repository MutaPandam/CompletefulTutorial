using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    // class used to create movie objects that will be stored in the database and displayed on the movies page.
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string? Genre { get; set; }
        public decimal Price { get; set; }

    }
}
