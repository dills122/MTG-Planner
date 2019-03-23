using MtgApiManager.Lib.Core;
using MtgApiManager.Lib.Model;
using MtgApiManager.Lib.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetrievalService.Cards
{
    public class SearchCards
    {
        private CardService _service;

        public SearchCards()
        {
            _service = new CardService();
        }

        public Exceptional<List<Card>> SearchByName(string name)
        {
            var card = _service.Where(x => x.Name, name).All();
            if(card.IsSuccess)
            {
                return card;
            }
            return new Exceptional<List<Card>>();
        }

        public Exceptional<List<Card>> SearchBySet(string set)
        {
            var card = _service.Where(x => x.SetName, set).All();
            if (card.IsSuccess)
            {
                return card;
            }
            return new Exceptional<List<Card>>();
        }

        public Exceptional<Card> SearchByID(string setId)
        {
            var card = _service.Find(setId);
            if (card.IsSuccess)
            {
                return card;
            }
            return new Exceptional<Card>();
        }

        public Exceptional<List<Card>> SearchByRarity(string setRarity)
        {
            var card = _service.Where(x => x.Rarity, setRarity).All();
            if (card.IsSuccess)
            {
                return card;
            }
            return new Exceptional<List<Card>>();
        }

        public Exceptional<List<Card>> SearchByNameAndSetName(string name, string setName)
        {
            var card = _service.Where(x => x.Name, name)
                .Where(s => s.SetName, setName).All();
            if (card.IsSuccess)
            {
                return card;
            }
            return new Exceptional<List<Card>>();
        }
    }
}
