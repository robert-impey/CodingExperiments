#!/usr/bin/env lua

co = coroutine.create(function()
    for i = 0, 9 do
        io.write(i .. ' ')
        coroutine.yield()
    end
end)

charNum = string.byte('a')
while true do
    coroutine.resume(co)
    if coroutine.status(co) == 'dead' then
        break
    end
    print(string.char(charNum))
    charNum = charNum + 1
end

