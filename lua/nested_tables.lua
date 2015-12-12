#!/usr/bin/env lua

fruits = {}

table.insert(fruits, "bananas")
table.insert(fruits, "apples")
table.insert(fruits, "coconuts")

function print_fruits(these_fruits)
	for _, fruit in pairs(fruits) do
		print(fruit)
	end
end

print("Unsorted fruits")
print_fruits(fruits)

table.sort(fruits)

print("Sorted fruits")
print_fruits(fruits)

nested_fruits = {}
nested_fruits.apples = { "Golden Delicious", "Queen Cox", "Granny Smith" }
nested_fruits.bananas = { "Cavendish", "Williams", "Pisang Raja" }
nested_fruits.coconuts = { "Malayan Yellow", "Camaroon Red", "Nias Green" }

function print_nested_fruits(these_nested_fruits)
	for fruit, varieties in pairs(these_nested_fruits) do
		print(fruit)
		sorted_varieties = {}
		for _, v in pairs(varieties) do
			table.insert(sorted_varieties, v)
		end

		for _, v in pairs(sorted_varieties) do
			print("\t", v)
		end
	end
end

print("Unsorted nested fruits")
print_nested_fruits(nested_fruits)

table.sort(nested_fruits)

print("Sorted nested fruits")
print_nested_fruits(nested_fruits)

print("Sorted families")
fruit_families = {}
for fruit_family, _ in pairs(nested_fruits) do
	table.insert(fruit_families, fruit_family)
end

table.sort(fruit_families)

for _, fruit_family in pairs(fruit_families) do
	print(fruit_family)
	varieties = {}
	for _, variety in pairs(nested_fruits[fruit_family]) do
		table.insert(varieties, variety)
	end

	table.sort(varieties)

	for _, variety in pairs(varieties) do
		print("\t", variety)
	end
end

