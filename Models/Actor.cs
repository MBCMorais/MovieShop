using System.ComponentModel.DataAnnotations;

namespace MovieShop.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Url { get; set; }
         
        public List<Movie>? Movies { get; set;}

        public List<Actor_Movie> ActorsMovies { get; set;}
        
    }
}
