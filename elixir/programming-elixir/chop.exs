# Modules and Functions 6, p. 63

defmodule Chop do
    def guess(target, low..high) when target < low or target > high do
        IO.puts "#{target} is out of range!"
    end
    
    def guess(target, low..high) do
        range = high - low
        min_guesses = Kernel.trunc(:math.ceil(:math.log(range)))
        allowed_guesses = min_guesses + 2
        IO.puts "< I'm going to allow you #{allowed_guesses} guesses."
        guess(target, low..high, allowed_guesses)
    end
    
    def guess(target, low..high, allowed_guesses) do
        IO.puts "> It's in the range #{low} to #{high}"
        range = high - low
        new_guess = div(range, 2) + low
        IO.puts "> Is it #{new_guess}?"
        guess(target, low..high, new_guess, allowed_guesses)
    end
    
    def guess(target, _, _, allowed_guesses) when allowed_guesses == -1 do
        IO.puts "< You've used up all your allowed guesses!"
        IO.puts "< The answer was #{target}"
        target
    end
    
    def guess(target, _, current_guess, _) when target == current_guess do
        IO.puts "< It is #{current_guess}!"
        current_guess
    end
    
    def guess(target, low.._, current_guess, allowed_guesses) when current_guess > target do
        IO.puts "< Too high!"
        guess(target, low..current_guess - 1, allowed_guesses - 1)
    end
    
    def guess(target, _..high, current_guess, allowed_guesses) when current_guess < target  do
        IO.puts "< Too low!"
        guess(target,  current_guess + 1..high, allowed_guesses - 1)
    end
end
