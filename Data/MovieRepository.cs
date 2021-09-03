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
        //private readonly IMapper _mapper;

        public MovieRepository(ApplicationDbContext context)
        {
            _context = context;
            //_mapper = mapper;
        }
        public async Task<Movie> GetMovieByIdAsync(int id)
        {
            return await _context.Movies.FindAsync(id);
        }

        public async Task<Movie> GetMovieByTitleAsync(string title)
        {
            return await _context.Movies.SingleOrDefaultAsync(x => x.Title == title);
        }

        public async Task<IEnumerable<Movie>> GetMoviesAsync()
        {
            return await _context.Movies.OrderByDescending(p => p.VoteAverage).ToListAsync();
        }

        public async Task<bool> SaveAllAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public void Update(Movie movie)
        {
            _context.Entry(movie).State = EntityState.Modified;
        }
    }
}
