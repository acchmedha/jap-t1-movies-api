using JAP_Task_1_MoviesApi.Models;
using JAP_Task_1_MoviesApi.Services.AuthService;
using Microsoft.EntityFrameworkCore;
using System;


namespace JAP_Task_1_MoviesApi.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            #region Actor static data
            modelBuilder.Entity<Actor>().HasData(
                new Actor { Id = 1, Name = "Morgan", Surname = "Freeman" },
                new Actor { Id = 2, Name = "Bob", Surname = "Gunton" },
                new Actor { Id = 3, Name = "Tim", Surname = "Robbins" },
                new Actor { Id = 4, Name = "Marlon", Surname = "Brando" },
                new Actor { Id = 5, Name = "Al", Surname = "Pacino" },
                new Actor { Id = 6, Name = "James", Surname = "Caan" },
                new Actor { Id = 7, Name = "Robert", Surname = "De Niro" },
                new Actor { Id = 8, Name = "Robert", Surname = "Duvall" },
                new Actor { Id = 9, Name = "Christian", Surname = "Bale" },
                new Actor { Id = 10, Name = "Heath", Surname = "Ledger" },
                new Actor { Id = 11, Name = "Aaron", Surname = "Eckhart" },
                new Actor { Id = 12, Name = "Henry", Surname = "Fonda" },
                new Actor { Id = 13, Name = "Lee", Surname = "J. Cobb" },
                new Actor { Id = 14, Name = "Martin", Surname = "Balsam" },
                new Actor { Id = 15, Name = "Liam", Surname = "Neeson" },
                new Actor { Id = 16, Name = "Ralph", Surname = "Fiennes" },
                new Actor { Id = 17, Name = "Ben", Surname = "Kingsley" },
                new Actor { Id = 18, Name = "Elijah", Surname = "Wood" },
                new Actor { Id = 19, Name = "Viggo", Surname = "Mortensen" },
                new Actor { Id = 20, Name = "Ian", Surname = "McKellen" },
                new Actor { Id = 21, Name = "John", Surname = "Travolta" },
                new Actor { Id = 22, Name = "Uma", Surname = "Thurman" },
                new Actor { Id = 23, Name = "Samuel", Surname = "L. Jackson" },
                new Actor { Id = 24, Name = "Clint", Surname = "Eastwood" },
                new Actor { Id = 25, Name = "Eli", Surname = "Wallach" },
                new Actor { Id = 26, Name = "Lee", Surname = "Van Cleef" },
                new Actor { Id = 27, Name = "Orlando", Surname = "Bloom" },
                new Actor { Id = 28, Name = "Brad", Surname = "Pitt" },
                new Actor { Id = 29, Name = "Edward", Surname = "Norton" },
                new Actor { Id = 30, Name = "Meat", Surname = "Loaf" },
                new Actor { Id = 31, Name = "Tom", Surname = "Hanks" },
                new Actor { Id = 32, Name = "Robin", Surname = "Wright" },
                new Actor { Id = 33, Name = "Gary", Surname = "Sinise" },
                new Actor { Id = 34, Name = "Leonardo", Surname = "DiCaprio" },
                new Actor { Id = 35, Name = "Joseph", Surname = "Gordon-Levitt" },
                new Actor { Id = 36, Name = "Elliot", Surname = "Page" },
                new Actor { Id = 37, Name = "David", Surname = "Attenborough" },
                new Actor { Id = 38, Name = "Sigourney", Surname = "Weaver" },
                new Actor { Id = 39, Name = "Nikolay", Surname = "Drozdov" },
                new Actor { Id = 40, Name = "Bryan", Surname = "Cranston" },
                new Actor { Id = 41, Name = "Aaron", Surname = "Paul" },
                new Actor { Id = 42, Name = "Anna", Surname = "Gunn" },
                new Actor { Id = 43, Name = "Scott", Surname = "Grimes" },
                new Actor { Id = 44, Name = "Damian", Surname = "Lewis" },
                new Actor { Id = 45, Name = "Ron", Surname = "Livingston" },
                new Actor { Id = 46, Name = "Jessie", Surname = "Buckley" },
                new Actor { Id = 47, Name = "Jared", Surname = "Harris" },
                new Actor { Id = 48, Name = "Stellan", Surname = "Skarsgard" },
                new Actor { Id = 49, Name = "Jessie", Surname = "Buckley" },
                new Actor { Id = 50, Name = "Dominic", Surname = "West" },
                new Actor { Id = 51, Name = "Lance", Surname = "Reddick" },
                new Actor { Id = 52, Name = "Sonja", Surname = "Sohn" },
                new Actor { Id = 53, Name = "Peter", Surname = "Drost" },
                new Actor { Id = 54, Name = "Roger", Surname = "Horrocks" },
                new Actor { Id = 55, Name = "Neil", Surname = "deGrasse Tyson" },
                new Actor { Id = 56, Name = "Stoney", Surname = "Emshwiller" },
                new Actor { Id = 57, Name = "Piotr", Surname = "Michael" },
                new Actor { Id = 58, Name = "Neil", Surname = "deGrasse Tyson" },
                new Actor { Id = 59, Name = "Dee", Surname = "Bradley Baker" },
                new Actor { Id = 60, Name = "Zach", Surname = "Tyler" },
                new Actor { Id = 61, Name = "Mae", Surname = "Whitman" },
                new Actor { Id = 62, Name = "Carl", Surname = "Sagan" },
                new Actor { Id = 63, Name = "Jaromir", Surname = "Hanzlik" },
                new Actor { Id = 64, Name = "Jonathan", Surname = "Fahn" },
                new Actor { Id = 65, Name = "Emilia", Surname = "Clarke" },
                new Actor { Id = 66, Name = "Peter", Surname = "Dinklage" },
                new Actor { Id = 67, Name = "Kit", Surname = "Harington" },
                new Actor { Id = 68, Name = "James", Surname = "Gandolfini" },
                new Actor { Id = 69, Name = "Lorraine", Surname = "Bracco" },
                new Actor { Id = 70, Name = "Eddie", Surname = "Falco" }
            );
            #endregion

            #region Movies static data
            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    Id = 1,
                    Title = "The Suicide Squad",
                    PosterPath = "https://image.tmdb.org/t/p/w500/iXbWpCkIauBMStSTUT9v4GXvdgH.jpg",
                    ReleaseDate = new DateTime(2021, 7, 28),
                    Overview = "Supervillains Harley Quinn, Bloodsport, Peacemaker and a collection of nutty cons at Belle Reve " +
                    "prison join the super-secret, super-shady Task Force X as they are dropped off at the remote, enemy-infused " +
                    "island of Corto Maltese."         
                },
                new Movie
                {
                    Id = 2,
                    Title = "Sweet Girl",
                    PosterPath = "https://image.tmdb.org/t/p/w500/cP7odDzzFBD9ycxj2laTeFWGLjD.jpg",
                    ReleaseDate = new DateTime(2021, 8, 18),
                    Overview =  "A devastated husband vows to bring justice to the people responsible for his wife's death while " +
                    "protecting the only family he has left, his daughter."
                },
                new Movie
                {
                    Id = 3,
                    Title = "Jungle Cruise",
                    PosterPath = "https://image.tmdb.org/t/p/w500/9dKCd55IuTT5QRs989m9Qlb7d2B.jpg",
                    ReleaseDate = new DateTime(2021, 7,8),
                    Overview = "Dr. Lily Houghton enlists the aid of wisecracking skipper Frank Wolff to take her down the Amazon " +
                    "in his dilapidated boat. Together, they search for an ancient tree that holds the power to heal – a discovery " +
                    "that will change the future of medicine."             
                },
                new Movie
                {
                    Id = 4,
                    Title = "PAW Patrol: The Movie",
                    PosterPath = "https://image.tmdb.org/t/p/w500/ic0intvXZSfBlYPIvWXpU1ivUCO.jpg",
                    ReleaseDate = new DateTime(2021, 8, 9),
                    Overview = "Ryder and the pups are called to Adventure City to stop Mayor Humdinger from turning the bustling " +
                    "metropolis into a state of chaos..."       
                },
                new Movie
                {
                    Id = 5,
                    Title = "Eggs Run",
                    PosterPath = "https://image.tmdb.org/t/p/w500/wrlQnKHLCBheXMNWotyr5cVDqNM.jpg",
                    ReleaseDate = new DateTime(2021, 8, 12),
                    Overview = "A rooster and his fowl partner embark on a dangerous trip to the Congo to recover their stolen eggs " +
                    "from a group of Russian goons."     
                },
                new Movie
                {
                    Id = 6,
                    Title = "Black Widow",
                    PosterPath = "https://image.tmdb.org/t/p/w500/qAZ0pzat24kLdO3o8ejmbLxyOac.jpg",
                    ReleaseDate = new DateTime(2021, 7, 7),
                    Overview = "Natasha Romanoff, also known as Black Widow, confronts the darker parts of her ledger when a " +
                    "dangerous conspiracy with ties to her past arises. Pursued by a force that will stop at nothing to bring " +
                    "her down, Natasha must deal with her history as a spy and the broken relationships left in her wake long " +
                    "before she became an Avenger."     
                },
                new Movie
                {
                    Id = 7,
                    Title = "Space Jam: A New Legacy",
                    PosterPath = "https://image.tmdb.org/t/p/w500/5bFK5d3mVTAvBCXi5NPWH0tYjKl.jpg",
                    ReleaseDate = new DateTime(2021, 7, 8),
                    Overview = "When LeBron and his young son Dom are trapped in a digital space by a rogue A.I., LeBron must get " +
                    "them home safe by leading Bugs, Lola Bunny and the whole gang of notoriously undisciplined Looney Tunes to " +
                    "victory over the A.I.'s digitized champions on the court. It's Tunes versus Goons in the highest-stakes " +
                    "challenge of his life."   
                },
                new Movie
                {
                    Id = 8,
                    Title = "Narco Sub",
                    PosterPath = "https://image.tmdb.org/t/p/w500/7p0O4mKYLIhU2E5Zcq9Z3vOZ4e9.jpg",
                    ReleaseDate = new DateTime(2021, 7, 22),
                    Overview = "A man will become a criminal to save his family.  Director: Shawn Welling  Writer: Derek H. Potts  " +
                    "Stars: Tom Vera, Tom Sizemore, Lee Majors |" 
                },
                new Movie
                {
                    Id = 9,
                    Title = "Free Guy",
                    PosterPath = "https://image.tmdb.org/t/p/w500/hEqw9swA8gFJuNjgWYEypwZfkZg.jpg",
                    ReleaseDate = new DateTime(2021, 8, 2),
                    Overview = "A bank teller called Guy realizes he is a background character in an open world video game called " +
                    "Free City that will soon go offline."   
                },
                new Movie
                {
                    Id = 10,
                    Title = "Infinite",
                    PosterPath = "https://image.tmdb.org/t/p/w500/niw2AKHz6XmwiRMLWaoyAOAti0G.jpg",
                    ReleaseDate = new DateTime(2021, 6, 10),
                    Overview = "Evan McCauley has skills he never learned and memories of places he has never visited. Self-medicated " +
                    "and on the brink of a mental breakdown, a secret group that call themselves “Infinites” come to his rescue, " +
                    "revealing that his memories are real."     
                },
                new Movie
                {
                    Id = 11,
                    Title = "Beckett",
                    PosterPath = "https://image.tmdb.org/t/p/w500/fBJducGBcmrcIOQdhm4BUBNDiMu.jpg",
                    ReleaseDate = new DateTime(2021, 8, 4),
                    Overview = "Whilst vacationing in Greece, Beckett, becomes the target of a manhunt after a devastating car " +
                    "accident forces him to run for his life across the country to clear his name but tensions escalate as the " +
                    "authorities close in and political unrest mounts which makes Beckett fall even deeper into a dangerous web " +
                    "of conspiracy."
                },
                 new Movie
                 {
                     Id = 12,
                     Title = "F9",
                     PosterPath = "https://image.tmdb.org/t/p/w500/bOFaAXmWWXC3Rbv4u4uM9ZSzRXP.jpg",
                     ReleaseDate = new DateTime(2021, 5, 19),
                     Overview = "Dominic Toretto and his crew battle the most skilled assassin and high-performance driver they've " +
                     "ever encountered: his forsaken brother."
                 },
                 new Movie
                 {
                     Id = 13,
                     Title = "The Boss Baby",
                     PosterPath = "https://image.tmdb.org/t/p/w500/kv2Qk9MKFFQo4WQPaYta599HkJP.jpg",
                     ReleaseDate = new DateTime(2021, 7, 19),
                     Overview = "The Templeton brothers — Tim and his Boss Baby little bro Ted — have become adults and drifted " +
                     "away from each other. But a new boss baby with a cutting-edge approach and a can-do attitude is about to " +
                     "bring them together again … and inspire a new family business."
                 },
                 new Movie
                 {
                     Id = 14,
                     Title = "El mesero",
                     PosterPath = "https://image.tmdb.org/t/p/w500/zvGC5jX5wQmU1GgPc0VGZz7Mtcs.jpg",
                     ReleaseDate = new DateTime(2021, 7, 15),
                     Overview = "A waiter pretends to be an important businessman in order to reach the upper class through his " +
                     "entrepreneurial dreams."
                 },
                 new Movie
                 {
                     Id = 15,
                     Title = "Luca",
                     PosterPath = "https://image.tmdb.org/t/p/w500/jTswp6KyDYKtvC52GbHagrZbGvD.jpg",
                     ReleaseDate = new DateTime(2021, 6, 17),
                     Overview = "Luca and his best friend Alberto experience an unforgettable summer on the Italian Riviera. But " +
                     "all the fun is threatened by a deeply-held secret: they are sea monsters from another world just below the " +
                     "water’s surface."
                 },
                 new Movie
                 {
                     Id = 16,
                     Title = "The Tomorrow War",
                     PosterPath = "https://image.tmdb.org/t/p/w500/34nDCQZwaEvsy4CFO5hkGRFDCVU.jpg",
                     ReleaseDate = new DateTime(2021, 6, 19),
                     Overview = "The world is stunned when a group of time travelers arrive from the year 2051 to deliver an urgent " +
                     "message: Thirty years in the future, mankind is losing a global war against a deadly alien species. The only " +
                     "hope for survival is for soldiers and civilians from the present to be transported to the future and join the " +
                     "fight. Among those recruited is high school teacher and family man Dan Forester. Determined to save the world " +
                     "for his young daughter, Dan teams up with a brilliant scientist and his estranged father in a desperate quest " +
                     "to rewrite the fate of the planet."
                 },
                 new Movie
                 {
                     Id = 17,
                     Title = "Breathless",
                     PosterPath = "https://image.tmdb.org/t/p/w500/oxNoVgbu2v9ETL93Kri1pw8osYf.jpg",
                     ReleaseDate = new DateTime(2021, 6, 11),
                     Overview = ""
                 },
                 new Movie
                 {
                     Id = 18,
                     Title = "The Last Mercenary",
                     PosterPath = "https://image.tmdb.org/t/p/w500/ttpKJ7XQxDZV252KNEHXtykYT41.jpg",
                     ReleaseDate = new DateTime(2021, 7, 30),
                     Overview = "A mysterious former secret service agent must urgently return to France when his estranged son  " +
                     "is falsely accused of arms and drug trafficking by the government, following a blunder by an overzealous " +
                     "bureaucrat and a mafia operation."
                 },
                 new Movie
                 {
                     Id = 19,
                     Title = "The Loud House Movie",
                     PosterPath = "https://image.tmdb.org/t/p/w500/mab5wPeGVjbMyYMzyzfdKKnG9cl.jpg",
                     ReleaseDate = new DateTime(2021, 8, 20),
                     Overview = "The Loud family travel to Scotland and discover they are descendants of Scottish royalty as " +
                     "they move into their giant ancestral castle."
                 },
                 new Movie
                 {
                     Id = 20,
                     Title = "Jolt",
                     PosterPath = "https://image.tmdb.org/t/p/w500/gYZAHan5CHPFXORpQMvOjCTug4E.jpg",
                     ReleaseDate = new DateTime(2021, 7, 15),
                     Overview = "Lindy is an acid-tongued woman with rage issues who controls her temper by shocking herself with " +
                     "an electrode vest. One day she makes a connection with Justin, who gives her a glimmer of hope for a " +
                     "shock-free future, but when he’s murdered she launches herself on a revenge-fueled rampage in pursuit of " +
                     "his killer."
                 }
           );
            #endregion

            #region Admin user
            AuthService.CreatePasswordHash("admin", out byte[] passHash, out byte[] passSalt);
            DateTime now = DateTime.Now;
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Username = "admin", FirstName = "Admin", LastName = "Admin", PasswordHash = passHash, PasswordSalt = passSalt, CreatedAt = now }

            );
            #endregion

            #region Ratings
            modelBuilder.Entity<Rating>().HasData(
                new Rating { Id = 1, Value = 4.6, MovieId = 1, UserId = 1 },
                new Rating { Id = 2, Value = 4.5, MovieId = 2, UserId = 1 },
                new Rating { Id = 3, Value = 4.5, MovieId = 3, UserId = 1 },
                new Rating { Id = 4, Value = 4.5, MovieId = 4, UserId = 1 },
                new Rating { Id = 5, Value = 4.4, MovieId = 5, UserId = 1 },
                new Rating { Id = 6, Value = 4.35, MovieId = 6, UserId = 1 },
                new Rating { Id = 7, Value = 4.3, MovieId = 7, UserId = 1 },
                new Rating { Id = 8, Value = 4.2, MovieId = 8, UserId = 1 },
                new Rating { Id = 9, Value = 4.2, MovieId = 9, UserId = 1 },
                new Rating { Id = 10, Value = 4.2, MovieId = 10, UserId = 1 },
                new Rating { Id = 11, Value = 4.2, MovieId = 11, UserId = 1 },
                new Rating { Id = 12, Value = 4.1, MovieId = 12, UserId = 1 },
                new Rating { Id = 13, Value = 4.1, MovieId = 13, UserId = 1 },
                new Rating { Id = 14, Value = 4.7, MovieId = 14, UserId = 1 },
                new Rating { Id = 15, Value = 4.6, MovieId = 15, UserId = 1 },
                new Rating { Id = 16, Value = 4.6, MovieId = 16, UserId = 1 },
                new Rating { Id = 17, Value = 4.6, MovieId = 17, UserId = 1 },
                new Rating { Id = 18, Value = 4.5, MovieId = 18, UserId = 1 },
                new Rating { Id = 19, Value = 4.4, MovieId = 19, UserId = 1 },
                new Rating { Id = 20, Value = 4.3, MovieId = 20, UserId = 1 }
            );
            #endregion
        }
    }
}
