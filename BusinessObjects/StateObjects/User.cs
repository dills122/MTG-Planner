using System;
using System.Collections.Generic;

namespace BusinessObjects.StateObjects
{
    public class User : Base
    {
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }

        public List<UserDeck> Decks { get; set; }
    }
}
