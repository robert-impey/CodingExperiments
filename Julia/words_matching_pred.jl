#!/usr/bin/env julia

function read_dictionary(dictionary_file::String)
    dictionary = []

    # Read the dictionary file
    fin = open(dictionary_file, "r") do fin
        for line in eachline(fin)
            push!(dictionary, line)
        end
    end

    return dictionary
end

function find_words_by_predicate(dictionary, pred)
    matching_words = []

    for line in dictionary
        if pred(line)
            push!(matching_words, line)
        end
    end

    return matching_words
end

function print_long_words(dict)
    println("Words with more than 20 characters:")
    println("-----")
    long_words = find_words_by_predicate(dict, x -> length(x) > 20)

    for word in long_words
        println(word)
    end

    println("-----")

    println("Number of long words: ", length(long_words))
end

function main()
    println("-----")

    println("Finding Words with 5 characters:")
    println("-----")
    five_letter_words = find_words_by_predicate(dict, x -> 5 == length(x))
    println("Number of words with 5 letters: ", length(five_letter_words))
end

data_dir = abspath(ENV["DATA"])

fn = "british-english.txt"

dict_file = joinpath(data_dir, fn)

dict = read_dictionary(dict_file)

if abspath(PROGRAM_FILE) == @__FILE__
    main()
end
