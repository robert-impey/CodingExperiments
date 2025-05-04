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

function print_long_words(dict)
    println("Words with more than 20 characters:")
    println("-----")
    long_words = filter(x -> length(x) > 20, dict)

    for word in long_words
        println(word)
    end

    println("-----")

    println("Number of long words: ", length(long_words))
end

data_dir = abspath(ENV["DATA"])

fn = "british-english.txt"

dict_file = joinpath(data_dir, fn)

function main()
    dict = read_dictionary(dict_file)

    println("-----")

    println("Finding Words with 5 characters:")
    println("-----")
    five_letter_words = filter(x -> 5 == length(x), dict)
    println("Number of words with 5 letters: ", length(five_letter_words))

    all_latin = filter(x -> occursin(r"^[A-Za-z]{5}$", x), five_letter_words)
    println("Number of 5 letter words that are all Latin: ", length(all_latin))

    all_latin_uppercase = unique(map(uppercase, all_latin))
    println("Number of unique 5 letter words that are all Latin ignoring case: ",
        length(all_latin_uppercase))
end

if abspath(PROGRAM_FILE) == @__FILE__
    main()
end
