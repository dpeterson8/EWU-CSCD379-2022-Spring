using Microsoft.EntityFrameworkCore;
using Wordle.Api.Data;
using Wordle.Api.Services;

var builder = WebApplication.CreateBuilder(args);

//Change CORS policy

string allowance = "AllowAll";

var allowAll = builder.Services.AddCors(options => {
    options.AddPolicy(allowance, builder => 
        builder.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader());
});


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ILeaderBoardService, LeaderBoardServiceMemory>();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddScoped<ScoreStatsService>();
builder.Services.AddScoped<PlayersService>();
builder.Services.AddScoped<GameService>();

var app = builder.Build();

//Create database
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    context.Database.Migrate();
    PlayersService.Seed(context);
    Word.SeedWords(context);
}
// Configure the HTTP request pipeline.
<<<<<<< HEAD
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
=======
//if (app.Environment.IsDevelopment())
//{
app.UseSwagger();
app.UseSwaggerUI();
//}
>>>>>>> main

app.UseHttpsRedirection();

app.UseCors(allowance);

app.UseAuthorization();

app.MapControllers();

app.Run();
