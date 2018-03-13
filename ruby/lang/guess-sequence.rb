#!/usr/bin/env ruby

def string_is_number(candidate)
  candidate =~ /^\s*[-+]?[0-9]+(?:\.[0-9]+)?\s*$/
end

def number_is_integer(candidate)
  candidate =~ /^\s*[-+]?[0-9]+\s*$/
end

def are_in_sequence(list)
  if list.all? {|cand| number_is_integer(cand)}
    intList = list.map(&:to_i)

    return true if (intList[0] < intList[1]) && (intList[1] < intList[2])
  end

  false
end

def validate(list)
  if list.count == 3
    return true if list.all? {|cand| string_is_number(cand)}
  end

  false
end

if $PROGRAM_NAME == __FILE__
  puts <<HLP
I am thinking of an infinite sequence of numbers.

You need to try to guess the sequence.

You can find out about the sequence by giving me lists of 3 numbers.

I will say "Yes" or "No" depending on whether the numbers appear in the sequence in the same order.

To get you started, I will give you these three numbers that meet the criteria for saying "Yes":

2 4 6

Press "q" to quit.

HLP

  loop do
    puts 'Please give me the next candidate list: '

    list = gets.chomp.split(/\s+/)

    if list[0].casecmp('q').zero?
      puts 'OK, bye!'
      break
    end

    if validate(list)
      if are_in_sequence(list)
        puts 'Yes'
      else
        puts 'No'
      end
    else
      puts 'I asked for 3 numbers!'
    end
  end
end
