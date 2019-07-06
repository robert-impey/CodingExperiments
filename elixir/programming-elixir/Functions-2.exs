fizz_buzz = fn 
     0, 0, _  -> "FizzBuzz"
     0, _, _  -> "Fizz"
     _, 0, _  -> "Buzz"
     _, _, a  -> a
end

IO.puts fizz_buzz.(0, 0, 15)
IO.puts fizz_buzz.(0, 3, 3)
IO.puts fizz_buzz.(2, 0, 5)
IO.puts fizz_buzz.(1, 2, 7)

IO.puts "...."

rem_fizz_buzz = fn
    x, a, b -> fizz_buzz.(rem(x, a), rem(x, b), x)
end

my_3_5_fizz_buzz = fn
    x -> rem_fizz_buzz.(x, 3, 5)
end

IO.puts my_3_5_fizz_buzz.(10)
IO.puts my_3_5_fizz_buzz.(11)
IO.puts my_3_5_fizz_buzz.(12)
IO.puts my_3_5_fizz_buzz.(13)
IO.puts my_3_5_fizz_buzz.(14)
IO.puts my_3_5_fizz_buzz.(15)
IO.puts my_3_5_fizz_buzz.(16)
