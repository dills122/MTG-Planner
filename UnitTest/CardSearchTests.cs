using RetrievalService.Cards;
using System;
using System.Linq;
using Xunit;

namespace UnitTest
{
    public class CardSearchTests
    {
        [Theory]
        [InlineData("Blade Instructor", "Guilds of Ravnica")]
        [InlineData("Axebane Guardian", "Return to Ravnica")]
        [InlineData("Archwing Dragon", "Avacyn Restored")]
        public void SearchByNameAndSetTest(string name, string setName)
        {
            var service = new SearchCards();
            var result = service.SearchByNameAndSetName(name, setName);
            var card = result.Value.FirstOrDefault();
            Assert.True(result.IsSuccess);
            Assert.Equal(name, card.Name);
            Assert.Equal(setName, card.SetName);
        }
    }
}
