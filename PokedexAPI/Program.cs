using Microsoft.EntityFrameworkCore;
using PokedexDb.Context;
using PokedexDb.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<PokedexDbContext>
	(
		options =>
		options.UseSqlServer(
		builder.Configuration.GetConnectionString("PokedexDbContext"))
	);
builder.Services.AddCors(policy =>
{
	policy.AddPolicy("CorsAllAccessPolicy", opt =>
	opt.AllowAnyOrigin()
	.AllowAnyHeader()
	.AllowAnyMethod()
	);
});
builder.Services.AddTransient<PokemonService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseCors("CorsAllAccessPolicy");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.Run();
