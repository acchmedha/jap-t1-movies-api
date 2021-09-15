using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JAP_Task_1_MoviesApi.Migrations
{
    public partial class InitialMigrationn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PosterPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Overview = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ActorMovie",
                columns: table => new
                {
                    ActorId = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorMovie", x => new { x.ActorId, x.MovieId });
                    table.ForeignKey(
                        name: "FK_ActorMovie_Actors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActorMovie_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<double>(type: "float", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ratings_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ratings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name", "Surname" },
                values: new object[,]
                {
                    { 1, "Morgan", "Freeman" },
                    { 52, "Sonja", "Sohn" },
                    { 51, "Lance", "Reddick" },
                    { 50, "Dominic", "West" },
                    { 49, "Jessie", "Buckley" },
                    { 48, "Stellan", "Skarsgard" },
                    { 47, "Jared", "Harris" },
                    { 53, "Peter", "Drost" },
                    { 45, "Ron", "Livingston" },
                    { 43, "Scott", "Grimes" },
                    { 42, "Anna", "Gunn" },
                    { 41, "Aaron", "Paul" },
                    { 40, "Bryan", "Cranston" },
                    { 39, "Nikolay", "Drozdov" },
                    { 38, "Sigourney", "Weaver" },
                    { 44, "Damian", "Lewis" },
                    { 37, "David", "Attenborough" },
                    { 54, "Roger", "Horrocks" },
                    { 56, "Stoney", "Emshwiller" },
                    { 70, "Eddie", "Falco" },
                    { 69, "Lorraine", "Bracco" },
                    { 68, "James", "Gandolfini" },
                    { 67, "Kit", "Harington" },
                    { 66, "Peter", "Dinklage" },
                    { 65, "Emilia", "Clarke" },
                    { 55, "Neil", "deGrasse Tyson" },
                    { 64, "Jonathan", "Fahn" },
                    { 62, "Carl", "Sagan" },
                    { 61, "Mae", "Whitman" },
                    { 60, "Zach", "Tyler" },
                    { 59, "Dee", "Bradley Baker" },
                    { 58, "Neil", "deGrasse Tyson" },
                    { 57, "Piotr", "Michael" },
                    { 63, "Jaromir", "Hanzlik" },
                    { 36, "Elliot", "Page" },
                    { 46, "Jessie", "Buckley" },
                    { 34, "Leonardo", "DiCaprio" },
                    { 15, "Liam", "Neeson" },
                    { 14, "Martin", "Balsam" },
                    { 13, "Lee", "J. Cobb" },
                    { 12, "Henry", "Fonda" },
                    { 11, "Aaron", "Eckhart" }
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name", "Surname" },
                values: new object[,]
                {
                    { 10, "Heath", "Ledger" },
                    { 16, "Ralph", "Fiennes" },
                    { 9, "Christian", "Bale" },
                    { 7, "Robert", "De Niro" },
                    { 6, "James", "Caan" },
                    { 5, "Al", "Pacino" },
                    { 4, "Marlon", "Brando" },
                    { 3, "Tim", "Robbins" },
                    { 2, "Bob", "Gunton" },
                    { 35, "Joseph", "Gordon-Levitt" },
                    { 17, "Ben", "Kingsley" },
                    { 8, "Robert", "Duvall" },
                    { 19, "Viggo", "Mortensen" },
                    { 18, "Elijah", "Wood" },
                    { 33, "Gary", "Sinise" },
                    { 32, "Robin", "Wright" },
                    { 31, "Tom", "Hanks" },
                    { 29, "Edward", "Norton" },
                    { 28, "Brad", "Pitt" },
                    { 27, "Orlando", "Bloom" },
                    { 30, "Meat", "Loaf" },
                    { 25, "Eli", "Wallach" },
                    { 24, "Clint", "Eastwood" },
                    { 23, "Samuel", "L. Jackson" },
                    { 22, "Uma", "Thurman" },
                    { 21, "John", "Travolta" },
                    { 20, "Ian", "McKellen" },
                    { 26, "Lee", "Van Cleef" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Overview", "PosterPath", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 19, "The Loud family travel to Scotland and discover they are descendants of Scottish royalty as they move into their giant ancestral castle.", "https://image.tmdb.org/t/p/w500/mab5wPeGVjbMyYMzyzfdKKnG9cl.jpg", new DateTime(2021, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Loud House Movie" },
                    { 12, "Dominic Toretto and his crew battle the most skilled assassin and high-performance driver they've ever encountered: his forsaken brother.", "https://image.tmdb.org/t/p/w500/bOFaAXmWWXC3Rbv4u4uM9ZSzRXP.jpg", new DateTime(2021, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "F9" },
                    { 18, "A mysterious former secret service agent must urgently return to France when his estranged son  is falsely accused of arms and drug trafficking by the government, following a blunder by an overzealous bureaucrat and a mafia operation.", "https://image.tmdb.org/t/p/w500/ttpKJ7XQxDZV252KNEHXtykYT41.jpg", new DateTime(2021, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Last Mercenary" },
                    { 17, "", "https://image.tmdb.org/t/p/w500/oxNoVgbu2v9ETL93Kri1pw8osYf.jpg", new DateTime(2021, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Breathless" },
                    { 16, "The world is stunned when a group of time travelers arrive from the year 2051 to deliver an urgent message: Thirty years in the future, mankind is losing a global war against a deadly alien species. The only hope for survival is for soldiers and civilians from the present to be transported to the future and join the fight. Among those recruited is high school teacher and family man Dan Forester. Determined to save the world for his young daughter, Dan teams up with a brilliant scientist and his estranged father in a desperate quest to rewrite the fate of the planet.", "https://image.tmdb.org/t/p/w500/34nDCQZwaEvsy4CFO5hkGRFDCVU.jpg", new DateTime(2021, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Tomorrow War" },
                    { 15, "Luca and his best friend Alberto experience an unforgettable summer on the Italian Riviera. But all the fun is threatened by a deeply-held secret: they are sea monsters from another world just below the water’s surface.", "https://image.tmdb.org/t/p/w500/jTswp6KyDYKtvC52GbHagrZbGvD.jpg", new DateTime(2021, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Luca" },
                    { 14, "A waiter pretends to be an important businessman in order to reach the upper class through his entrepreneurial dreams.", "https://image.tmdb.org/t/p/w500/zvGC5jX5wQmU1GgPc0VGZz7Mtcs.jpg", new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "El mesero" },
                    { 13, "The Templeton brothers — Tim and his Boss Baby little bro Ted — have become adults and drifted away from each other. But a new boss baby with a cutting-edge approach and a can-do attitude is about to bring them together again … and inspire a new family business.", "https://image.tmdb.org/t/p/w500/kv2Qk9MKFFQo4WQPaYta599HkJP.jpg", new DateTime(2021, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Boss Baby" },
                    { 11, "Whilst vacationing in Greece, Beckett, becomes the target of a manhunt after a devastating car accident forces him to run for his life across the country to clear his name but tensions escalate as the authorities close in and political unrest mounts which makes Beckett fall even deeper into a dangerous web of conspiracy.", "https://image.tmdb.org/t/p/w500/fBJducGBcmrcIOQdhm4BUBNDiMu.jpg", new DateTime(2021, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beckett" },
                    { 3, "Dr. Lily Houghton enlists the aid of wisecracking skipper Frank Wolff to take her down the Amazon in his dilapidated boat. Together, they search for an ancient tree that holds the power to heal – a discovery that will change the future of medicine.", "https://image.tmdb.org/t/p/w500/9dKCd55IuTT5QRs989m9Qlb7d2B.jpg", new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jungle Cruise" },
                    { 9, "A bank teller called Guy realizes he is a background character in an open world video game called Free City that will soon go offline.", "https://image.tmdb.org/t/p/w500/hEqw9swA8gFJuNjgWYEypwZfkZg.jpg", new DateTime(2021, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Free Guy" },
                    { 8, "A man will become a criminal to save his family.  Director: Shawn Welling  Writer: Derek H. Potts  Stars: Tom Vera, Tom Sizemore, Lee Majors |", "https://image.tmdb.org/t/p/w500/7p0O4mKYLIhU2E5Zcq9Z3vOZ4e9.jpg", new DateTime(2021, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Narco Sub" },
                    { 7, "When LeBron and his young son Dom are trapped in a digital space by a rogue A.I., LeBron must get them home safe by leading Bugs, Lola Bunny and the whole gang of notoriously undisciplined Looney Tunes to victory over the A.I.'s digitized champions on the court. It's Tunes versus Goons in the highest-stakes challenge of his life.", "https://image.tmdb.org/t/p/w500/5bFK5d3mVTAvBCXi5NPWH0tYjKl.jpg", new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Space Jam: A New Legacy" },
                    { 6, "Natasha Romanoff, also known as Black Widow, confronts the darker parts of her ledger when a dangerous conspiracy with ties to her past arises. Pursued by a force that will stop at nothing to bring her down, Natasha must deal with her history as a spy and the broken relationships left in her wake long before she became an Avenger.", "https://image.tmdb.org/t/p/w500/qAZ0pzat24kLdO3o8ejmbLxyOac.jpg", new DateTime(2021, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Black Widow" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Overview", "PosterPath", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 5, "A rooster and his fowl partner embark on a dangerous trip to the Congo to recover their stolen eggs from a group of Russian goons.", "https://image.tmdb.org/t/p/w500/wrlQnKHLCBheXMNWotyr5cVDqNM.jpg", new DateTime(2021, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eggs Run" },
                    { 4, "Ryder and the pups are called to Adventure City to stop Mayor Humdinger from turning the bustling metropolis into a state of chaos...", "https://image.tmdb.org/t/p/w500/ic0intvXZSfBlYPIvWXpU1ivUCO.jpg", new DateTime(2021, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "PAW Patrol: The Movie" },
                    { 2, "A devastated husband vows to bring justice to the people responsible for his wife's death while protecting the only family he has left, his daughter.", "https://image.tmdb.org/t/p/w500/cP7odDzzFBD9ycxj2laTeFWGLjD.jpg", new DateTime(2021, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sweet Girl" },
                    { 1, "Supervillains Harley Quinn, Bloodsport, Peacemaker and a collection of nutty cons at Belle Reve prison join the super-secret, super-shady Task Force X as they are dropped off at the remote, enemy-infused island of Corto Maltese.", "https://image.tmdb.org/t/p/w500/iXbWpCkIauBMStSTUT9v4GXvdgH.jpg", new DateTime(2021, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Suicide Squad" },
                    { 20, "Lindy is an acid-tongued woman with rage issues who controls her temper by shocking herself with an electrode vest. One day she makes a connection with Justin, who gives her a glimmer of hope for a shock-free future, but when he’s murdered she launches herself on a revenge-fueled rampage in pursuit of his killer.", "https://image.tmdb.org/t/p/w500/gYZAHan5CHPFXORpQMvOjCTug4E.jpg", new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jolt" },
                    { 10, "Evan McCauley has skills he never learned and memories of places he has never visited. Self-medicated and on the brink of a mental breakdown, a secret group that call themselves “Infinites” come to his rescue, revealing that his memories are real.", "https://image.tmdb.org/t/p/w500/niw2AKHz6XmwiRMLWaoyAOAti0G.jpg", new DateTime(2021, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Infinite" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 1, new DateTime(2021, 9, 15, 11, 55, 6, 228, DateTimeKind.Local).AddTicks(2269), "Admin", "Admin", new byte[] { 215, 177, 225, 183, 14, 142, 201, 232, 46, 187, 196, 78, 63, 183, 124, 202, 150, 195, 122, 180, 141, 105, 95, 13, 97, 196, 11, 70, 24, 96, 223, 237, 160, 73, 163, 246, 83, 113, 218, 104, 164, 79, 148, 71, 31, 130, 212, 234, 15, 73, 146, 121, 135, 81, 165, 107, 238, 73, 170, 72, 17, 211, 77, 186 }, new byte[] { 220, 4, 185, 113, 166, 12, 5, 47, 12, 198, 69, 184, 107, 23, 246, 81, 66, 136, 57, 17, 18, 44, 150, 209, 40, 205, 207, 24, 80, 51, 220, 48, 45, 12, 7, 71, 18, 110, 48, 168, 215, 119, 244, 4, 214, 205, 71, 212, 90, 139, 124, 120, 6, 252, 56, 88, 150, 115, 159, 77, 173, 135, 123, 24, 91, 89, 63, 112, 238, 172, 252, 119, 152, 77, 50, 120, 169, 13, 54, 85, 10, 4, 92, 180, 250, 31, 68, 135, 49, 72, 218, 153, 154, 1, 228, 157, 229, 24, 36, 6, 234, 38, 43, 35, 107, 252, 101, 57, 127, 255, 56, 230, 122, 101, 253, 215, 220, 230, 108, 35, 208, 167, 74, 181, 153, 187, 114, 77 }, "admin" });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MovieId", "UserId", "Value" },
                values: new object[,]
                {
                    { 1, 1, 1, 4.5999999999999996 },
                    { 18, 18, 1, 4.5 },
                    { 17, 17, 1, 4.5999999999999996 },
                    { 16, 16, 1, 4.5999999999999996 },
                    { 15, 15, 1, 4.5999999999999996 },
                    { 14, 14, 1, 4.7000000000000002 },
                    { 13, 13, 1, 4.0999999999999996 },
                    { 12, 12, 1, 4.0999999999999996 },
                    { 11, 11, 1, 4.2000000000000002 },
                    { 10, 10, 1, 4.2000000000000002 },
                    { 9, 9, 1, 4.2000000000000002 },
                    { 8, 8, 1, 4.2000000000000002 },
                    { 7, 7, 1, 4.2999999999999998 },
                    { 6, 6, 1, 4.3499999999999996 },
                    { 5, 5, 1, 4.4000000000000004 },
                    { 4, 4, 1, 4.5 },
                    { 3, 3, 1, 4.5 },
                    { 2, 2, 1, 4.5 },
                    { 19, 19, 1, 4.4000000000000004 },
                    { 20, 20, 1, 4.2999999999999998 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActorMovie_MovieId",
                table: "ActorMovie",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_MovieId",
                table: "Ratings",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_UserId",
                table: "Ratings",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActorMovie");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
