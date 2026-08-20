namespace Library.Api;

public record Book
{
    

    public int Id { get; set; }

    public string Author {get; set;} = string.Empty;

    public DateTime PublishedDate { get; set; }

    public string Title { get; set; } = string.Empty;
}
