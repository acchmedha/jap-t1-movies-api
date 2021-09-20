﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JAP_Task_1_MoviesApi.Models;
using Microsoft.AspNetCore.Authorization;
using JAP_Task_1_MoviesApi.Services;
using JAP_Task_1_MoviesApi.DTO;

namespace JAP_Task_1_MoviesApi.Controllers
{
    public class VideosController : BaseApiController
    {
        private readonly IVideoService _movieService;
        public VideosController(IVideoService movieService)
        {
            _movieService = movieService;
        }

        // GET: api/videos/movies
        [HttpGet("movies")]
        [Authorize]
        public async Task<ActionResult<IEnumerable<MovieDto>>> GetMovies([FromQuery] PaginationDto pagination)
        {
            var movies = await _movieService.GetMoviesOrTvShows(0, pagination);
            return Ok(movies);
        }

        // GET: api/videos/tvshows
        [HttpGet("tv-shows")]
        [Authorize]
        public async Task<ActionResult<IEnumerable<MovieDto>>> GetTvShows([FromQuery] PaginationDto pagination, string search = null)
        {
            if (search == null) return Ok(await _movieService.GetMoviesOrTvShows(VideoEnum.TvShow, pagination));
            return Ok(await _movieService.GetFilteredMovies(search));
        }

        // GET: api/videos
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<List<MovieDto>>> GetFilteredMovies([FromQuery] PaginationDto pagination, string search = null, VideoEnum videoType = VideoEnum.Movie)
        {
            if (search == null) return Ok(await _movieService.GetMoviesOrTvShows(videoType, pagination));
            return Ok(await _movieService.GetFilteredMovies(search));
        }

        // GET: api/MoviesTvShows/id
        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<MovieFullInfoDto>> GetMovie(int id)
        {
            var movie = await _movieService.GetMovieById(id);

            if (movie == null)
                return NotFound();

            return movie;
        }
    }
}
