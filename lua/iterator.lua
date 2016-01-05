#!/usr/bin/env lua

co = coroutine.create(function()
    for i = 0, 9 do
        coroutine.yield(i)
    end
end)

aCode = string.byte('a')
while true do
    errorFree, num = coroutine.resume(co)
    if coroutine.status(co) == 'dead' then
        break
    end
    print(num, string.char(aCode + num))
end

