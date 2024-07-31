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

  def odd_rec(n), do: odd_(n, true)

  def test_odd_rec() do
    IO.puts(odd_rec(0))
    IO.puts(odd_rec(1))
    IO.puts(odd_rec(2))
    IO.puts(odd_rec(37))
    IO.puts(odd_rec(100))
  end

  def odd(0), do: false
  def odd(1), do: true
  def odd(n), do: odd(rem(n, 2))

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

  require Integer

  def multiply1(a, 1), do: a
  def multiply1(a, n) when Integer.is_odd(n) do
    a + multiply1(a + a, half(n))
  end
  def multiply1(a, n), do: multiply1(a + a, half(n))

  def test_multiply1() do
    IO.puts(multiply1(1, 1))
    IO.puts(multiply1(37, 41))
    IO.puts(multiply1(100_000_000, 100))
    IO.puts(multiply1(100, 100_000_000))
  end

  def mult_acc0_(r, 1, a), do: r + a
  def mult_acc0_(r, n, a) when Integer.is_odd(n) do
    mult_acc0_(r + a, half(n), a + a)
  end
  def mult_acc0_(r, n, a), do: mult_acc0_(r, half(n), a + a)

  def mult_acc0(a, n), do: mult_acc0_(0, n, a)

  def test_mult_acc0() do
    IO.puts(mult_acc0(1, 1))
    IO.puts(mult_acc0(37, 41))
    IO.puts(mult_acc0(100_000_000, 100))
    IO.puts(mult_acc0(100, 100_000_000))
  end
end
