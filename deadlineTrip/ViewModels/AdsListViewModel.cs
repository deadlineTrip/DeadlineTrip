﻿using deadlineTrip.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace deadlineTrip.ViewModels
{
    public class AdsListViewModel
    {

        public Advertisement Advertisements { get; set; }
        public Card Cards { get; set; }

        public double? MarketPrice { get; set; }

        public bool ifInAuction { get; set; }

        public bool ifInGame { get; set; }

        public bool? HasAuctionFinished { get; set; }
    }
}
