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
                    PosterPath = "/iXbWpCkIauBMStSTUT9v4GXvdgH.jpg",
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
                    PosterPath = "/cP7odDzzFBD9ycxj2laTeFWGLjD.jpg",
                    ReleaseDate = DateTime.ParseExact("2021-08-18", "yyyy-MM-dd", null),
                    Overview =  "A devastated husband vows to bring justice to the people responsible for his wife's death while " +
                    "protecting the only family he has left, his daughter."
                },
                new Movie
                {
                    Id = 3,
                    Title = "Jungle Cruise",
                    VoteAverage = 7.9,
                    PosterPath = "/9dKCd55IuTT5QRs989m9Qlb7d2B.jpg",
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
                    PosterPath = "/ic0intvXZSfBlYPIvWXpU1ivUCO.jpg",
                    ReleaseDate = DateTime.ParseExact("2021-08-09", "yyyy-MM-dd", null),
                    Overview = "Ryder and the pups are called to Adventure City to stop Mayor Humdinger from turning the bustling " +
                    "metropolis into a state of chaos."       
                },
                new Movie
                {
                    Id = 5,
                    Title = "Eggs Run",
                    VoteAverage = 8.4,
                    PosterPath = "/wrlQnKHLCBheXMNWotyr5cVDqNM.jpg",
                    ReleaseDate = DateTime.ParseExact("2021-08-12", "yyyy-MM-dd", null),
                    Overview = "A rooster and his fowl partner embark on a dangerous trip to the Congo to recover their stolen eggs " +
                    "from a group of Russian goons."     
                },
                new Movie
                {
                    Id = 6,
                    Title = "Black Widow",
                    VoteAverage = 7.8,
                    PosterPath = "/qAZ0pzat24kLdO3o8ejmbLxyOac.jpg",
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
                    PosterPath = "/5bFK5d3mVTAvBCXi5NPWH0tYjKl.jpg",
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
                    PosterPath = "/7p0O4mKYLIhU2E5Zcq9Z3vOZ4e9.jpg",
                    ReleaseDate = DateTime.ParseExact("2021-07-22", "yyyy-MM-dd", null),
                    Overview = "A man will become a criminal to save his family.  Director: Shawn Welling  Writer: Derek H. Potts  " +
                    "Stars: Tom Vera, Tom Sizemore, Lee Majors |" 
                },
                new Movie
                {
                    Id = 9,
                    Title = "Free Guy",
                    VoteAverage = 7.8,
                    PosterPath = "/hEqw9swA8gFJuNjgWYEypwZfkZg.jpg",
                    ReleaseDate = DateTime.ParseExact("2021-08-11", "yyyy-MM-dd", null),
                    Overview = "A bank teller called Guy realizes he is a background character in an open world video game called " +
                    "Free City that will soon go offline."   
                },
                new Movie
                {
                    Id = 10,
                    Title = "Infinite",
                    VoteAverage = 7.5,
                    PosterPath = "/niw2AKHz6XmwiRMLWaoyAOAti0G.jpg",
                    ReleaseDate = DateTime.ParseExact("2021-06-10", "yyyy-MM-dd", null),
                    Overview = "Evan McCauley has skills he never learned and memories of places he has never visited. Self-medicated " +
                    "and on the brink of a mental breakdown, a secret group that call themselves “Infinites” come to his rescue, " +
                    "revealing that his memories are real."     
                }
           );
        }
    }
}
