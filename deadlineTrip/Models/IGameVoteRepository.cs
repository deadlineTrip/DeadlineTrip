﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace deadlineTrip.Models
{
    public interface IGameVoteRepository
    {
        void SaveVote(GameVote gameVote);
        IEnumerable<GameVote> GetVotes(int id);
        void DeleteVotes(int id);
    }
}
