a = [2, 4]
b = Enum.map(a, &(&1 * 2))

IO.puts(Enum.join(a, ", "))
IO.puts(Enum.join(b, ", "))
