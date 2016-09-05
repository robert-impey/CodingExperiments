#!/usr/bin/env lua5.3

for line in io.lines() do
	new_line, _ = line:gsub("%s*", "")
	print(new_line)
end

