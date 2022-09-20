using Microsoft.EntityFrameworkCore;
using ForTh3Win.Data;

namespace ForTh3Win.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ForTh3WinContext(
                serviceProvider.GetRequiredService<DbContextOptions<ForTh3WinContext>>()))
            {
                if (context == null || context.Review == null)
                    throw new ArgumentNullException("Null ForTh3WinContext");

                // look for existing reviews
                if (context.Review.Any())
                    return; // db already seeded

                context.Review.AddRange(
                    new Review
                    {
                        GameName = "Age of Empires 2 Definitive Edition",
                        Publisher = "Forgotten Empire",
                        Reviewer = "Russell",
                        Genre = GenreEnum.RealTimeStrategy,
                        ReleaseDate = DateTime.Parse("2019-11-14"),
                        Description = "Age of Empires II: Definitive Edition celebrates the 20th anniversary of one of the most popular strategy games ever, now with stunning 4K Ultra HD graphics, and a fully remastered soundtrack. Age of Empires II: DE features “The Last Khans” with 3 new campaigns and 4 new Civilizations.",
                        ReviewerRating = 4.0,
                        ESRBRating = ESRBEnum.Teen,
                        ReviewText = "This remaster of the classic Age of Empires 2 brings back all the best parts of this game with updated graphics, better AI and more ways to play with friends. A must have if you loved this game 20 years ago."
                    }//,
                    // more reviews here
                );
                context.SaveChanges();
            }
        }
    }
}
