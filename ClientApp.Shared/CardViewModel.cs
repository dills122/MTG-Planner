using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp.Shared
{
    public class CardViewModel
    {
        public string Name { get; set; }
        public List<string> Colors { get; set; }
        public string ImgUrl { get; set; }
        public string ManaCost { get; set; }
    }
}
