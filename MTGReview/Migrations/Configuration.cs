namespace RemixReview.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using RemixReview.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
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

            #region Role Seed

            if (!context.Roles.Any(r => r.Name == "Site Admin"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Site Admin" };

                manager.Create(role);
            }

            if (!context.Roles.Any(r => r.Name == "Music Admin"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Music Admin" };

                manager.Create(role);
            }

            if (!context.Roles.Any(r => r.Name == "Reviewer"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Reviewer" };

                manager.Create(role);
            }

            if (!context.Roles.Any(r => r.Name == "User"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "User" };

                manager.Create(role);
            }

            #endregion

            #region User Seed

            #region UserStore Users
                //this method of seeding users (using the user store) comes from http://blog.falafel.com/seed-database-initial-users-mvc-5/
                if (!(context.Users.Any(u => u.UserName == "siteadmin@rmxreviews.com")))
                {
                    var userStore = new UserStore<User>(context);
                    var userManager = new UserManager<User>(userStore);
                    var userToInsert = new User { UserName = "siteadmin@rmxreviews.com", FirstName = "Site", LastName = "Admin", Age = 23, Email = "siteadmin@rmxreviews.com" };
                    userManager.Create(userToInsert, "Rmx123!");
                    userManager.AddToRole(userToInsert.Id, "Site Admin");
                }

                if (!(context.Users.Any(u => u.UserName == "musicadmin@rmxreviews.com")))
                {
                    var userStore = new UserStore<User>(context);
                    var userManager = new UserManager<User>(userStore);
                    var userToInsert = new User { UserName = "musicadmin@rmxreviews.com", FirstName = "Music", LastName = "Admin", Age = 58, Email = "musicadmin@rmxreviews.com" };
                    userManager.Create(userToInsert, "Rmx123!");
                    userManager.AddToRole(userToInsert.Id, "Music Admin");
                }

                if (!(context.Users.Any(u => u.UserName == "reviewer@rmxreviews.com")))
                {
                    var userStore = new UserStore<User>(context);
                    var userManager = new UserManager<User>(userStore);
                    var userToInsert = new User { UserName = "reviewer@rmxreviews.com", FirstName = "Basic", LastName = "Reviewer", Age = 16, Email = "reviewer@rmxreviews.com" };
                    userManager.Create(userToInsert, "Rmx123!");
                    userManager.AddToRole(userToInsert.Id, "Reviewer");
                }

                if (!(context.Users.Any(u => u.UserName == "user@rmxreviews.com")))
                {
                    var userStore = new UserStore<User>(context);
                    var userManager = new UserManager<User>(userStore);
                    var userToInsert = new User { UserName = "user@rmxreviews.com", FirstName = "Basic", LastName = "User", Age = 3, Email = "user@rmxreviews.com" };
                    userManager.Create(userToInsert, "Rmx123!");
                    userManager.AddToRole(userToInsert.Id, "User");
                } 
            #endregion

            #region Legacy Users
            var PasswordHash = new PasswordHasher();
                string password = PasswordHash.HashPassword("Password123!");
                context.Users.AddOrUpdate(u => u.UserName,
                    new User
                    {
                        UserName = "Alice",
                        PasswordHash = password,
                        Email = "Alice@example.net",
                        FirstName = "Alice",
                        LastName = "Exampleson",
                        Age = 21
                    },

                    new User
                    {
                        UserName = "Bob",
                        PasswordHash = password,
                        Email = "Bob@example.net",
                        FirstName = "Bob",
                        LastName = "Exampleson",
                        Age = 21
                    },

                    new User
                    {
                        UserName = "Charlie",
                        PasswordHash = password,
                        Email = "Charlie@example.net",
                        FirstName = "Charlie",
                        LastName = "Exampleson",
                        Age = 21
                    },

                    new User
                    {
                        UserName = "Don",
                        PasswordHash = password,
                        Email = "Don@example.net",
                        FirstName = "Don",
                        LastName = "Exampleson",
                        Age = 21
                    },

                    new User
                    {
                        UserName = "Eve",
                        PasswordHash = password,
                        Email = "Eve@example.net",
                        FirstName = "Eve",
                        LastName = "Exampleson",
                        Age = 21
                    }

                    );
            #endregion

            #endregion

            #region Album Seed

            context.Albums.AddOrUpdate(a => a.Title,

                new Album
                {
                    Title = "Vampire Variations: A Musical Tribute to Castlevania",
                    HomepageLink = @"http://vampire.ocremix.org/",
                    ImageLink = @"http://ocremix.org/thumbs/500/files/images/albums/7/1/67-181.png"
                },

                new Album
                {
                    Title = "Vampire Variations: Volume II",
                    HomepageLink = @"http://vampire.ocremix.org/",
                    ImageLink = @"http://ocremix.org/thumbs/500/files/images/albums/8/2/68-182.png"
                },

                new Album
                {
                    Title = "Vampire Variations: Volume III",
                    HomepageLink = @"http://vampire.ocremix.org/",
                    ImageLink = @"http://ocremix.org/thumbs/500/files/images/albums/9/3/69-183.png"
                },

                new Album
                {
                    Title = "Super Cartography Bros.",
                    HomepageLink = @"http://cartography.ocremix.org/",
                    ImageLink = @"http://ocremix.org/thumbs/500/files/images/albums/0/4/70-184.png"
                },

                new Album
                {
                    Title = "Heart of a Gamer: A Tribute to Satoru Iwata",
                    HomepageLink = @"http://ocremix.org/info/Heart_of_a_Gamer:_A_Tribute_to_Satoru_Iwata",
                    ImageLink= @"http://ocremix.org/thumbs/500/files/images/albums/1/5/71-185.png"
                },

                new Album
                {
                    Title = "Badass: Boss Themes: Volume III",
                    HomepageLink = @"http://badass3.ocremix.org/",
                    ImageLink= @"http://ocremix.org/thumbs/500/files/images/albums/2/8/72-188.png"
                }
                );

            #endregion

        }
    }
}
