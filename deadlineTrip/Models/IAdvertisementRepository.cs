﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace deadlineTrip.Models
{
    public interface IAdvertisementRepository
    {
        IEnumerable<Advertisement> GetAllUserAdvertisements();
        void AddAdvertisment(Advertisement ad);
        void Delete(int id);
        Advertisement GetAdvertisement(int id);
        void Update(int id, int quantity, decimal price);
        IEnumerable<Advertisement> GetAllAdvertisements();
        void AddToTheGame(int id);
        void ChangePriceAfterGame(bool increse, int id, int byHowMuch);
        void RemoveFromGame(int id);
    }
}
