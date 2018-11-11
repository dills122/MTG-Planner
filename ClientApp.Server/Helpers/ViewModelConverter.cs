using ClientApp.Shared;
using MtgApiManager.Lib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientApp.Server.Helpers
{
    public static class ViewModelConverter
    {


        public static CardViewModel ToCardViewModel(this Card card)
        {
            return new CardViewModel
            {
                Colors = card.Colors.ToList(),
                ManaCost = card.ManaCost,
                ImgUrl = card.ImageUrl.ToString(),
                Name = card.Name
            };
        }

        public static List<CardViewModel> ToCardViewModel(this List<Card> cards)
        {
            return cards.Select(c => new CardViewModel
            {
                Colors = c.Colors.ToList(),
                ManaCost = c.ManaCost,
                Name = c.Name,
                ImgUrl = c.ImageUrl.ToString(),
            }).ToList();
        }
    }
}
