#!/usr/bin/env ruby

puts <<HLP
Try to guess the sequence.

I am thinking of an infinite sequence of numbers.

You need to try to guess the sequence.

You can find out about the sequence by giving me lists of 3 numbers.

I will say "Yes" or "No" depending on whether the numbers appear
in the sequence in the same order.

Press "q" to quit.

To get you started, I will give you these three numbers:

2, 4, 6
HLP

def are_in_sequence(list)
	if list.all? {|cand| cand =~ /^\s*[-+]?[1-9]([0-9]*)?\s*$/ } then
		intList = list.map { |s| s.to_i }

		if intList[0] < intList[1] and intList[1] < intList[2] then
			return true
		end
	end
	
	return false
end

def validate(list)
	if list.count == 3 then
		if list.all? {|cand| cand =~ /^\s*[-+]?[1-9]([0-9]*)?(?:\.[0-9]+)?\s*$/ } then
			return true
		end
	end
	
	return false
end

while true do
	puts "Please give me the next candidate list: "

	list = gets.chomp.split(",")
	
	if list[0].downcase == "q" then
		puts "OK, bye!"
		break
	end
	
	if validate(list) then	
		if are_in_sequence(list) then
			puts "Yes"
		else
			puts "No"
		end
	else
		puts "I asked for 3 numbers!"
	end
end
