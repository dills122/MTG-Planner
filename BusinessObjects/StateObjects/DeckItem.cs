using System;

namespace BusinessObjects.StateObjects
{
    public class DeckItem : Base
    {
        public Guid DeckId { get; set; }
        //Api Card Id
        public int CardId { get; set; }
        public CardInfo CardInfo { get; set; }

        public Deck Deck { get; set; }
    }
}
