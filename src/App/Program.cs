var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMediatR(c => c.RegisterServicesFromAssemblies(
    AppDomain.CurrentDomain.GetAssemblies()));
builder.Services.AddDbContext<MayTheFourthDbContext>(options => options.UseSqlite(connectionString));
builder.Services.AddScoped<IMovieService, MovieService>();
builder.Services.AddScoped<IMovieRepository, MovieRepository>();
builder.Services.AddScoped<IPeopleServices, PeopleServices>();
builder.Services.AddScoped<IPeopleRepository, PeopleRepository>();
builder.Services.AddScoped<IPlanetServices, PlanetServices>();
builder.Services.AddScoped<IPlanetRepository, PlanetRepository>();
builder.Services.AddScoped<IStarshipServices, StarshipServices>();
builder.Services.AddScoped<IStarshipRepository, StarshipRepository>();
builder.Services.AddScoped<IVehicleServices, VehicleServices>();
builder.Services.AddScoped<IVehicleRepository, VehicleRepository>();

var app = builder.Build();
app.MoviesEndpoints();
app.PeopleEndpoints();
app.PlanetEndpoints();
app.VehiclesEndpoints();
app.StarshipEndpoints();

app.UseSwagger();
app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "StarWarsWebApi"); });

app.UseHttpsRedirection();
app.Run();