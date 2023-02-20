defmodule MyList do
  def len([]), do: 0
  def len([_head|tail]), do: 1 + len(tail)

  def test_len() do
    IO.puts len([])
    IO.puts len([1, 2, 3])
    IO.puts len(["dogs", "cats"])
  end

  def square([]), do: []
  def square([head|tail]), do: [ head * head | square(tail) ]

  def test_square() do
    IO.puts square([])
    IO.puts square([0, 1, 2, 3, 4, 5, 6, 7])
  end

  def add_1([]), do: []
  def add_1([head|tail]), do: [ head + 1 | add_1(tail) ]

  def test_add_1() do
    IO.puts add_1([])
    IO.puts add_1([0, 1, 2, 3, 4, 5, 6, 7])
  end

  def map([], _func), do: []
  def map([head|tail], func), do: [ func.(head) | map(tail, func) ]

  def test_map() do
    IO.puts map([], &(&1 * &1))
    IO.puts map([0, 1, 2, 3, 4, 5, 6, 7], &(&1 * &1))

    IO.puts map([], &(&1 + 1))
    IO.puts map([0, 1, 2, 3, 4, 5, 6, 7], &(&1 + 1))
  end
end
