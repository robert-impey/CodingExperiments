defmodule MyLists do
  def contains(_,[]), do: false
  def contains(h, [h|_]), do: true
  def contains(i, [_|t]), do: contains(i, t)

  def test_contains() do
    IO.puts(contains(1, []))
    IO.puts(contains(1, [1]))
    IO.puts(contains(1, [2]))
    IO.puts(contains(1, [1,2]))
    IO.puts(contains(1, [2,3]))
    IO.puts(contains(1, [1,2,3]))
    IO.puts(contains(1, [2,3,4]))
  end
end
