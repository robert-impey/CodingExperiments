defmodule MyList do
  def len([]), do: 0
  def len([_head|tail]), do: 1 + len(tail)

  def test_len() do
    IO.puts len([])
    IO.puts len([1, 2, 3])
    IO.puts len(["dogs", "cats"])
  end
end
