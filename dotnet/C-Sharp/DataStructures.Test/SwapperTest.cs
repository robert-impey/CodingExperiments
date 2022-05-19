using FluentAssertions;
using Xunit;

namespace DataStructures.Test
{
    public class SwapperTest
    {
        [Fact]
        public void Swap()
        {
            var ary = new[] { 1, 2 };

            Swapper.Swap(ary, 0, 1);

            ary[0].Should().Be(2);
            ary[1].Should().Be(1);
        }
    }
}