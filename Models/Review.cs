using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MakersBnB.Models;

public class Review
{
    [Key]
    public int Id { get; set; }
    public string? ReviewText { get; set; }
    public int? ReviewScore { get; set; }
    public int SpaceId { get; set; }
    public Space? Space { get; set; }
    public DateTime Date { get; set; } = DateTime.Now;

    public Review(int id, string reviewtext, int reviewscore)
    {
        Id = id;
        ReviewScore = reviewscore;
        ReviewText = reviewtext;
    }

    public Review() {}
}
