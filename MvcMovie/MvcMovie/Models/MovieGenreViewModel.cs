using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models
{
    public class MovieGenreViewModel
    {
        public List<Movie>? Movies { get; set; } // list of movies
        public SelectList? Genres { get; set; } // list of genres
        public string? MovieGenre { get; set; } // selected genre
        public string? SearchString { get; set; } // text user entered to search bar
    }
}
