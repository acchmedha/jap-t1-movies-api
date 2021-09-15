using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JAP_Task_1_MoviesApi.Models;
using Microsoft.AspNetCore.Authorization;
using JAP_Task_1_MoviesApi.Helpers;
using JAP_Task_1_MoviesApi.Extensions;
using JAP_Task_1_MoviesApi.Services.MovieService;

namespace JAP_Task_1_MoviesApi.Controllers
{
    public class MoviesController : BaseApiController
    {
        private readonly IMovieService _movieService;

        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        // GET: api/Movies
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Movie>>> GetMovies([FromQuery]MovieParams movieParams, string search)
        {
            var movies = await _movieService.GetMoviesAsync(movieParams, search);

            Response.AddPaginationHeader(movies.CurrentPage, movies.PageSize, movies.TotalCount, movies.TotalPages);

            return Ok(movies);
        }

        // GET: api/Movies/TitleName
        [HttpGet("{title}")]
        [Authorize]
        public async Task<ActionResult<Movie>> GetMovie(string title)
        {
            var movie = await _movieService.GetMovieByTitleAsync(title);

            if (movie == null)
            {
                return NotFound();
            }

            return movie;
        }

        // PUT: api/Movies/5
        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> PutMovie(int id, Movie movie)
        {
            if (id != movie.Id)
            {
                return BadRequest();
            }

            try
            {
                await _movieService.UpdateMovieAsync(movie);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_movieService.MovieExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok("Movies updated");
        }

    }
}
