using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp.Shared
{
    public class CardViewModel
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        public List<string> ColorIdentity { get; set; }
        public string OriginalText { get; set; }
        public string Power { get; set; }
        public string Toughness { get; set; }
        public string Type { get; set; }
        public string Rarity { get; set; }
        public string ReleaseDate { get; set; }
        public string SetCode { get; set; }
        public string Set { get; set; }
        public string Text { get; set; }
        public List<string> Colors { get; set; }
        public string ImgUrl { get; set; }
        public string ManaCost { get; set; }
    }
}
