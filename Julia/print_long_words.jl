#!/usr/bin/env julia

function find_long_words(dictionary_file::String)
	long_words = []

	# Read the dictionary file
	fin = open(dictionary_file, "r") do fin
		for line in eachline(fin)
			if length(line) > 20
				push!(long_words, line)
			end
		end
	end

	return long_words
end

function print_long_words(dictionary_file::String)
	long_words = find_long_words(dictionary_file)

	for word in long_words
		println(word)
	end

	println("-----")

	println("Number of long words: ", length(long_words))
end

data_dir = abspath(ENV["DATA"])

fn = "british-english.txt"

dict_file = joinpath(data_dir, fn)

print_long_words(dict_file)
