namespace RemixReview.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using RemixReview.Models;
    using Microsoft.AspNet.Identity;
    internal sealed class Configuration : DbMigrationsConfiguration<RemixReview.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(RemixReview.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            #region Music Seed
            context.Musics.AddOrUpdate(m => m.FileName,
                    new Music
                    {
                        FileName = "Ocean Lanterns",
                        Source = @"http://ocremix.org/remix/OCR03203",
                        Duration = new TimeSpan(0, 4, 9),
                        Artist = "Emunator",
                        Category = "Relaxing"
                    },

                    new Music
                    {
                        FileName = "Beneath the Surface",
                        Source = @"http://ocremix.org/remix/OCR01242",
                        Duration = new TimeSpan(0, 6, 20),
                        Artist = "Vigilante",
                        Category = "Relaxing"
                    },

                    new Music
                    {
                        FileName = "Death on the Snowfield",
                        Source = @"http://ocremix.org/remix/OCR00205",
                        Duration = new TimeSpan(0, 4, 1),
                        Artist = "AmIEviL",
                        Category= "Melancholy"
                    },

                    new Music
                    {
                        FileName = "Into the Green World",
                        Source = @"http://ocremix.org/remix/OCR02515",
                        Duration = new TimeSpan(0, 5, 40),
                        Artist = "Sam Dillard",
                        Category="Adventerous"
                    },

                    new Music
                    {
                        FileName = "Dreams of Home",
                        Source = @"http://ocremix.org/remix/OCR02608",
                        Duration = new TimeSpan(0, 2, 33),
                        Artist = "Chris | Amaterasu, waltzforluma",
                        Category="Melancholy"
                    },

                    new Music
                    {
                        FileName = "Dawn of a New Day",
                        Source = @"http://ocremix.org/remix/OCR02568",
                        Duration = new TimeSpan(0, 6, 46),
                        Artist = "Docjazz4, FunkyEntropy, Theophany, XPRTNovice",
                        Category= "Bright"
                    },

                    new Music
                    {
                        FileName = "Shikashi's Dream",
                        Source = @"http://ocremix.org/remix/OCR02481",
                        Duration = new TimeSpan(0, 5, 46),
                        Artist = "anterrior",
                        Category= "Relaxing"
                    },

                    new Music
                    {
                        FileName = "A Storm in the Desert",
                        Source = @"http://ocremix.org/remix/OCR01153",
                        Duration = new TimeSpan(0, 4, 30),
                        Artist = "Tyler Heath",
                        Category="Epic"
                    },

                    new Music
                    {
                        FileName = "Lone Star",
                        Source = @"http://ocremix.org/remix/OCR02591",
                        Duration = new TimeSpan(0, 6, 2),
                        Artist = "Pyro Paper Planes",
                        Category= "Relaxing"
                    },

                    new Music
                    {
                        FileName = "Day's End",
                        Source = @"http://ocremix.org/remix/OCR01706",
                        Duration = new TimeSpan(0, 5, 0),
                        Artist = "Sole Signal, Tweex",
                        Category="Bright"
                    },

                    new Music
                    {
                        FileName = "The Passing of the Blue Crown",
                        Source = @"http://ocremix.org/remix/OCR01723",
                        Duration = new TimeSpan(0, 4, 16),
                        Artist = "Sixto Sounds, Steppo, zircon",
                        Category= "Epic"
                    },

                    new Music
                    {
                        FileName = "Melting Sun",
                        Source = @"http://ocremix.org/remix/OCR02505",
                        Duration = new TimeSpan(0, 5, 13),
                        Artist = "Pyro Paper Planes",
                        Category="Melancholy"
                    },

                    new Music
                    {
                        FileName = "Prelude to Darkness",
                        Source = @"http://ocremix.org/remix/OCR01014",
                        Duration = new TimeSpan(0, 4, 29),
                        Artist = "Russell Cox",
                        Category="Epic"
                    },

                    new Music
                    {
                        FileName = "Return to Elysian Lands",
                        Source = @"http://ocremix.org/remix/OCR01172",
                        Duration = new TimeSpan(0, 4, 57),
                        Artist = "Nigel Simmons",
                        Category="Epic"
                    },

                    new Music
                    {
                        FileName = "Catch Me",
                        Source = @"http://ocremix.org/remix/OCR03172",
                        Duration = new TimeSpan(0, 3, 26),
                        Artist = "RoeTaKa",
                        Category= "Melancholy"
                    },

                    new Music
                    {
                        FileName = "Solitude",
                        Source = @"http://ocremix.org/remix/OCR02276",
                        Duration = new TimeSpan(0, 3, 21),
                        Artist = "zircon, C-GPO",
                        Category="Relaxing"
                    },

                    new Music
                    {
                        FileName = "Meteorites and Rabbits",
                        Source = @"http://ocremix.org/remix/OCR01944",
                        Duration = new TimeSpan(0, 3, 24),
                        Artist = "jmr",
                        Category="Relaxing"
                    },

                    new Music
                    {
                        FileName = "Sunken Suite",
                        Source = @"http://ocremix.org/remix/OCR00405",
                        Duration = new TimeSpan(0, 2, 47),
                        Artist = "djpretzel",
                        Category="Relaxing"
                    },

                    new Music
                    {
                        FileName = "A Fistful of Nickels",
                        Source = @"http://ocremix.org/remix/OCR02687",
                        Duration = new TimeSpan(0, 3, 28),
                        Artist = "zircon, XPRTNovice, Jillian Aversa, Jeff Ball",
                        Category="Adventerous"
                    },

                    new Music
                    {
                        FileName = "Rare Respite",
                        Source = @"http://ocremix.org/remix/OCR02007",
                        Duration = new TimeSpan(0, 4, 29),
                        Artist = "Andrew Lim",
                        Category="Relaxing"
                    }
                    );
            #endregion

            #region User Seed
            var PasswordHash = new PasswordHasher();
            string password = PasswordHash.HashPassword("Password123!");
            context.Users.AddOrUpdate(u => u.UserName,
                new User
                {
                    UserName = "Alice",
                    PasswordHash = password,
                    Email = "Alice@example.net"
                },

                new User
                {
                    UserName = "Bob",
                    PasswordHash = password,
                    Email = "Bob@example.net"
                },

                new User
                {
                    UserName = "Charlie",
                    PasswordHash = password,
                    Email = "Charlie@example.net"
                },

                new User
                {
                    UserName = "Don",
                    PasswordHash = password,
                    Email = "Don@example.net"
                },

                new User
                {
                    UserName = "Eve",
                    PasswordHash = password,
                    Email = "Eve@example.net"
                }

                );

            #endregion

        }
    }
}
