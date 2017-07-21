using MemoryCard.DAL;
using MemoryCard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MemoryCard.Controllers
{
    public class MemoryCardController : Controller
    {
        private Repository repository;

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ActuallyCreate(Card card)
        {
            if (!ModelState.IsValid)
            {
                return View("Create");
            }

            repository = new Repository();
            repository.AddCard(card);
            return RedirectToAction("Cards");
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            repository = new Repository();
            var card = repository.GetById(id);
            return View(card);
        }

        [HttpPost]
        public ActionResult Update(Card card)
        {
            repository = new Repository();
            repository.UpdateCard(card);
            return RedirectToAction("Cards");
        }

        [HttpGet]
        public ActionResult Cards()
        {
            repository = new Repository();
            var cards = repository.GetAll();

            return View(cards);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            repository = new Repository();
            var card = repository.GetById(id);
            return View(card);
        }

        [HttpPost]
        public ActionResult Delete(Card card)
        {
            repository = new Repository();
            repository.DeleteCard(card.CardID);
            return RedirectToAction("Cards");
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            repository = new Repository();

            return View(repository.GetById(id));
        }

        [HttpPost]
        public ActionResult Practice(string subject)
        {
            repository = new Repository();
            var cards = repository.SeeCardsBySubject(subject);

            return View(cards);
        }

        [HttpGet]
        public ActionResult CardBySubject()
        {

            return View();
        }

        [HttpPost]
        public ActionResult SeeCardsBySubject(string subject)
        {
            repository = new Repository();
            var cardsBySubject = repository.SeeCardsBySubject(subject);

            return View(cardsBySubject);
        }

    }
}