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

        public GenreEnum Genre { get; set; }
        

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

        [Display(Name = "Shooter")]
        Shooter,

        [Display(Name = "Platformer")]
        Platformer,

        [Display(Name = "Fighting")]
        Fighting,

        [Display(Name = "Survival")]
        Survival,

        [Display(Name = "Rhythm")]
        Rhythm,

        [Display(Name = "Battle Royale")]
        Battle Royale,

        [Display(Name = "Metroidvania")]
        Metroidvania,

        [Display(Name = "Adventure")]
        Adventure,

        [Display(Name = "Puzzle")]
        Puzzle,

        [Display(Name = "Tactical RPG")]
        Tactical RPG,

        [Display(Name = "Roguelike")]
        Roguelike,

        [Display(Name = "Simulation")]
        Simulation,

        [Display(Name = "Turn Based Strategy")]
        Turn Based Strategy,

        [Display(Name = "4X")]
        4X,

        [Display(Name = "Racing")]
        Racing,

        [Display(Name = "Sports")]
        Sports,

        [Display(Name = "Sandbox")]
        Sandbox,

        [Display(Name = "Party Game")]
        Party Game,

        [Display(Name = "Horror")]
        Horror,

        [Display(Name = "MOBA")]
        MOBA,

        [Display(Name = "Tabletop")]
        Tabletop,
       
    }
}