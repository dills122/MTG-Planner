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
    }
}
