defmodule MyVec do
  def print({:error, _v}) do
    IO.puts("Error!")
  end

  def print({:ok, v}) do
    print(v)
  end

  def print(v) do
    IO.puts(Enum.join(v, ", "))
  end

  def add(a, b) when length(a) != length(b), do: {:error, []}
  def add(a, b), do: add(a, b, [])
  defp add([], [], v), do: {:ok, Enum.reverse(v)}

  # These should never match because of the when check above.
  defp add(_a, [], _), do: {:error, []}
  defp add([], _b, _), do: {:error, []}

  defp add([h1 | t1], [h2 | t2], v) do
    add(t1, t2, [h1 + h2 | v])
  end

  def test_add() do
    a = [2, 4]
    b = Enum.map(a, &(&1 * 2))

    MyVec.print(a)
    MyVec.print(b)

    c = [3, 5]
    MyVec.print(c)

    d = MyVec.add(a, c)
    MyVec.print(d)

    MyVec.print(MyVec.add([1, 2], [1, 2, 3]))
    MyVec.print(MyVec.add([1, 2, 3], [1, 2]))
  end
end
