defmodule Multiply do
  def multiply(a, 1), do: a
  def multiply(a, n), do: a + multiply(a, n - 1)

  def odd_(0, false), do: true
  def odd_(0, true), do: false
  def odd_(n, switch), do: odd_(n - 1, not switch)

  def odd(n), do: odd_(n, true)

  def test_odd() do
    IO.puts(odd(0))
    IO.puts(odd(1))
    IO.puts(odd(2))
    IO.puts(odd(37))
    IO.puts(odd(100))
  end
end
