t = {}

t.one = 1
t.two = 2
t.three = 3
t.four = 4

function print_table(t)
	print "Printing..."
	for k,v in pairs(t) do
		print(k, v)
	end
end

print_table(t)

table.sort(t)

print_table(t)

table.sort(t, function(a, b) return a[1] < b[1] end)

print_table(t)

