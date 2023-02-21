a = {:ok, 5}
b = {:err, nil}

{:ok, c} = a

IO.puts "#{c}"
IO.puts "#{5 = c}"

{:err, d} = b

IO.puts "#{is_nil(d)}"
