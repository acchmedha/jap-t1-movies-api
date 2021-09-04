using JAP_Task_1_MoviesApi.Helpers;
using JAP_Task_1_MoviesApi.Interfaces;
using JAP_Task_1_MoviesApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JAP_Task_1_MoviesApi.Data
{
    public class MovieRepository : IMovieRepository
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

        public async Task<PagedList<Movie>> GetMoviesAsync(MovieParams movieParams)
        {
            //return await _context.Movies.OrderByDescending(p => p.VoteAverage).ToListAsync();
            var query = _context.Movies.AsNoTracking().OrderByDescending(p => p.VoteAverage);

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
