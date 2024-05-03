using App;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.ConfigureServices(connectionString);

var app = builder.Build();
app.UseCors(policy => 
    {
    policy.AllowAnyHeader();
    policy.AllowAnyMethod();
    policy.AllowAnyOrigin();
});
app.MoviesEndpoints();
app.PeopleEndpoints();
app.PlanetEndpoints();
app.VehiclesEndpoints();
app.StarshipEndpoints();

app.UseSwagger();
app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "StarWarsWebApi"); });

app.UseHttpsRedirection();
app.Run();