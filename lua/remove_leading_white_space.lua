#!/usr/bin/env lua

for line in io.lines() do
	new_line, _ = line:gsub("%s*", "")
	print(new_line)
end

