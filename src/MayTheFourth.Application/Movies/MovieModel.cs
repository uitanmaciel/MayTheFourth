using MayTheFourth.Application.Peoples;
using MayTheFourth.Application.Planets;
using MayTheFourth.Application.Starships;
using MayTheFourth.Application.Vehicles;

namespace MayTheFourth.Application.Movies;

public sealed class MovieModel()
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string Episode { get; set; } = null!;
    public string OpeningCrawl { get; set; } = null!;
    public string Director { get; set; } = null!;
    public string Producer { get; set; } = null!;
    public DateTime ReleaseDate { get; set; }
    public IList<PeopleModel> Characters { get; set; } = null!;
    public IList<PlanetModel> Planets { get; set; } = null!;
    public IList<VehicleModel> Vehicles { get; set; } = null!;
    public IList<StarshipModel> Starships { get; set; } = null!;
    
    public MovieModel(
        int id, 
        string title, 
        string episode, 
        string openingCrawl, 
        string director, 
        string producer, 
        DateTime releaseDate, 
        IList<PeopleModel> characters, 
        IList<PlanetModel> planets, 
        IList<VehicleModel> vehicles, 
        IList<StarshipModel> starships) : this()
    {
        Id = id;
        Title = title;
        Episode = episode;
        OpeningCrawl = openingCrawl;
        Director = director;
        Producer = producer;
        ReleaseDate = releaseDate;
        Characters = characters;
        Planets = planets;
        Vehicles = vehicles;
        Starships = starships;
    }
}