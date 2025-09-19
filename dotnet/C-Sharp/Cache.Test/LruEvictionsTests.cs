using System;
using Shouldly;

namespace Cache.Test;

internal class LruEvictionsTests(Func<int, ILruCache> getCache)
{
    public void Test()
    {
        GetAfterEvictionsWithoutPreviousGet();
        GetAfterEvictionsWithPreviousGet();
        MultipleEvictions();
    }

    private void GetAfterEvictionsWithoutPreviousGet()
    {
        var cache = getCache(2);

        cache.Put(1, 1);
        cache.Put(2, 2);
        cache.Put(3, 3); // This should evict 1

        cache.Get(1).ShouldBe(-1);
        cache.Get(2).ShouldBe(2);
        cache.Get(3).ShouldBe(3);
    }

    private void GetAfterEvictionsWithPreviousGet()
    {
        var cache = getCache(2);

        cache.Put(1, 1);
        cache.Put(2, 2);

        var got = cache.Get(1); // 2 is now the least recently used

        cache.Put(3, 3); // This should evict 2

        cache.Get(1).ShouldBe(1);
        cache.Get(2).ShouldBe(-1);
        cache.Get(3).ShouldBe(3);
    }

    private void MultipleEvictions()
    {
        var cache = getCache(2);

        cache.Get(2).ShouldBe(-1);
        cache.Put(2, 6);
        cache.Get(1).ShouldBe(-1);
        cache.Put(1, 5);
        cache.Put(1, 2);
        cache.Get(1).ShouldBe(2);
        cache.Get(2).ShouldBe(6);
    }

    private void MultiplePuts()
    {
        var cache = getCache(2);
            
        cache.Put(2, 1);
        cache.Put(1, 1);
        cache.Put(2, 3);
        cache.Put(4, 1);

        cache.Get(1).ShouldBe(-1);
        cache.Get(2).ShouldBe(3);
    }
}