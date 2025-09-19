using System;
using Shouldly;

namespace Cache.Test;

internal class NoEvictionsTests(Func<int, IIntCache> getCache)
{
    public void Test()
    {
        TestGetFromEmpty();
        GetValue();
        GetMissingValue();
    }

    private void TestGetFromEmpty()
    {
        var cache = getCache(1);
        var got = cache.Get(1);

        got.ShouldBe(-1);
    }

    private void GetValue()
    {
        var cache = getCache(1);

        cache.Put(1, 1);

        var got = cache.Get(1);

        got.ShouldBe(1);
    }

    private void GetMissingValue()
    {
        var cache = getCache(1);

        cache.Put(1, 1);

        var got = cache.Get(2);

        got.ShouldBe(-1);
    }
}