#!/usr/bin/env lua

t = { "bananas", "coconuts", "apples" }

table.sort(t)

for _, i in ipairs(t) do
    print(i)
end

