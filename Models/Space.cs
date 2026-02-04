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

    // the constructor
    public Space(string name, string description, int price) {
        this.Name = name;
        this.Description = description;
        this.Price = price;
    }
    // a zero argument constructor is required by Entity Framework
    public Space() {}
}
