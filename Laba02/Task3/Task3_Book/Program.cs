using System;
using Task3_Book;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

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
namespace Task3_Book
{
    class Program
    {
        static void Main()
        {
            var proxy1 = new BookProxy("Alice's Adventures in Wonderland", "Lewis Carroll", "User");
            Console.WriteLine(proxy1.Get());

        }
    }
}
