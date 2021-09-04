using JAP_Task_1_MoviesApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JAP_Task_1_MoviesApi.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    Id = 1,
                    Title = "The Suicide Squad",
                    VoteAverage = 8,
                    UserVote = 0,
                    PosterPath = "https://image.tmdb.org/t/p/w500/iXbWpCkIauBMStSTUT9v4GXvdgH.jpg",
                    ReleaseDate = DateTime.ParseExact("2021-07-28", "yyyy-MM-dd", null),
                    Overview = "Supervillains Harley Quinn, Bloodsport, Peacemaker and a collection of nutty cons at Belle Reve " +
                    "prison join the super-secret, super-shady Task Force X as they are dropped off at the remote, enemy-infused " +
                    "island of Corto Maltese."         
                },
                new Movie
                {
                    Id = 2,
                    Title = "Sweet Girl",
                    VoteAverage = 7,
                    UserVote = 0,
                    PosterPath = "https://image.tmdb.org/t/p/w500/cP7odDzzFBD9ycxj2laTeFWGLjD.jpg",
                    ReleaseDate = DateTime.ParseExact("2021-08-18", "yyyy-MM-dd", null),
                    Overview =  "A devastated husband vows to bring justice to the people responsible for his wife's death while " +
                    "protecting the only family he has left, his daughter."
                },
                new Movie
                {
                    Id = 3,
                    Title = "Jungle Cruise",
                    VoteAverage = 7.9,
                    UserVote = 0,
                    PosterPath = "https://image.tmdb.org/t/p/w500/9dKCd55IuTT5QRs989m9Qlb7d2B.jpg",
                    ReleaseDate = DateTime.ParseExact("2021-07-28", "yyyy-MM-dd", null),
                    Overview = "Dr. Lily Houghton enlists the aid of wisecracking skipper Frank Wolff to take her down the Amazon " +
                    "in his dilapidated boat. Together, they search for an ancient tree that holds the power to heal – a discovery " +
                    "that will change the future of medicine."             
                },
                new Movie
                {
                    Id = 4,
                    Title = "PAW Patrol: The Movie",
                    VoteAverage = 8.1,
                    UserVote = 0,
                    PosterPath = "https://image.tmdb.org/t/p/w500/ic0intvXZSfBlYPIvWXpU1ivUCO.jpg",
                    ReleaseDate = DateTime.ParseExact("2021-08-09", "yyyy-MM-dd", null),
                    Overview = "Ryder and the pups are called to Adventure City to stop Mayor Humdinger from turning the bustling " +
                    "metropolis into a state of chaos..."       
                },
                new Movie
                {
                    Id = 5,
                    Title = "Eggs Run",
                    VoteAverage = 8.4,
                    UserVote = 0,
                    PosterPath = "https://image.tmdb.org/t/p/w500/wrlQnKHLCBheXMNWotyr5cVDqNM.jpg",
                    ReleaseDate = DateTime.ParseExact("2021-08-12", "yyyy-MM-dd", null),
                    Overview = "A rooster and his fowl partner embark on a dangerous trip to the Congo to recover their stolen eggs " +
                    "from a group of Russian goons."     
                },
                new Movie
                {
                    Id = 6,
                    Title = "Black Widow",
                    VoteAverage = 7.8,
                    UserVote = 0,
                    PosterPath = "https://image.tmdb.org/t/p/w500/qAZ0pzat24kLdO3o8ejmbLxyOac.jpg",
                    ReleaseDate = DateTime.ParseExact("2021-07-07", "yyyy-MM-dd", null),
                    Overview = "Natasha Romanoff, also known as Black Widow, confronts the darker parts of her ledger when a " +
                    "dangerous conspiracy with ties to her past arises. Pursued by a force that will stop at nothing to bring " +
                    "her down, Natasha must deal with her history as a spy and the broken relationships left in her wake long " +
                    "before she became an Avenger."     
                },
                new Movie
                {
                    Id = 7,
                    Title = "Space Jam: A New Legacy",
                    VoteAverage = 7.5,
                    UserVote = 0,
                    PosterPath = "https://image.tmdb.org/t/p/w500/5bFK5d3mVTAvBCXi5NPWH0tYjKl.jpg",
                    ReleaseDate = DateTime.ParseExact("2021-07-08", "yyyy-MM-dd", null),
                    Overview = "When LeBron and his young son Dom are trapped in a digital space by a rogue A.I., LeBron must get " +
                    "them home safe by leading Bugs, Lola Bunny and the whole gang of notoriously undisciplined Looney Tunes to " +
                    "victory over the A.I.'s digitized champions on the court. It's Tunes versus Goons in the highest-stakes " +
                    "challenge of his life."   
                },
                new Movie
                {
                    Id = 8,
                    Title = "Narco Sub",
                    VoteAverage = 7.1,
                    UserVote = 0,
                    PosterPath = "https://image.tmdb.org/t/p/w500/7p0O4mKYLIhU2E5Zcq9Z3vOZ4e9.jpg",
                    ReleaseDate = DateTime.ParseExact("2021-07-22", "yyyy-MM-dd", null),
                    Overview = "A man will become a criminal to save his family.  Director: Shawn Welling  Writer: Derek H. Potts  " +
                    "Stars: Tom Vera, Tom Sizemore, Lee Majors |" 
                },
                new Movie
                {
                    Id = 9,
                    Title = "Free Guy",
                    VoteAverage = 7.8,
                    UserVote = 0,
                    PosterPath = "https://image.tmdb.org/t/p/w500/hEqw9swA8gFJuNjgWYEypwZfkZg.jpg",
                    ReleaseDate = DateTime.ParseExact("2021-08-11", "yyyy-MM-dd", null),
                    Overview = "A bank teller called Guy realizes he is a background character in an open world video game called " +
                    "Free City that will soon go offline."   
                },
                new Movie
                {
                    Id = 10,
                    Title = "Infinite",
                    VoteAverage = 7.5,
                    UserVote = 0,
                    PosterPath = "https://image.tmdb.org/t/p/w500/niw2AKHz6XmwiRMLWaoyAOAti0G.jpg",
                    ReleaseDate = DateTime.ParseExact("2021-06-10", "yyyy-MM-dd", null),
                    Overview = "Evan McCauley has skills he never learned and memories of places he has never visited. Self-medicated " +
                    "and on the brink of a mental breakdown, a secret group that call themselves “Infinites” come to his rescue, " +
                    "revealing that his memories are real."     
                },
                new Movie
                {
                    Id = 11,
                    Title = "Beckett",
                    VoteAverage = 6.5,
                    UserVote = 0,
                    PosterPath = "https://image.tmdb.org/t/p/w500/fBJducGBcmrcIOQdhm4BUBNDiMu.jpg",
                    ReleaseDate = DateTime.ParseExact("2021-08-04", "yyyy-MM-dd", null),
                    Overview = "Whilst vacationing in Greece, Beckett, becomes the target of a manhunt after a devastating car " +
                    "accident forces him to run for his life across the country to clear his name but tensions escalate as the " +
                    "authorities close in and political unrest mounts which makes Beckett fall even deeper into a dangerous web " +
                    "of conspiracy."
                },
                 new Movie
                 {
                     Id = 12,
                     Title = "F9",
                     VoteAverage = 7.6,
                     UserVote = 0,
                     PosterPath = "https://image.tmdb.org/t/p/w500/bOFaAXmWWXC3Rbv4u4uM9ZSzRXP.jpg",
                     ReleaseDate = DateTime.ParseExact("2021-05-19", "yyyy-MM-dd", null),
                     Overview = "Dominic Toretto and his crew battle the most skilled assassin and high-performance driver they've " +
                     "ever encountered: his forsaken brother."
                 },
                 new Movie
                 {
                     Id = 13,
                     Title = "The Boss Baby",
                     VoteAverage = 7.8,
                     UserVote = 0,
                     PosterPath = "https://image.tmdb.org/t/p/w500/kv2Qk9MKFFQo4WQPaYta599HkJP.jpg",
                     ReleaseDate = DateTime.ParseExact("2021-07-01", "yyyy-MM-dd", null),
                     Overview = "The Templeton brothers — Tim and his Boss Baby little bro Ted — have become adults and drifted " +
                     "away from each other. But a new boss baby with a cutting-edge approach and a can-do attitude is about to " +
                     "bring them together again … and inspire a new family business."
                 },
                 new Movie
                 {
                     Id = 14,
                     Title = "El mesero",
                     VoteAverage = 8.5,
                     UserVote = 0,
                     PosterPath = "https://image.tmdb.org/t/p/w500/zvGC5jX5wQmU1GgPc0VGZz7Mtcs.jpg",
                     ReleaseDate = DateTime.ParseExact("2021-07-15", "yyyy-MM-dd", null),
                     Overview = "A waiter pretends to be an important businessman in order to reach the upper class through his " +
                     "entrepreneurial dreams."
                 },
                 new Movie
                 {
                     Id = 15,
                     Title = "Luca",
                     VoteAverage = 8.1,
                     UserVote = 0,
                     PosterPath = "https://image.tmdb.org/t/p/w500/jTswp6KyDYKtvC52GbHagrZbGvD.jpg",
                     ReleaseDate = DateTime.ParseExact("2021-06-17", "yyyy-MM-dd", null),
                     Overview = "Luca and his best friend Alberto experience an unforgettable summer on the Italian Riviera. But " +
                     "all the fun is threatened by a deeply-held secret: they are sea monsters from another world just below the " +
                     "water’s surface."
                 },
                 new Movie
                 {
                     Id = 16,
                     Title = "The Tomorrow War",
                     VoteAverage = 8.2,
                     UserVote = 0,
                     PosterPath = "https://image.tmdb.org/t/p/w500/34nDCQZwaEvsy4CFO5hkGRFDCVU.jpg",
                     ReleaseDate = DateTime.ParseExact("2021-09-03", "yyyy-MM-dd", null),
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
                     VoteAverage = 7.1,
                     UserVote = 0,
                     PosterPath = "https://image.tmdb.org/t/p/w500/oxNoVgbu2v9ETL93Kri1pw8osYf.jpg",
                     ReleaseDate = DateTime.ParseExact("2021-08-11", "yyyy-MM-dd", null),
                     Overview = ""
                 },
                 new Movie
                 {
                     Id = 18,
                     Title = "The Last Mercenary",
                     VoteAverage = 7,
                     UserVote = 0,
                     PosterPath = "https://image.tmdb.org/t/p/w500/ttpKJ7XQxDZV252KNEHXtykYT41.jpg",
                     ReleaseDate = DateTime.ParseExact("2021-07-30", "yyyy-MM-dd", null),
                     Overview = "A mysterious former secret service agent must urgently return to France when his estranged son  " +
                     "is falsely accused of arms and drug trafficking by the government, following a blunder by an overzealous " +
                     "bureaucrat and a mafia operation."
                 },
                 new Movie
                 {
                     Id = 19,
                     Title = "The Loud House Movie",
                     VoteAverage = 8.5,
                     UserVote = 0,
                     PosterPath = "https://image.tmdb.org/t/p/w500/mab5wPeGVjbMyYMzyzfdKKnG9cl.jpg",
                     ReleaseDate = DateTime.ParseExact("2021-08-20", "yyyy-MM-dd", null),
                     Overview = "The Loud family travel to Scotland and discover they are descendants of Scottish royalty as " +
                     "they move into their giant ancestral castle."
                 },
                 new Movie
                 {
                     Id = 20,
                     Title = "Jolt",
                     VoteAverage = 6.8,
                     UserVote = 0,
                     PosterPath = "https://image.tmdb.org/t/p/w500/gYZAHan5CHPFXORpQMvOjCTug4E.jpg",
                     ReleaseDate = DateTime.ParseExact("2021-07-15", "yyyy-MM-dd", null),
                     Overview = "Lindy is an acid-tongued woman with rage issues who controls her temper by shocking herself with " +
                     "an electrode vest. One day she makes a connection with Justin, who gives her a glimmer of hope for a " +
                     "shock-free future, but when he’s murdered she launches herself on a revenge-fueled rampage in pursuit of " +
                     "his killer."
                 }

           );
        }
    }
}
