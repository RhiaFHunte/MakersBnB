namespace MakersBnB.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Review
    {
        [Key]
        public int Id {get; set;}
        public string? ReviewText {get; set;}
        public int? ReviewScore {get; set;}
        public int SpaceId { get; set;}
        public DateTime Date { get; set; } = DateTime.Now;



        public Review(int id, string reviewtext, int reviewscore)
        {
            this.Id = id;
            this.ReviewScore = reviewscore;
            this.ReviewText = reviewtext;

        }

        public Review() {}

    }