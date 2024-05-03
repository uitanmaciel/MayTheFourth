using MayTheFourth.Application.Movies.Responses;
using MayTheFourth.Application.Peoples;
using MayTheFourth.Application.Planets;
using MayTheFourth.Application.Starships;
using MayTheFourth.Application.Vehicles;

namespace MayTheFourth.Application.Movies;

public sealed class Movie()
{
    public int Id { get; private set; }
    public string Title { get; private set; } = null!;
    public short Episode { get; private set; }
    public string OpeningCrawl { get; private set; } = null!;
    public string Director { get; private set; } = null!;
    public string Producer { get; private set; } = null!;
    public string ReleaseDate { get; private set; } = null!;
    public IList<People> Characters { get; private set; } = [];
    public IList<Planet> Planets { get; private set; } = [];
    public IList<Vehicle> Vehicles { get; private set; } = [];
    public IList<Starship> Starships { get; private set; } = [];
    
    public Movie(int id, string title, short episode, string openingCrawl, string director, string producer, string releaseDate) : this()
    {
        Id = id;
        Title = title;
        Episode = episode;
        OpeningCrawl = openingCrawl;
        Director = director;
        Producer = producer;
        ReleaseDate = releaseDate;
    }
    
    public static MovieResponse ToResponse(Movie? movie) => FromModelToResponse(movie);
    public static IList<MovieResponse> ToResponse(IList<Movie> movies) => FromModelToResponse(movies);
    
    private static MovieResponse FromModelToResponse(Movie? movie)
    {
        if (movie is null) return new MovieResponse();
        
        return new MovieResponse
        {
            Title = movie.Title,
            Episode = movie.Episode,
            OpeningCrawl = movie.OpeningCrawl,
            Director = movie.Director,
            Producer = movie.Producer,
            ReleaseDate = movie.ReleaseDate,
            Peoples = ToMoviePeopleResponse(movie),
            Planets = ToMoviePlanetResponse(movie),
            Vehicles = ToMovieVehicleResponse(movie),
            Starships = ToMovieStarshipResponse(movie)
        };
    }
    
    private static IList<MovieResponse> FromModelToResponse(IList<Movie> movies)
    {
        return movies.Select(FromModelToResponse).ToList();
    }

    private static IList<MoviePeopleResponse> ToMoviePeopleResponse(Movie movie)
    {
        return movie.Characters
            .Select(character => new MoviePeopleResponse
            {
                Id = character.Id,
                Name = character.Name
            }).ToList();
    }
    
    private static IList<MoviePlanetResponse> ToMoviePlanetResponse(Movie movie)
    {
        return movie.Planets
            .Select(planet => new MoviePlanetResponse
            {
                Id = planet.Id,
                Name = planet.Name
            }).ToList();
    }
    
    private static IList<MovieVehicleResponse> ToMovieVehicleResponse(Movie movie)
    {
        return movie.Vehicles
            .Select(vehicle => new MovieVehicleResponse
            {
                Id = vehicle.Id,
                Name = vehicle.Name
            }).ToList();
    }
    
    private static IList<MovieStarshipResponse> ToMovieStarshipResponse(Movie movie)
    {
        return movie.Starships
            .Select(starship => new MovieStarshipResponse
            {
                Id = starship.Id,
                Name = starship.Name
            }).ToList();
    }
}