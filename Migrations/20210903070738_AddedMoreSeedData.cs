using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JAP_Task_1_MoviesApi.Migrations
{
    public partial class AddedMoreSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "PosterPath",
                value: "https://image.tmdb.org/t/p/w500/iXbWpCkIauBMStSTUT9v4GXvdgH.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "PosterPath",
                value: "https://image.tmdb.org/t/p/w500/cP7odDzzFBD9ycxj2laTeFWGLjD.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "PosterPath",
                value: "https://image.tmdb.org/t/p/w500/9dKCd55IuTT5QRs989m9Qlb7d2B.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "PosterPath",
                value: "https://image.tmdb.org/t/p/w500/ic0intvXZSfBlYPIvWXpU1ivUCO.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "PosterPath",
                value: "https://image.tmdb.org/t/p/w500/wrlQnKHLCBheXMNWotyr5cVDqNM.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "PosterPath",
                value: "https://image.tmdb.org/t/p/w500/qAZ0pzat24kLdO3o8ejmbLxyOac.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "PosterPath",
                value: "https://image.tmdb.org/t/p/w500/5bFK5d3mVTAvBCXi5NPWH0tYjKl.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "PosterPath",
                value: "https://image.tmdb.org/t/p/w500/7p0O4mKYLIhU2E5Zcq9Z3vOZ4e9.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "PosterPath",
                value: "https://image.tmdb.org/t/p/w500/hEqw9swA8gFJuNjgWYEypwZfkZg.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                column: "PosterPath",
                value: "https://image.tmdb.org/t/p/w500/niw2AKHz6XmwiRMLWaoyAOAti0G.jpg");

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Overview", "PosterPath", "ReleaseDate", "Title", "VoteAverage" },
                values: new object[,]
                {
                    { 20, "Lindy is an acid-tongued woman with rage issues who controls her temper by shocking herself with an electrode vest. One day she makes a connection with Justin, who gives her a glimmer of hope for a shock-free future, but when he’s murdered she launches herself on a revenge-fueled rampage in pursuit of his killer.", "https://image.tmdb.org/t/p/w500/gYZAHan5CHPFXORpQMvOjCTug4E.jpg", new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jolt", 6.7999999999999998 },
                    { 18, "A mysterious former secret service agent must urgently return to France when his estranged son  is falsely accused of arms and drug trafficking by the government, following a blunder by an overzealous bureaucrat and a mafia operation.", "https://image.tmdb.org/t/p/w500/ttpKJ7XQxDZV252KNEHXtykYT41.jpg", new DateTime(2021, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Last Mercenary", 7.0 },
                    { 17, "", "https://image.tmdb.org/t/p/w500/oxNoVgbu2v9ETL93Kri1pw8osYf.jpg", new DateTime(2021, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Breathless", 7.0999999999999996 },
                    { 16, "The world is stunned when a group of time travelers arrive from the year 2051 to deliver an urgent message: Thirty years in the future, mankind is losing a global war against a deadly alien species. The only hope for survival is for soldiers and civilians from the present to be transported to the future and join the fight. Among those recruited is high school teacher and family man Dan Forester. Determined to save the world for his young daughter, Dan teams up with a brilliant scientist and his estranged father in a desperate quest to rewrite the fate of the planet.", "https://image.tmdb.org/t/p/w500/34nDCQZwaEvsy4CFO5hkGRFDCVU.jpg", new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Tomorrow War", 8.1999999999999993 },
                    { 15, "Luca and his best friend Alberto experience an unforgettable summer on the Italian Riviera. But all the fun is threatened by a deeply-held secret: they are sea monsters from another world just below the water’s surface.", "https://image.tmdb.org/t/p/w500/jTswp6KyDYKtvC52GbHagrZbGvD.jpg", new DateTime(2021, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Luca", 8.0999999999999996 },
                    { 14, "A waiter pretends to be an important businessman in order to reach the upper class through his entrepreneurial dreams.", "https://image.tmdb.org/t/p/w500/zvGC5jX5wQmU1GgPc0VGZz7Mtcs.jpg", new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "El mesero", 8.5 },
                    { 13, "The Templeton brothers — Tim and his Boss Baby little bro Ted — have become adults and drifted away from each other. But a new boss baby with a cutting-edge approach and a can-do attitude is about to bring them together again … and inspire a new family business.", "https://image.tmdb.org/t/p/w500/kv2Qk9MKFFQo4WQPaYta599HkJP.jpg", new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Boss Baby", 7.7999999999999998 },
                    { 12, "Dominic Toretto and his crew battle the most skilled assassin and high-performance driver they've ever encountered: his forsaken brother.", "https://image.tmdb.org/t/p/w500/bOFaAXmWWXC3Rbv4u4uM9ZSzRXP.jpg", new DateTime(2021, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "F9", 7.5999999999999996 },
                    { 19, "The Loud family travel to Scotland and discover they are descendants of Scottish royalty as they move into their giant ancestral castle.", "https://image.tmdb.org/t/p/w500/mab5wPeGVjbMyYMzyzfdKKnG9cl.jpg", new DateTime(2021, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Loud House Movie", 8.5 },
                    { 11, "Whilst vacationing in Greece, Beckett, becomes the target of a manhunt after a devastating car accident forces him to run for his life across the country to clear his name but tensions escalate as the authorities close in and political unrest mounts which makes Beckett fall even deeper into a dangerous web of conspiracy.", "https://image.tmdb.org/t/p/w500/fBJducGBcmrcIOQdhm4BUBNDiMu.jpg", new DateTime(2021, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beckett", 6.5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "PosterPath",
                value: "/iXbWpCkIauBMStSTUT9v4GXvdgH.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "PosterPath",
                value: "/cP7odDzzFBD9ycxj2laTeFWGLjD.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "PosterPath",
                value: "/9dKCd55IuTT5QRs989m9Qlb7d2B.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "PosterPath",
                value: "/ic0intvXZSfBlYPIvWXpU1ivUCO.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "PosterPath",
                value: "/wrlQnKHLCBheXMNWotyr5cVDqNM.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "PosterPath",
                value: "/qAZ0pzat24kLdO3o8ejmbLxyOac.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "PosterPath",
                value: "/5bFK5d3mVTAvBCXi5NPWH0tYjKl.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "PosterPath",
                value: "/7p0O4mKYLIhU2E5Zcq9Z3vOZ4e9.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "PosterPath",
                value: "/hEqw9swA8gFJuNjgWYEypwZfkZg.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                column: "PosterPath",
                value: "/niw2AKHz6XmwiRMLWaoyAOAti0G.jpg");
        }
    }
}
