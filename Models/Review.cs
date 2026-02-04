namespace MakersBnB.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Review
    {
        [Key]
        public int Id {get; set;}
        public string? ReviewText {get; set;}
        public int? ReviewScore {get; set;}

        public Review(int id, string reviewtext, int reviewscore)
        {
            this.Id = id;
            this.ReviewText = reviewtext;
            this.ReviewScore = reviewscore;
        }

        public Review() {}

    }