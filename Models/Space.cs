namespace MakersBnB.Models;
using System.ComponentModel.DataAnnotations;

public class Space
{
    // the ? indicates that a field can be null / blank (is nullable)
    // {get; set;} tells the compiler to create getter and setter methods
    public int Id {get; set;}
    public string? Name {get; set;}
    public string? Description {get; set;}
    public int? Price {get; set;}
    public int? Bedrooms { get; set; }
    public string Rules { get; set; } = "";
    public List<Review> Reviews { get; set; } = new List<Review>();
    public string? ImageUrl { get; set; }


    // the constructor
public Space(string name, string description, int price, string imageUrl)
    {
        Name = name;
        Description = description;
        Price = price;
        ImageUrl = imageUrl;
    }

    // a zero argument constructor is required by Entity Framework
    public Space() {}
}
