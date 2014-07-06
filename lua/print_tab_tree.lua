#!/usr/bin/env lua

function count_leading_tabs(line)
	tabs = 0

	for _ in line:gmatch("\t") do tabs = tabs + 1 end

	return tabs
end

tab_tree = {}

previous_indent = 0
for line in io.lines() do
	-- Remove leading white space
	line_wo_lws, _ = line:gsub("%s*", "")

	current_indent = count_leading_tabs(line)

	if current_indent > previous_indent then
		print("down")
	elseif current_indent < previous_indent then
		print("up")	
	else
		print("same")
	end

	previous_indent = current_indent
end

