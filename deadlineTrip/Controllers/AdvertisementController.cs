﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using deadlineTrip.Models;
using deadlineTrip.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace deadlineTrip.Controllers
{
    public class AdvertisementController : Controller
    {
        // GET: /<controller>/
        private readonly IAdvertisementRepository _advertisementRepository;
        private readonly IAccountRepository _accountRepository;
        private readonly ICardRepository _cardRepository;

        //  AddScope injects repositories into controller
        //when class requires these types they will be injected auto
        // by the built-in dependecy injection system
        public AdvertisementController(IAdvertisementRepository advertisementRepository, IAccountRepository accountRepository, ICardRepository cardRepository)
        {
            _advertisementRepository = advertisementRepository;
            _accountRepository = accountRepository;
            _cardRepository = cardRepository;
        }
        public ViewResult List()
        {

            IEnumerable<Advertisement> ads = _advertisementRepository.GetAllAdvertisements();
            IEnumerable<Card> cards = _cardRepository.getAllCards();

            var results = (from p in cards
                           join pm in ads on p.Id equals pm.CardId
                           select new AdsListViewModel{ Cards = p, Advertisements = pm });

            return View(results);
        }

        public ViewResult Create()
        {
            ViewBag.Cards = _cardRepository.getAllCards().Select(x=>x.Name).ToArray();

            return View();
        }
        

        [HttpPost]
        public ActionResult SubmitCreateAction(IFormCollection collection)
        {
            // Get Post Params Here
            //decimal Price = Convert.ToDecimal(collection["price"]);
            //int Quantity = Convert.ToInt32(collection["quantity"]);

            // Account id session
            //public int CardId = 
// card = _cardRepository.


            return RedirectToAction("list", "Advertisement");
        }



    }
}
