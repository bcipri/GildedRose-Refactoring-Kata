using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using FluentAssertions;
using csharp;

namespace GuildedRose.Tests
{
    [TestFixture]
    public class GildedRoseTests
    {
        [Test]
        public void delete_me()
        {
            var items = new List<Item>
            {
                new Item
                {
                   Name = "foo", SellIn = 0, Quality = 0
                }
            };
            var app = new GildedRose(items);

            // Act
            app.UpdateQuality();

            items.First().Name.Should().BeEquivalentTo("foo");
        }
    }
}
