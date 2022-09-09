using Blog.API.Interfaces;
using Blog.API.Repositories;
using Blog.API.Settings;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.Configure<MongoDbSettings>(
    builder.Configuration.GetSection("BlogDatabase"));
builder.Services.AddSingleton<IPostRepo,MongoDbPostRepo>();
builder.Services.AddSingleton<IAuthorRepo,MongoDbAuthorRepo>();
builder.Services.AddRouting(options => options.LowercaseUrls = true);
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
