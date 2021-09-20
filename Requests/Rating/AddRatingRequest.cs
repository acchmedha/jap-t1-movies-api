using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JAP_Task_1_MoviesApi.Requests.Rating
{
    public class AddRatingRequest
    {
        public double Value { get; set; }
        public int MovieId { get; set; }
    }
}
