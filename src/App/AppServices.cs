namespace App;

public static class AppServices
{
    public static void ConfigureServices(this IServiceCollection services, string? connectionString)
    {
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen(options =>
        {
            options.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "StarWars Api",
                Description = "Star Wars API: explore data from characters, planets, movies, vehicles and ships from the iconic universe, integrating information for new applications.",
                Version = "v1"
            });
        });
        services.AddMediatR(c => c.RegisterServicesFromAssemblies(
            AppDomain.CurrentDomain.GetAssemblies()));
        services.AddDbContext<MayTheFourthDbContext>(options => options.UseSqlite(connectionString));
        services.AddScoped<IMovieService, MovieService>();
        services.AddScoped<IMovieRepository, MovieRepository>();
        services.AddScoped<IPeopleServices, PeopleServices>();
        services.AddScoped<IPeopleRepository, PeopleRepository>();
        services.AddScoped<IPlanetServices, PlanetServices>();
        services.AddScoped<IPlanetRepository, PlanetRepository>();
        services.AddScoped<IStarshipServices, StarshipServices>();
        services.AddScoped<IStarshipRepository, StarshipRepository>();
        services.AddScoped<IVehicleServices, VehicleServices>();
        services.AddScoped<IVehicleRepository, VehicleRepository>();
        services.AddCors();
    }
}