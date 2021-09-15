using JAP_Task_1_MoviesApi.Data;
using JAP_Task_1_MoviesApi.Helpers;
using JAP_Task_1_MoviesApi.Models;
using JAP_Task_1_MoviesApi.Services.MovieService;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace JAP_Task_1_MoviesApi.Services.MovieService
{
    public class MovieRepository : IMovieService
    {

        private readonly ApplicationDbContext _context;

        public MovieRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Movie> GetMovieByIdAsync(int id)
        {
            return await _context.Movies.FindAsync(id);
        }

        public async Task<Movie> GetMovieByTitleAsync(string title)
        {
            return await _context.Movies.SingleOrDefaultAsync(x => x.Title == title);
        }

        public async Task<PagedList<Movie>> GetMoviesAsync(MovieParams movieParams, string search)
        {
            var query = from x in _context.Movies select x;

            if(!String.IsNullOrEmpty(search))
            {
                query = _context.Movies.AsNoTracking().Where(x => x.Title.ToLower()
                .Contains(search.ToLower()) || x.Overview.ToLower().Contains(search.ToLower()));
                    
            }
            //query = query.OrderByDescending(p => p.VoteAverage);

            return await PagedList<Movie>.CreateAsync(query, movieParams.PageNumber, movieParams.PageSize);
        }

        public bool MovieExists(int id)
        {
            return _context.Users.Any(e => e.Id == id);
        }

        public async Task<bool> SaveAllAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task UpdateMovieAsync(Movie movie)
        {
            _context.Entry(movie).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
