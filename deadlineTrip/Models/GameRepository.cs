﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace deadlineTrip.Models
{
    public class GameRepository:IGameRepository
    {

        private readonly AppDbContext _appDbContext;
        public List<Game> Games { get; set; }
        public GameRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public void AddCardToTheGame(Game game)
        {
            _appDbContext.Game.Add(game);
            _appDbContext.SaveChanges();
        }
    }
}
