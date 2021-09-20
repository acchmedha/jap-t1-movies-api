using JAP_Task_1_MoviesApi.Data;
using JAP_Task_1_MoviesApi.Entities;
using JAP_Task_1_MoviesApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace JAP_Task_1_MoviesApi.Services
{
    public class RatingService : IRatingService
    {
        private readonly MoviesAppDbContext _context;
        public RatingService(MoviesAppDbContext context)
        {
            _context = context;
        }
        public async Task<ServiceResponse<bool>> AddRating(double AddValue, int AddVideoId, int userId)
        {
            ServiceResponse<bool> response = new();

            var AddUserId = userId;
            var userAlreadyAddedRating = await _context.Ratings.FirstOrDefaultAsync(x => x.UserId == AddUserId && x.VideoId == AddVideoId);

            if (userAlreadyAddedRating != null)
            {
                response.Data = false;
                response.Success = false;
                response.Message = "You already rated this item";
                return response;
            }

            var addRating = new RatingEntity
            {
                Value = AddValue,
                VideoId = AddVideoId,
                UserId = AddUserId
            };

            await _context.Ratings.AddAsync(addRating);
            await _context.SaveChangesAsync();

            response.Data = true;
            response.Success = true;
            response.Message = "Successfully added rating";

            return response;
        }
    }
}
