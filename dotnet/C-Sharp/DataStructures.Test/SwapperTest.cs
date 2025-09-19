using Shouldly;
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

            ary[0].ShouldBe(2);
            ary[1].ShouldBe(1);
        }
    }
}