using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JAP_Task_1_MoviesApi.Data;
using JAP_Task_1_MoviesApi.Models;
using JAP_Task_1_MoviesApi.Interfaces;
using Microsoft.AspNetCore.Authorization;
using JAP_Task_1_MoviesApi.Helpers;
using JAP_Task_1_MoviesApi.Extensions;

namespace JAP_Task_1_MoviesApi.Controllers
{
    public class MoviesController : BaseApiController
    {
        private readonly IMovieRepository _movieRepository;

        public MoviesController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        // GET: api/Movies
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Movie>>> GetMovies([FromQuery]MovieParams movieParams)
        {
            var movies = await _movieRepository.GetMoviesAsync(movieParams);

            Response.AddPaginationHeader(movies.CurrentPage, movies.PageSize, movies.TotalCount, movies.TotalPages);

            return Ok(movies);
        }

        // GET: api/Movies/TitleName
        [HttpGet("{title}")]
        [Authorize]
        public async Task<ActionResult<Movie>> GetMovie(string title)
        {
            var movie = await _movieRepository.GetMovieByTitleAsync(title);

            if (movie == null)
            {
                return NotFound();
            }

            return movie;
        }
    }
}
