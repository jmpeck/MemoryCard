using MemoryCard.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace MemoryCard.DAL
{
    public class Repository
    {

        static MemoryCardContext GetContext()
        {
            var context = new MemoryCardContext();
            context.Database.Log = (message) => Debug.WriteLine(message);
            return context;
        }

        //this method creates a new flashcard

        public void AddCard(Card card)
        {
            using (MemoryCardContext context = GetContext())
            {
                context.Cards.Add(card);
                
                context.SaveChanges();
            }
        }

        //this method updates a flashcard

        public void UpdateCard(Card card)
        {
            using (MemoryCardContext context = GetContext())
            {
                context.Cards.Attach(card);
                context.Entry(card).State = EntityState.Modified;

                Card cardToUpdate = context.Cards.Find(card.CardID);

                context.Entry(cardToUpdate).CurrentValues.SetValues(card);

                context.SaveChanges();
            }

        }
        //this method deletes a flashcard

        public void DeleteCard(int id)
        {
            using (MemoryCardContext context = GetContext())
            {
                var cardToRemove = context.Cards.Find(id);
                context.Cards.Remove(cardToRemove);
                

                context.SaveChanges();
            }
        }

        //this method lists all the flashcards in the database

        public List<Card> GetAll()
        {
            List<Card> cards = new List<Card>();
            using (MemoryCardContext context = GetContext())
            {
                cards = context.Cards.ToList();
            }

            return cards;
        }


        //this method finds saved flashcards by ID

        public Card GetById(int id)
        {
            Card card = null;
            using (MemoryCardContext context = GetContext())
            {
                card = context.Cards.Find(id);
            }

            return card;
        }

        //this method pulls out cards according to the entered subject

        public List<Card> SeeCardsBySubject(string subject)
        {
            List<Card> cardsBySubject = new List<Card>();
            using (MemoryCardContext context = GetContext())
            {
                cardsBySubject = context.Cards.Where(x => x.Subject == subject.ToString()).ToList();
            }

            return cardsBySubject;
        }

             
    }
}