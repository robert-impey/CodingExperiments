defmodule Multiply do
  def multiply(a, 1), do: a
  def multiply(a, n), do: a + multiply(a, n - 1)

  def test_multiply() do
    IO.puts(multiply(1, 1))
    IO.puts(multiply(37, 41))
    IO.puts(multiply(100_000_000, 100))
    IO.puts(multiply(100, 100_000_000))
  end

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

  def half(n), do: div(n, 2)

  def test_half() do
    IO.puts(half(50))
    IO.puts(half(51))
  end
end
