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

        [Theory]
        [InlineData("Ash Zealot")]
        [InlineData("Advent of the Wurm")]
        [InlineData("Abyssal Persecutor")]
        public void SearchByName(string name)
        {
            var service = new SearchCards();
            var result = service.SearchByName(name);
            var card = result.Value.FirstOrDefault();
            Assert.True(result.IsSuccess);
            Assert.Equal(name, card.Name);
        }

        [Theory]
        [InlineData("Avacyn Restored")]
        [InlineData("Gatecrash")]
        [InlineData("Shards of Alara")]
        public void SearchBySet(string set)
        {
            var service = new SearchCards();
            var result = service.SearchBySet(set);
            var card = result.Value.FirstOrDefault();
            Assert.True(result.IsSuccess);
            Assert.Equal(set, card.SetName);
        }
    }
}
