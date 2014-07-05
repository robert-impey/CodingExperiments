#!/usr/bin/env lua

t = {}

table.insert(t, "\tone")
table.insert(t, "\t\ttwo")

for _, str in pairs(t) do
	print(str)

	tabs = 0	
	for _ in str:gmatch("\t") do tabs = tabs + 1 end

	print(tabs)
end

