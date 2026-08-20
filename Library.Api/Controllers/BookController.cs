using Microsoft.AspNetCore.Mvc;

namespace Library.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class BookController : ControllerBase
{
    private static readonly string[] Summaries =
    [
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    ];

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<Book> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new Book
        {
            PublishedDate = DateTime.Now.AddDays(index),
            Id = Random.Shared.Next(-20, 55),
            Title = Summaries[Random.Shared.Next(Summaries.Length)],
            Author = "me"
        })
        .ToArray();
    }
}
