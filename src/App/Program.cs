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

var app = builder.Build();
app.MoviesEndpoints();
app.PeopleEndpoints();
app.PlanetEndpoints();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "StarWarsWebApi"); });
}

app.UseHttpsRedirection();
app.Run();