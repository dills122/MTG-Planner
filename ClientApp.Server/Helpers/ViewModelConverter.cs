using ClientApp.Shared;
using MtgApiManager.Lib.Model;
using System.Collections.Generic;
using System.Linq;

namespace ClientApp.Server.Helpers
{
    /// <summary>
    /// Used for Transforming to Appropriate View Model
    /// </summary>
    public static class ViewModelConverter
    {


        public static CardViewModel ToCardViewModel(this Card card)
        {
            return new CardViewModel
            {
                Name = card.Name,
                Text = card.Text,
                OriginalText = card.OriginalText,
                Artist = card.Artist,
                ReleaseDate = card.ReleaseDate,
                ColorIdentity = card.ColorIdentity.ToList(),
                Power = card.Power,
                Toughness = card.Toughness,
                Rarity = card.Rarity,
                Set = card.SetName,
                SetCode = card.Set,
                Type = card.Type,
                Colors = card.Colors.ToList(),
                ManaCost = card.ManaCost,
                ImgUrl = card.ImageUrl.ToString(),

            };
        }

        public static List<CardViewModel> ToCardViewModel(this List<Card> cards)
        {
            return cards.Select(c => new CardViewModel
            {
                Name = c.Name,
                Text = c.Text,
                OriginalText = c.OriginalText,
                Artist = c.Artist,
                ReleaseDate = c.ReleaseDate,
                ColorIdentity = c.ColorIdentity.ToList(),
                Power = c.Power,
                Toughness = c.Toughness,
                Rarity = c.Rarity,
                Set = c.SetName,
                SetCode = c.Set,
                Type = c.Type,
                Colors = c.Colors.ToList(),
                ManaCost = c.ManaCost,
                ImgUrl = c.ImageUrl.ToString(),
            }).ToList();
        }

        public static SetViewModel ToSetViewModel(this Set set)
        {
            return new SetViewModel
            {
                Name = set.Name,
                Code = set.Code,
                Expansion = set.Expansion,
                ReleaseDate = set.ReleaseDate
            };
        }

        public static List<SetViewModel> ToSetViewModel(this List<Set> sets)
        {
            return sets.Select(s => new SetViewModel
            {
                Name = s.Name,
                Code = s.Code,
                Expansion = s.Expansion,
                ReleaseDate = s.ReleaseDate
            }).ToList();
        }
    }
}
