using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;
using TodoApi.Model;
using TodoApi.Routes;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<TodoDb>(opt => opt.UseInMemoryDatabase("TodoList"));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "AllowBlazorOrigins",
        builder =>
        {
            builder.WithOrigins("https://localhost:7134",
                                "http://localhost:5026")
                .WithHeaders(HeaderNames.ContentType)
                .AllowAnyMethod();
        });
});

var app = builder.Build();
app.UseCors("AllowBlazorOrigins");

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapTodoRoutes();

app.Run();

