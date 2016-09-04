#!/usr/bin/env lua5.3

io.input('file-to-backup.txt')
io.output('backup.txt')

for line in io.lines() do
	print(line)
	io.write(line, "\n")
end

