using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace JAP_Task_1_MoviesApi.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: true),
                    VoteAverage = table.Column<double>(type: "double precision", nullable: false),
                    PosterPath = table.Column<string>(type: "text", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Overview = table.Column<string>(type: "text", nullable: true),
                    UserVote = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Username = table.Column<string>(type: "text", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "bytea", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "bytea", nullable: true),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Overview", "PosterPath", "ReleaseDate", "Title", "UserVote", "VoteAverage" },
                values: new object[,]
                {
                    { 1, "Supervillains Harley Quinn, Bloodsport, Peacemaker and a collection of nutty cons at Belle Reve prison join the super-secret, super-shady Task Force X as they are dropped off at the remote, enemy-infused island of Corto Maltese.", "https://image.tmdb.org/t/p/w500/iXbWpCkIauBMStSTUT9v4GXvdgH.jpg", new DateTime(2021, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Suicide Squad", 0, 8.0 },
                    { 18, "A mysterious former secret service agent must urgently return to France when his estranged son  is falsely accused of arms and drug trafficking by the government, following a blunder by an overzealous bureaucrat and a mafia operation.", "https://image.tmdb.org/t/p/w500/ttpKJ7XQxDZV252KNEHXtykYT41.jpg", new DateTime(2021, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Last Mercenary", 0, 7.0 },
                    { 17, "", "https://image.tmdb.org/t/p/w500/oxNoVgbu2v9ETL93Kri1pw8osYf.jpg", new DateTime(2021, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Breathless", 0, 7.0999999999999996 },
                    { 16, "The world is stunned when a group of time travelers arrive from the year 2051 to deliver an urgent message: Thirty years in the future, mankind is losing a global war against a deadly alien species. The only hope for survival is for soldiers and civilians from the present to be transported to the future and join the fight. Among those recruited is high school teacher and family man Dan Forester. Determined to save the world for his young daughter, Dan teams up with a brilliant scientist and his estranged father in a desperate quest to rewrite the fate of the planet.", "https://image.tmdb.org/t/p/w500/34nDCQZwaEvsy4CFO5hkGRFDCVU.jpg", new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Tomorrow War", 0, 8.1999999999999993 },
                    { 15, "Luca and his best friend Alberto experience an unforgettable summer on the Italian Riviera. But all the fun is threatened by a deeply-held secret: they are sea monsters from another world just below the water’s surface.", "https://image.tmdb.org/t/p/w500/jTswp6KyDYKtvC52GbHagrZbGvD.jpg", new DateTime(2021, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Luca", 0, 8.0999999999999996 },
                    { 14, "A waiter pretends to be an important businessman in order to reach the upper class through his entrepreneurial dreams.", "https://image.tmdb.org/t/p/w500/zvGC5jX5wQmU1GgPc0VGZz7Mtcs.jpg", new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "El mesero", 0, 8.5 },
                    { 13, "The Templeton brothers — Tim and his Boss Baby little bro Ted — have become adults and drifted away from each other. But a new boss baby with a cutting-edge approach and a can-do attitude is about to bring them together again … and inspire a new family business.", "https://image.tmdb.org/t/p/w500/kv2Qk9MKFFQo4WQPaYta599HkJP.jpg", new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Boss Baby", 0, 7.7999999999999998 },
                    { 12, "Dominic Toretto and his crew battle the most skilled assassin and high-performance driver they've ever encountered: his forsaken brother.", "https://image.tmdb.org/t/p/w500/bOFaAXmWWXC3Rbv4u4uM9ZSzRXP.jpg", new DateTime(2021, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "F9", 0, 7.5999999999999996 },
                    { 11, "Whilst vacationing in Greece, Beckett, becomes the target of a manhunt after a devastating car accident forces him to run for his life across the country to clear his name but tensions escalate as the authorities close in and political unrest mounts which makes Beckett fall even deeper into a dangerous web of conspiracy.", "https://image.tmdb.org/t/p/w500/fBJducGBcmrcIOQdhm4BUBNDiMu.jpg", new DateTime(2021, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beckett", 0, 6.5 },
                    { 10, "Evan McCauley has skills he never learned and memories of places he has never visited. Self-medicated and on the brink of a mental breakdown, a secret group that call themselves “Infinites” come to his rescue, revealing that his memories are real.", "https://image.tmdb.org/t/p/w500/niw2AKHz6XmwiRMLWaoyAOAti0G.jpg", new DateTime(2021, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Infinite", 0, 7.5 },
                    { 9, "A bank teller called Guy realizes he is a background character in an open world video game called Free City that will soon go offline.", "https://image.tmdb.org/t/p/w500/hEqw9swA8gFJuNjgWYEypwZfkZg.jpg", new DateTime(2021, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Free Guy", 0, 7.7999999999999998 },
                    { 8, "A man will become a criminal to save his family.  Director: Shawn Welling  Writer: Derek H. Potts  Stars: Tom Vera, Tom Sizemore, Lee Majors |", "https://image.tmdb.org/t/p/w500/7p0O4mKYLIhU2E5Zcq9Z3vOZ4e9.jpg", new DateTime(2021, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Narco Sub", 0, 7.0999999999999996 },
                    { 7, "When LeBron and his young son Dom are trapped in a digital space by a rogue A.I., LeBron must get them home safe by leading Bugs, Lola Bunny and the whole gang of notoriously undisciplined Looney Tunes to victory over the A.I.'s digitized champions on the court. It's Tunes versus Goons in the highest-stakes challenge of his life.", "https://image.tmdb.org/t/p/w500/5bFK5d3mVTAvBCXi5NPWH0tYjKl.jpg", new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Space Jam: A New Legacy", 0, 7.5 },
                    { 6, "Natasha Romanoff, also known as Black Widow, confronts the darker parts of her ledger when a dangerous conspiracy with ties to her past arises. Pursued by a force that will stop at nothing to bring her down, Natasha must deal with her history as a spy and the broken relationships left in her wake long before she became an Avenger.", "https://image.tmdb.org/t/p/w500/qAZ0pzat24kLdO3o8ejmbLxyOac.jpg", new DateTime(2021, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Black Widow", 0, 7.7999999999999998 },
                    { 5, "A rooster and his fowl partner embark on a dangerous trip to the Congo to recover their stolen eggs from a group of Russian goons.", "https://image.tmdb.org/t/p/w500/wrlQnKHLCBheXMNWotyr5cVDqNM.jpg", new DateTime(2021, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eggs Run", 0, 8.4000000000000004 },
                    { 4, "Ryder and the pups are called to Adventure City to stop Mayor Humdinger from turning the bustling metropolis into a state of chaos...", "https://image.tmdb.org/t/p/w500/ic0intvXZSfBlYPIvWXpU1ivUCO.jpg", new DateTime(2021, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "PAW Patrol: The Movie", 0, 8.0999999999999996 },
                    { 3, "Dr. Lily Houghton enlists the aid of wisecracking skipper Frank Wolff to take her down the Amazon in his dilapidated boat. Together, they search for an ancient tree that holds the power to heal – a discovery that will change the future of medicine.", "https://image.tmdb.org/t/p/w500/9dKCd55IuTT5QRs989m9Qlb7d2B.jpg", new DateTime(2021, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jungle Cruise", 0, 7.9000000000000004 },
                    { 2, "A devastated husband vows to bring justice to the people responsible for his wife's death while protecting the only family he has left, his daughter.", "https://image.tmdb.org/t/p/w500/cP7odDzzFBD9ycxj2laTeFWGLjD.jpg", new DateTime(2021, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sweet Girl", 0, 7.0 },
                    { 19, "The Loud family travel to Scotland and discover they are descendants of Scottish royalty as they move into their giant ancestral castle.", "https://image.tmdb.org/t/p/w500/mab5wPeGVjbMyYMzyzfdKKnG9cl.jpg", new DateTime(2021, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Loud House Movie", 0, 8.5 },
                    { 20, "Lindy is an acid-tongued woman with rage issues who controls her temper by shocking herself with an electrode vest. One day she makes a connection with Justin, who gives her a glimmer of hope for a shock-free future, but when he’s murdered she launches herself on a revenge-fueled rampage in pursuit of his killer.", "https://image.tmdb.org/t/p/w500/gYZAHan5CHPFXORpQMvOjCTug4E.jpg", new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jolt", 0, 6.7999999999999998 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
