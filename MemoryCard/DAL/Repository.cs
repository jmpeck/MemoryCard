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

        public void AddCard(Card card)
        {
            using (MemoryCardContext context = GetContext())
            {
                context.Cards.Add(card);
                
                context.SaveChanges();
            }
        }

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

        public void DeleteCard(int cardId)
        {
            using (MemoryCardContext context = GetContext())
            {
                var card = new Card() { CardID = cardId };
                context.Entry(card).State = EntityState.Deleted;

                context.SaveChanges();
            }
        }

        public Card GetById(int id)
        {
            Card card = null;
            using (MemoryCardContext context = GetContext())
            {
                card = context.Cards.Find(id);
            }

            return card;
        }
    }
}