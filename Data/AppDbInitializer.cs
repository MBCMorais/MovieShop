using MovieShop.Models;

namespace MovieShop.Data
{
    public static class AppDbInitializer
    {
        public static void Initialize(this AppDbContext dbContext)
        {
            if (!dbContext.Cinemas.Any())
            {
                dbContext.Cinemas.AddRange(new List<Cinema>()
                {
                    new Cinema()
                    {
                        Name ="Cinema2",
                        Desc="First Cinema"
                    },
                    new Cinema()
                    {
                        Name ="Cinema2",
                        Desc="Second Cinema"
                    },
                    new Cinema()
                    {
                        Name ="Cinema3",
                        Desc="Third Cinema"
                    },
                });
                dbContext.SaveChanges();
            }

            if (!dbContext.Actors.Any())
            {
                dbContext.Actors.AddRange(new List<Actor>()
                {
                    new Actor()
                    {
                        Title="actor 1",
                        Description="new actor 1 is awesome",
                        Url="https://images.unsplash.com/photo-1521119989659-a83eee488004?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=723&q=80"
                    },
                    new Actor()
                    {
                        Title="actor 2",
                        Description="new actor 2 is amazing",
                        Url="https://images.unsplash.com/photo-1474176857210-7287d38d27c6?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1470&q=80"
                    },
                    new Actor()
                    {
                        Title="actor 3",
                        Description="new actor 3 is cool",
                        Url = "https://images.unsplash.com/photo-1554727242-741c14fa561c?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80"
                    }
                });
                dbContext.SaveChanges();

            }
            if (dbContext.Producers.Any())
            {
                dbContext.Producers.AddRange(new List<Producer>()
                {
                    new Producer()
                    {
                        Title="Producer 1",
                        Description="new Producer 1 is cool",
                        Url="https://images.unsplash.com/photo-1582024959432-aee9b60ff4e8?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1470&q=80"
                    },
                    new Producer()
                    {
                        Title="Producer 1",
                        Description="new Producer 1 is cool",
                        Url = "https://images.unsplash.com/photo-1582024959432-aee9b60ff4e8?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1470&q=80"
                    },
                    new Producer()
                    {
                        Title="Producer 1",
                        Description="new Producer 1 is cool",
                        Url = "https://images.unsplash.com/photo-1582024959432-aee9b60ff4e8?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1470&q=80"
                    }
                });
                dbContext.SaveChanges();
            }
            if (dbContext.Movies.Any())
            {
                dbContext.Movies.AddRange(new List<Movie>()
                {
                    new Movie()
                    {
                        Name="I Am Legend",
                        Description="Years after a plague kills most of humanity and transforms the rest into monsters, the sole survivor in New York City..",
                        Price=14,
                        image="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRc8EZAoYO3W1LzuR80v9J-w2CHNZvis41j4w&usqp=CAU",
                        ProducerId=1,
                        CinemaId = 1,
                        StartDate= DateTime.Now.AddYears(-4).AddDays(-4),
                        EndDate = DateTime.Now.AddYears(-4).AddDays(4),
                        Category = MovieCategory.Action
                    },
                    new Movie()
                    {
                        Name="Avatar",
                        Description="A paraplegic marine dispatched to the moon Pandora on a unique mission...",
                        Price=24,
                        image="https://m.media-amazon.com/images/M/MV5BMjM2OTkyNTY3N15BMl5BanBnXkFtZTgwNzgzNDc2NjE@._V1_QL75_UY281_CR86,0,500,281_.jpg",
                        ProducerId=3,
                        CinemaId = 2,
                        StartDate= DateTime.Now.AddYears(-4).AddDays(-2),
                        EndDate = DateTime.Now.AddYears(-4).AddDays(2),
                        Category = MovieCategory.Thriller
                    },
                    new Movie()
                    {
                        Name="The Avengers",
                        Description="Earth's mightiest heroes must come together and learn to fight as a team..",
                        Price=100,
                        image="https://images.moviesanywhere.com/a36700f2ab20c7d495566843eea79dde/745c9b06-af55-4510-836d-9a320a3f26f9.jpg",
                        ProducerId= 3,
                        CinemaId = 1,
                        StartDate= DateTime.Now.AddYears(-4).AddDays(-1),
                        EndDate = DateTime.Now.AddYears(-4).AddDays(1),
                        Category = MovieCategory.Action
                    }

                });
                dbContext.SaveChanges();
            }
            if (dbContext.ActorMovies.Any())
            {
                dbContext.ActorMovies.AddRange(new List<Actor_Movie>()
                {
                    new Actor_Movie()
                    {
                        ActorId=1,
                        MovieId=2,
                    },
                     new Actor_Movie()
                    {
                        ActorId=1,
                        MovieId=2,
                    },
                      new Actor_Movie()
                    {
                        ActorId=1,
                        MovieId=2,
                    },
                       new Actor_Movie()
                    {
                        ActorId=1,
                        MovieId=2,
                    },


                });
                dbContext.SaveChanges();
            }
        }
    }
}
