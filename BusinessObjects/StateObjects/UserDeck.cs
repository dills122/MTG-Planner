using System;

namespace BusinessObjects.StateObjects
{
    public class UserDeck : Base
    {
        public Guid UserId { get; set; }
        public Guid DeckId { get; set; }

        public Deck Deck { get; set; }
        public User User { get; set; }
    }
}
