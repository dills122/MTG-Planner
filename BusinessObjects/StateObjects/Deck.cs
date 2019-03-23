using System;
using System.Collections.Generic;

namespace BusinessObjects.StateObjects
{
    public class Deck : Base
    {
        public Guid DeckId { get; set; }
        public string DeckName { get; set; }
        public int DeckCount { get; set; }

        public List<DeckItem> DeckItems { get; set; }
    }
}
