using System.ComponentModel.DataAnnotations;

namespace ForTh3Win.Models
{
    public class Review
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Game Name")]
        public string GameName { get; set; } = String.Empty;

        [Required]
        public string Publisher { get; set; } = String.Empty;

        [StringLength(30)]
        public string Reviewer { get; set; } = String.Empty;

        [Required]
        [StringLength(500)]
        public string Description { get; set; } = String.Empty;

        [Required]
        [Range(0, 5)]
        [Display(Name = "Reviewer Rating")]
        public double ReviewerRating { get; set; }

        [Required]
        [StringLength(500)]
        [Display(Name = "Review")]
        public string ReviewText { get; set; } = String.Empty;

        [Display(Name = "ESRB Rating")]
        public ESRBEnum ESRBRating { get; set; }

        public GenreEnum Genre { get; set; }
        
        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
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
        Mature,

        [Display(Name = "Not Rated")]
        NotRated,
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
        BattleRoyale,

        [Display(Name = "Metroidvania")]
        Metroidvania,

        [Display(Name = "Adventure")]
        Adventure,

        [Display(Name = "Puzzle")]
        Puzzle,

        [Display(Name = "Tactical RPG")]
        TacticalRPG,

        [Display(Name = "Roguelike")]
        Roguelike,

        [Display(Name = "Simulation")]
        Simulation,

        [Display(Name = "Turn Based Strategy")]
        TurnBasedStrategy,

        [Display(Name = "4X")]
        FourX,

        [Display(Name = "Racing")]
        Racing,

        [Display(Name = "Sports")]
        Sports,

        [Display(Name = "Sandbox")]
        Sandbox,

        [Display(Name = "Party Game")]
        PartyGame,

        [Display(Name = "Horror")]
        Horror,

        [Display(Name = "MOBA")]
        MOBA,

        [Display(Name = "Tabletop")]
        Tabletop,

        [Display(Name = "Role Playing Game")]
        RPG,
       
    }
}