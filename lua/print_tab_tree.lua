#!/usr/bin/env lua

function count_leading_tabs(line)
	tabs = 0

	for _ in line:gmatch("\t") do tabs = tabs + 1 end

	return tabs
end

-- Read the file

tab_tree = {}

current_table = tab_tree
current_items = {}

tab_tree.items = current_items

previous_indent = 0
previous_title = nil
for line in io.lines() do
	-- Remove leading white space
	line_wo_lws, _ = line:gsub("%s*", "")

	current_indent = count_leading_tabs(line)

	if current_indent > previous_indent then
		parent_table = current_table
		current_table = {}
	elseif current_indent < previous_indent then
		current_table = parent_table
	else
		table.insert(current_items, line_wo_lws)
	end

	previous_indent = current_indent
	previous_title = line_wo_lws
end

-- Print the table sorted
function print_table(table)
	if table.title then
		print(table.title)
	end

	if table.items then
		
	end	
end

print_table(tab_tree)

