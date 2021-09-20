﻿using System.Collections.Generic;


namespace JAP_Task_1_MoviesApi.Models
{
    public class ActorEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<MovieEntity> Movies { get; set; }
    }
}