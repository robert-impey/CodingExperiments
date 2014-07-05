io.input('file-to-backup.txt')
io.output('backup.txt')

for line in io.lines() do
	print(line)
	io.write(line, "\n")
end

