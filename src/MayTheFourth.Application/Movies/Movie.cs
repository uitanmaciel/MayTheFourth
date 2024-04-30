using MayTheFourth.Application.Movies.Responses;
using MayTheFourth.Application.Peoples;
using MayTheFourth.Application.Planets;
using MayTheFourth.Application.Starships;
using MayTheFourth.Application.Vehicles;

namespace MayTheFourth.Application.Movies;

public sealed class Movie()
{
    public int Id { get; set; }
    public int Code { get; set; }
    public string Title { get; set; } = null!;
    public string Episode { get; set; } = null!;
    public string OpeningCrawl { get; set; } = null!;
    public string Director { get; set; } = null!;
    public string Producer { get; set; } = null!;
    public string ReleaseDate { get; set; } = null!;
    public int CharacterCode { get; set; }
    public int PlanetCode { get; set; }
    public int VehicleCode { get; set; }
    public int StarshipCode { get; set; }
    public IList<People> Characters { get; set; } = [];
    public IList<Planet> Planets { get; set; } = [];
    public IList<Vehicle> Vehicles { get; set; } = [];
    public IList<Starship> Starships { get; set; } = [];
    
    public Movie(
        int id,
        int code,
        string title, 
        string episode, 
        string openingCrawl, 
        string director, 
        string producer, 
        string releaseDate,
        int characterCode,
        int planetCode,
        int vehicleCode,
        int starshipCode,
        IList<People> characters, 
        IList<Planet> planets, 
        IList<Vehicle> vehicles, 
        IList<Starship> starships) : this()
    {
        Id = id;
        Code = code;
        Title = title;
        Episode = episode;
        OpeningCrawl = openingCrawl;
        Director = director;
        Producer = producer;
        ReleaseDate = releaseDate;
        CharacterCode = characterCode;
        PlanetCode = planetCode;
        VehicleCode = vehicleCode;
        StarshipCode = starshipCode;
        Characters = characters;
        Planets = planets;
        Vehicles = vehicles;
        Starships = starships;
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
            .GroupBy(m => m.Code)
            .Select(character => character.First())
            .Select(character => new MoviePeopleResponse
            {
                Code = character.Code,
                Name = character.Name
            }).ToList();
    }
    
    private static IList<MoviePlanetResponse> ToMoviePlanetResponse(Movie movie)
    {
        return movie.Planets
            .GroupBy(m => m.Code)
            .Select(planet => planet.First())
            .Select(planet => new MoviePlanetResponse
            {
                Code = planet.Code,
                Name = planet.Name
            }).ToList();
    }
    
    private static IList<MovieVehicleResponse> ToMovieVehicleResponse(Movie movie)
    {
        return movie.Vehicles
            .GroupBy(m => m.Code)
            .Select(vehicle => vehicle.First())
            .Select(vehicle => new MovieVehicleResponse
            {
                Code = vehicle.Code,
                Name = vehicle.Name
            }).ToList();
    }
    
    private static IList<MovieStarshipResponse> ToMovieStarshipResponse(Movie movie)
    {
        return movie.Starships
            .GroupBy(m => m.Code)
            .Select(starship => starship.First())
            .Select(starship => new MovieStarshipResponse
            {
                Code = starship.Code,
                Name = starship.Name
            }).ToList();
    }
}