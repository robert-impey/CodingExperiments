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

  def add(a, b), do: add_(a, b, [])
  def add_([], [], v), do: {:ok, Enum.reverse v }
  def add_(_a, [], _), do: {:error, [] }
  def add_([], _b, _), do: {:error, [] }
  def add_([h1|t1], [h2|t2], v) do
    add_(t1, t2, [h1 + h2 | v])
  end
end

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
