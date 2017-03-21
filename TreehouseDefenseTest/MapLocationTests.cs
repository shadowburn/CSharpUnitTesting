using System;
using Xunit;

namespace TreehouseDefense.Test
{
	public class MapLocationTests
	{
		[Fact]
		public void ShouldThrowIfNotOnMap()
		{
			var map = new Map(4, 4);
			Assert.Throws<OutOfBoundsException>(()=> new MapLocation(4,4,map));
		}

		[Fact]
		public void InRangeOfRangeOne()
		{
			var map = new Map(3, 3);
			var target = new MapLocation(0, 0, map);
			Assert.True(target.InRangeOf(new MapLocation(0, 1, map), 1));
		}
	}
}
