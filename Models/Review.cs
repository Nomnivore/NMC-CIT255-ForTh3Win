using System.ComponentModel.DataAnnotations;

namespace ForTh3Win.Models
{
    public class Review
    {
        public int ID { get; set; }

        [Required]
        [StringLength(30)]
        public string GameName { get; set; } = String.Empty;

        [Required]
        public string Publisher { get; set; } = String.Empty;

        [StringLength(30)]
        public string Reviewer { get; set; } = String.Empty;

        [Required]
        public string Description { get; set; } = String.Empty;

        [Required]
        [Range(0, 10)]
        public double ReviewerRating { get; set; }

        [Required]
        [StringLength(500)]
        public string ReviewText { get; set; } = String.Empty;

        public ESRBEnum ESRBRating { get; set; }

        public List<GenreEnum> Genres { get; set; } = new List<GenreEnum>();
        

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

    }

    public enum ESRBEnum
    {
        [Display(Name = "Everyone (E)")]
        Everyone,

        [Display(Name = "Everyone 10+ (E10+)")]
        EveryoneTenPlus,

        [Display(Name = "Teen (T)")]
        Teen,

        [Display(Name = "Mature (M)")]
        Mature
    }

    public enum GenreEnum
    {
        // list from Project proposal, display name necessary for multi-word genres

        [Display(Name = "Real Time Strategy")]
        RealTimeStrategy,

        [Display(Name = "Massively Multiplayer")]
        MassivelyMultiplayer,

        Shooter,
        Platformer,

        //etc
    }
}