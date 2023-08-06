defmodule SumIf357 do
  def sum_if_357(n), do: sum_(n, 0)

  def sum_(n, a) when n < 1, do: a
  def sum_(n, a) when rem(n, 3) == 0 or rem(n, 5) == 0 or rem(n, 7) == 0, do: sum_(n - 1, a + n)
  def sum_(n, a), do: sum_(n - 1, a)

  def print(n) do
    sum = sum_if_357(n)
    IO.puts("n = #{n}, sum = #{sum}")
  end
end

SumIf357.print(0)
SumIf357.print(1)
SumIf357.print(3)
SumIf357.print(5)
SumIf357.print(7)
SumIf357.print(10)
SumIf357.print(50)
SumIf357.print(100)
