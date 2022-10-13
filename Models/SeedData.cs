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
                    }
                    ,
                    new Review
                    {
                         GameName = "Fallout 76: The Pitt",
                         Publisher = "Bethesda",
                         Reviewer = "Russell",
                         Genre = GenreEnum.MassivelyMultiplayer,
                         ReleaseDate = DateTime.Parse("2020-04-14"),
                         Description = "Twenty-five years after the bombs fell, you and your fellow Vault Dwellers—chosen from the nation’s best and brightest – emerge into post-nuclear America on Reclamation Day, 2102.",
                         ReviewerRating = 2.5,
                         ESRBRating = ESRBEnum.Mature,
                         ReviewText = "This game was a massive disappointment when it released, high promises were met with a half finished game, created on an old engine, with players wandering around a lonely world. Since its release the game has been given many updates and has improved, but it stands as one of the reasons to never pre order a game."
                    },
                    new Review
                    {
                        GameName = "Call of Duty Modern Warfare 2",
                        Publisher = "Infinity Ward",
                        Reviewer = "Russell",
                        Genre = GenreEnum.Shooter ,
                        ReleaseDate = DateTime.Parse("2009-11-12"),
                        Description = "The most-anticipated game of the year and the sequel to the best-selling first-person action game of all time, Modern Warfare 2 continues the gripping and heart-racing action as players face off against a new threat dedicated to bringing the world to the brink of collapse.",
                        ReviewerRating = 4.75,
                        ESRBRating = ESRBEnum.Mature,
                        ReviewText = "This game stands the test of time as not only one of the greatest shooters of all time, but also one of the greatest multiplayer experiences. A nigh perfect story alongside an equally fantastic online multiplayer experience makes this game a must own."
                    },
                    new Review
                    {
                         GameName = "Celeste",
                         Publisher = "Extremely OK Games Ltd.",
                         Reviewer = "Russell",
                         Genre = GenreEnum.Platformer ,
                         ReleaseDate = DateTime.Parse("2018-01-25"),
                         Description = "Help Madeline survive her inner demons on her journey to the top of Celeste Mountain, in this super-tight platformer. Brave hundreds of hand-crafted challenges, uncover devious secrets, and piece together the mystery of the mountain.",
                         ReviewerRating = 4.5,
                         ESRBRating = ESRBEnum.EveryoneTenPlus,
                         ReviewText = "A heartwarming and exceptionally sweet story accompanies this gruelingly difficult platformer. Celeste is a game you will come back to over and over. All this is accompanied with a fantastic soundtrack that will make you open your spotify. Well worth $20."
                    },
                    new Review
                    {
                        GameName = "Mortal Combat 11",
                        Publisher = "NetherRealm Studios",
                        Reviewer = "Russell",
                        Genre = GenreEnum.Fighting ,
                        ReleaseDate = DateTime.Parse("2019-04-23"),
                        Description = "Mortal Kombat is back and better than ever in the next evolution of the iconic franchise.",
                        ReviewerRating = 3.5,
                        ESRBRating = ESRBEnum.Mature,
                        ReviewText = "A classic beat-em up fighter with all your favorites to break your enemies bones and kill them in increasingly silly ways. If you like fighting games, grab it when its on sale."
                    },
                    new Review
                     {
                         GameName = "Subnautica",
                         Publisher = "Unknown Worlds Entertainment",
                         Reviewer = "Russell",
                         Genre = GenreEnum.Survival,
                         ReleaseDate = DateTime.Parse("2018-01-23"),
                         Description = "Descend into the depths of an alien underwater world filled with wonder and peril. Craft equipment, pilot submarines and out-smart wildlife to explore lush coral reefs, volcanoes, cave systems, and more - all while trying to survive.",
                         ReviewerRating = 4.8,
                         ESRBRating = ESRBEnum.EveryoneTenPlus,
                         ReviewText = "One of the most engaging, beautiful, terrifying, and absolutely fantastic games to ever be created. Fun from literally the beginning to the end this game seems to have little to say, until you keep delving deeper and deeper into the dark depths of the water. Do yourself a favor. Get this game."
                    },
                    new Review
                    {
                        GameName = "Beat Saber",
                        Publisher = "Beat Games",
                        Reviewer = "Russell",
                        Genre = GenreEnum.Rhythm,
                        ReleaseDate = DateTime.Parse("2019-05-21"),
                        Description = "Beat Saber is a VR rhythm game where you slash the beats of adrenaline-pumping music as they fly towards you, surrounded by a futuristic world.",
                        ReviewerRating = 4.0,
                        ESRBRating = ESRBEnum.Everyone,
                        ReviewText = "A fantastic VR game that gets the player moving to the beat and having a blast slashing at cubes flying towards them. A little niche, but a lot of fun."
                    },
                    new Review
                    {
                        GameName = "Apex Legends",
                        Publisher = "Respawn Entertainment",
                        Reviewer = "Russell",
                        Genre = GenreEnum.BattleRoyale,
                        ReleaseDate = DateTime.Parse("2020-11-04"),
                        Description = "Apex Legends is the award-winning, free-to-play Hero Shooter from Respawn Entertainment. Master an ever-growing roster of legendary characters with powerful abilities, and experience strategic squad play and innovative gameplay in the next evolution of Hero Shooter and Battle Royale.",
                        ReviewerRating = 4.3,
                        ESRBRating = ESRBEnum.Mature,
                        ReviewText = "There is a reason that Apex Legends is a massively successful game. Its just plain fun. Constantly changing playable chartacters and weapons make this game fun for ages and ages."
                    },
                    new Review
                    {
                        GameName = "Control",
                        Publisher = "Remedy Entertainment",
                        Reviewer = "Russell",
                        Genre = GenreEnum.Metroidvania,
                        ReleaseDate = DateTime.Parse("2020-08-27"),
                        Description = "Winner of over 80 awards, Control is a visually stunning third-person action-adventure that will keep you on the edge of your seat.",
                        ReviewerRating = 4.6,
                        ESRBRating = ESRBEnum.Mature,
                        ReviewText = "A new spin on a Metroidvania, this game has incredible visuals, exciting gameplay and a story that will leave you thinking about it for days."
                    },
                    new Review
                    {
                        GameName = "The Witcher 3: Wild Hunt",
                        Publisher = "CD PROJEKT RED",
                        Reviewer = "Russell",
                        Genre = GenreEnum.Adventure,
                        ReleaseDate = DateTime.Parse("2015-05-18"),
                        Description = "As war rages on throughout the Northern Realms, you take on the greatest contract of your life — tracking down the Child of Prophecy, a living weapon that can alter the shape of the world.",
                        ReviewerRating = 4.0,
                        ESRBRating = ESRBEnum.Mature,
                        ReviewText = "What can be said about The Witcher 3 that hasn't already been said? This game is a staple for the genre and a must play if you enjoy Adventure games."
                    },
                    new Review
                    {
                        GameName = "Inside",
                        Publisher = "Playdead",
                        Reviewer = "Russell",
                        Genre = GenreEnum.Puzzle,
                        ReleaseDate = DateTime.Parse("2016-06-07"),
                        Description = "Hunted and alone, a boy finds himself drawn into the center of a dark project. INSIDE is a dark, narrative-driven platformer combining intense action with challenging puzzles. It has been critically acclaimed for its moody art style, ambient soundtrack and unsettling atmosphere.",
                        ReviewerRating = 4.7,
                        ESRBRating = ESRBEnum.Mature,
                        ReviewText = "A puzzle adventure that feeds you a story tiny pieces at a time, without ever explaining to you exactly what is happening. Thouroughly enjoyable with an extremely weird and satisfying ending."
                    },
                    new Review
                    {
                        GameName = "Divinity Original Sin 2",
                        Publisher = "Larian Studios",
                        Reviewer = "Russell",
                        Genre = GenreEnum.TacticalRPG,
                        ReleaseDate = DateTime.Parse("2017-09-14"),
                        Description = "The critically acclaimed RPG that raised the bar, from the creators of Baldur's Gate 3. Gather your party. Master deep, tactical combat. Venture as a party of up to four - but know that only one of you will have the chance to become a God.",
                        ReviewerRating = 3.5,
                        ESRBRating = ESRBEnum.Mature,
                        ReviewText = "An exceptionally in depth Tactical RPG that brings the fun of having friends into the equation. If you like turn based combat. Grab this one when its on sale."
                    },
                    new Review
                    {
                        GameName = "Hades",
                        Publisher = "Supergiant Games",
                        Reviewer = "Russell",
                        Genre = GenreEnum.Roguelike,
                        ReleaseDate = DateTime.Parse("2020-09-17"),
                        Description = "Defy the god of the dead as you hack and slash out of the Underworld in this rogue-like dungeon crawler from the creators of Bastion, Transistor, and Pyre.",
                        ReviewerRating = 4.0,
                        ESRBRating = ESRBEnum.Mature,
                        ReviewText = "Multiple GoTY award winning Hades is a blast for those that love roguelikes and those that are unfamiliar with it. Sit down, kill everything around you and have fun while you do it."
                    },
                    new Review
                    {
                        GameName = "Microsoft Flight Simulator",
                        Publisher = "Asobo Studio",
                        Reviewer = "Russell",
                        Genre = GenreEnum.Simulation,
                        ReleaseDate = DateTime.Parse("2020-04-17"),
                        Description = "Microsoft Flight Simulator Game of the Year (GOTY) Edition offers 5 all-new aircrafts, 8 new handcrafted airports, 6 new Discovery Flights, new tutorials, and updates to the weather system. GOTY Edition is free for existing users. The sky is calling!",
                        ReviewerRating = 4.5,
                        ESRBRating = ESRBEnum.Everyone,
                        ReviewText = "The most immersive and beautiful flight simulator ever created. Maps of the world that are absolutely, stunningly realistic. "
                    },
                     new Review
                     {
                         GameName = "Sid Meier's Civilization 6",
                         Publisher = "Firaxis",
                         Reviewer = "Russell",
                         Genre = GenreEnum.TurnBasedStrategy,
                         ReleaseDate = DateTime.Parse("2016-10-21"),
                         Description = "Civilization VI is the newest installment in the award winning Civilization Franchise. Expand your empire, advance your culture and go head-to-head against history’s greatest leaders. Will your civilization stand the test of time?",
                         ReviewerRating = 4.8,
                         ESRBRating = ESRBEnum.EveryoneTenPlus,
                         ReviewText = "After thousands of hours being put into this game I can say it comes highly recommended if you enjoy that feeling of losing countless hours and having no recollection of it."
                     },
                     new Review
                     {
                         GameName = "Stellaris",
                         Publisher = "Paradox Studios",
                         Reviewer = "Russell",
                         Genre = GenreEnum.FourX,
                         ReleaseDate = DateTime.Parse("2016-05-09"),
                         Description = "Explore a galaxy full of wonders in this sci-fi grand strategy game from Paradox Development Studios. Interact with diverse alien races, discover strange new worlds with unexpected events and expand the reach of your empire. Each new adventure holds almost limitless possibilities.",
                         ReviewerRating = 4.8,
                         ESRBRating = ESRBEnum.EveryoneTenPlus,
                         ReviewText = "An absolutely midblowing amount of choices await you in this incredibly immersive and extremely difficult game. Will you get angry? Yes. Will you get frustrated? Yes. Will you dream about it? Yes."
                     },
                      new Review
                      {
                          GameName = "Trials Fusion",
                          Publisher = "RedLynx",
                          Reviewer = "Russell",
                          Genre = GenreEnum.Racing,
                          ReleaseDate = DateTime.Parse("2014-04-24"),
                          Description = "Trials Fusion is the gold-standard platform racer for the next-generation of gaming. Built upon the Trials franchise’s proven gameplay foundations, Fusion challenges players endlessly in both classic and all-new ways.",
                          ReviewerRating = 4.0,
                          ESRBRating = ESRBEnum.EveryoneTenPlus,
                          ReviewText = "A ridiculously silly and fun dirtbike racing game. Compete against your friends times while trying to get through increasingly difficult courses."
                      },
                      new Review
                      {
                          GameName = "Golf with your Friends",
                          Publisher = "Blacklight Interactive",
                          Reviewer = "Russell",
                          Genre = GenreEnum.Sports,
                          ReleaseDate = DateTime.Parse("2020-05-19"),
                          Description = "Why have friends if not to play Golf... With Your Friends! Nothing is out of bounds as you take on courses filled with fast paced, exciting, simultaneous mini golf for up to 12 players!",
                          ReviewerRating = 3.5,
                          ESRBRating = ESRBEnum.Everyone,
                          ReviewText = "A silly fun golfing adventure with your friends. Grab it and have a blast!"
                      },
                      new Review
                      {
                          GameName = "Rimworld",
                          Publisher = "Ludeon Studios",
                          Reviewer = "Russell",
                          Genre = GenreEnum.Sandbox,
                          ReleaseDate = DateTime.Parse("2018-10-17"),
                          Description = "A sci-fi colony sim driven by an intelligent AI storyteller. Generates stories by simulating psychology, ecology, gunplay, melee combat, climate, biomes, diplomacy, interpersonal relationships, art, medicine, trade, and more.",
                          ReviewerRating = 4.0,
                          ESRBRating = ESRBEnum.Mature,
                          ReviewText = "A sandbox game where you can lose immediately. This game is stragely addicting and silly, while still being a blast."
                      },
                      new Review
                      {
                          GameName = "Mario Party",
                          Publisher = "Hudson Soft",
                          Reviewer = "Russell",
                          Genre = GenreEnum.PartyGame,
                          ReleaseDate = DateTime.Parse("1999-02-08"),
                          Description = "Mario Party is a party video game featuring six playable characters: Mario, Luigi, Princess Peach, Yoshi, Wario, and Donkey Kong. In the game's frame story, Mario and his friends argue about which of them is the \"Super Star\", a figure upon whom the entire world can rely. To settle their dispute, they set out for adventure to determine which of them is most worthy of the title.",
                          ReviewerRating = 4.0,
                          ESRBRating = ESRBEnum.Everyone,
                          ReviewText = "The ultimate palm destroyer!"
                      },
                      new Review
                      {
                          GameName = "Little Nightmares",
                          Publisher = "Tarsier Studios",
                          Reviewer = "Russell",
                          Genre = GenreEnum.Horror,
                          ReleaseDate = DateTime.Parse("2017-04-27"),
                          Description = "Immerse yourself in Little Nightmares, a dark whimsical tale that will confront you with your childhood fears! Help Six escape The Maw – a vast, mysterious vessel inhabited by corrupted souls looking for their next meal.",
                          ReviewerRating = 4.5,
                          ESRBRating = ESRBEnum.Mature,
                          ReviewText = "An absolutely horrifying game, complete with fun puzzles, tiny little gnome people you can hug and cannabalism! If you like being scared, check this one out."
                      },
                      new Review
                      {
                          GameName = "Dota 2",
                          Publisher = "Valve",
                          Reviewer = "Russell",
                          Genre = GenreEnum.MOBA,
                          ReleaseDate = DateTime.Parse("2013-07-09"),
                          Description = "Every day, millions of players worldwide enter battle as one of over a hundred Dota heroes. And no matter if it's their 10th hour of play or 1,000th, there's always something new to discover. With regular updates that ensure a constant evolution of gameplay, features, and heroes, Dota 2 has taken on a life of its own.",
                          ReviewerRating = 3.5,
                          ESRBRating = ESRBEnum.Teen,
                          ReviewText = "I haven't played this!"
                      },
                      new Review
                      {
                          GameName = "Terraforming Mars",
                          Publisher = "Twin Sails Interactive",
                          Reviewer = "Russell",
                          Genre = GenreEnum.Tabletop,
                          ReleaseDate = DateTime.Parse("2018-10-17"),
                          Description = "The taming of the Red Planet has begun! Corporations are competing to transform Mars into a habitable planet by spending vast resources and using innovative technology to raise temperature, create a breathable atmosphere, and make oceans of water.",
                          ReviewerRating = 4.1,
                          ESRBRating = ESRBEnum.Everyone,
                          ReviewText = "If you can't dedicate 4 hours of your life to a board game, this is a good workaround."
                      },
                      new Review
                      {
                          GameName = "MultiVersus",
                          Publisher = "Warner Bros. Games",
                          Reviewer = "Kyle",
                          Genre = GenreEnum.Fighting,
                          ReleaseDate = DateTime.Parse("2022-07-19"),
                          Description = "MultiVersus is a free-to-play platform fighter that lets you team up with your friends using some of the most iconic characters including Batman, Shaggy, & more!",
                          ReviewerRating = 4.5,
                          ESRBRating = ESRBEnum.Teen,
                          ReviewText = "A team-focused take on the platform fighter genre with all kinds of characters to suit any playstyle. It can be a little buggy at times, and some may dislike its floaty nature, but this is a game you'll want to try! Best of all, it's free!"
                      },
                      new Review
                      {
                          GameName = "Path of Exile",
                          Publisher = "Grinding Gear Games",
                          Reviewer = "Kyle",
                          Genre = GenreEnum.RPG,
                          ReleaseDate = DateTime.Parse("2013-10-23"),
                          Description = "You are an Exile, struggling to survive on the dark continent of Wraeclast, as you fight to earn power that will allow you to exact your revenge against those who wronged you. Created by hardcore gamers, Path of Exile is an online Action RPG set in a dark fantasy world.",
                          ReviewerRating = 4.4,
                          ESRBRating = ESRBEnum.Mature,
                          ReviewText = "What started as a spiritual successor to Blizzard's Diablo 2 has now become so much more, and what some consider to be the king of the Action RPG genre. Updated every 3 months with a full-reset \"league\" format, this game can keep you grinding for hours."
                      },
                      new Review
                      {
                          GameName = "Gunfire Reborn",
                          Publisher = "Duoyi Games",
                          Reviewer = "Kyle",
                          Genre = GenreEnum.Roguelike,
                          ReleaseDate = DateTime.Parse("2021-11-17"),
                          Description = "Gunfire Reborn is a level-based adventure game featuring FPS, Roguelite and RPG. Players can control heroes with various abilities to experience diverse Build gameplay, use various weapons to explore procedurally-generated levels. You can play the game alone, or join 4-player coop.",
                          ReviewerRating = 4.1,
                          ESRBRating = ESRBEnum.NotRated,
                          ReviewText = "A clean hybrid of the FPS and Roguelite genres bring a Borderlands-feeling game with tons of build optoins, level encounters, and bossfights. No two runs are the same!"
                      },
                      new Review
                      {
                          GameName = "Overwatch 2",
                          Publisher = "Blizzard Entertainment",
                          Reviewer = "Kyle",
                          Genre = GenreEnum.Shooter,
                          ReleaseDate = DateTime.Parse("2022-10-04"),
                          Description = "Overwatch 2 is a hero shooter, where players are split into two teams and select a \"hero\" from a roster of 35 characters. Characters are organized into a \"damage\" class, responsible for offensive efforts; a \"support\" class, responsible for healing and buffing; and a \"tank\" class, responsible for the team's protection. Each character has a unique set of skills, made up of active, passive, and ultimate abilities.",
                          ReviewerRating = 3.5,
                          ESRBRating = ESRBEnum.Teen,
                          ReviewText = "While there have been imporvements in the hero shooter format since its predecessor Overwatch, this mostly feels like a fresh coat of paint over the same vehicle. It's fun and fresh, but I'd really like to see how the PvE mode looks when it releases later."
                      },
                      new Review
                      {
                          GameName = "Super Meat Boy",
                          Publisher = "Team Meat",
                          Reviewer = "Kyle",
                          Genre = GenreEnum.Platformer,
                          ReleaseDate = DateTime.Parse("2010-11-30"),
                          Description = "Super Meat Boy is a tough as nails platformer where you play as an animated cube of meat who's trying to save his girlfriend (who happens to be made of bandages) from an evil fetus in a jar wearing a tux.",
                          ReviewerRating = 4.7,
                          ESRBRating = ESRBEnum.Teen,
                          ReviewText = "Super tight controls, tons of levels to play, new characters to unlock, walls to slide on and jump from, frustration to be had from restarting a level 300 times, and best of all: the pride of finally completing that level. A rightfully infuriating experience that I'd recommend to anyone."
                      }

                /*Seed data template

               new Review
               {
                   GameName = "",
                        Publisher = "",
                        Reviewer = "",
                        Genre = GenreEnum.,
                        ReleaseDate = DateTime.Parse(""),
                        Description = "",
                        ReviewerRating = ,
                        ESRBRating = ESRBEnum.,
                        ReviewText = ""
               } 

                */
                // more reviews here
                );
                context.SaveChanges();
            }
        }
    }
}
