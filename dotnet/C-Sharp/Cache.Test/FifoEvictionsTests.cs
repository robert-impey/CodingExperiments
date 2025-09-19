using System;
using Shouldly;

namespace Cache.Test;

internal class FifoEvictionsTests(Func<int, IFifoCache> getCache)
{
    public void Test()
    {
        GetAfterEviction();
        GetAfterOverwriteAndEviction();
    }

    private void GetAfterEviction()
    {
        var cache = getCache(2);

        cache.Put(1, 1);
        cache.Put(2, 2);
        cache.Put(3, 3); // This should evict 1

        cache.Get(1).ShouldBe(-1);
        cache.Get(2).ShouldBe(2);
        cache.Get(3).ShouldBe(3);
    }

    private void GetAfterOverwriteAndEviction()
    {
        var cache = getCache(2);

        cache.Put(1, 1);
        cache.Put(2, 2);
        cache.Put(1, 11);
        cache.Put(3, 3); // This should evict 2

        cache.Get(1).ShouldBe(11);
        cache.Get(2).ShouldBe(-1);
        cache.Get(3).ShouldBe(3);
    }
}