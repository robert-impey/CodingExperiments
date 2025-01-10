#!/usr/bin/env julia

function find_words_by_predicate(dictionary_file::String, pred)
	long_words = []

	# Read the dictionary file
	fin = open(dictionary_file, "r") do fin
		for line in eachline(fin)
			if pred(line)
				push!(long_words, line)
			end
		end
	end

	return long_words
end

function print_words_by_predicate(dictionary_file::String, pred)
	long_words = find_words_by_predicate(dictionary_file, pred)

	for word in long_words
		println(word)
	end

	println("-----")

	println("Number of words matching the predicate: ", length(long_words))
end

data_dir = abspath(ENV["DATA"])

fn = "british-english.txt"

dict_file = joinpath(data_dir, fn)

println("Words with more than 20 characters:")
println("-----")
print_words_by_predicate(dict_file, x -> length(x) > 20)
