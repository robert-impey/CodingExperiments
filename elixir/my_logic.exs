defmodule MyLogic do
  def my_not(true), do: false
  def my_not(false), do: true

  def my_and(true, true), do: true
  def my_and(true, false), do: false
  def my_and(false, true), do: false
  def my_and(false, false), do: false

  def my_or(true, true), do: true
  def my_or(true, false), do: true
  def my_or(false, true), do: true
  def my_or(false, false), do: false

  def my_xor(true, true), do: false
  def my_xor(true, false), do: true
  def my_xor(false, true), do: true
  def my_xor(false, false), do: false

  def test_logic() do
    IO.puts("my_not(true): #{my_not(true)}")
    IO.puts("my_not(false): #{my_not(false)}")

    IO.puts("my_and(true, false): #{my_and(true, false)}")
    IO.puts("my_or(false, my_not(false)): #{my_or(false, my_not(false))}")

    IO.puts("my_xor(false, true): #{my_xor(false, true)}")

    long_expression = my_xor(my_and(true, false), my_or(false, my_not(false)))
    IO.puts("my_xor(my_and(true, false), my_or(false, my_not(false))): #{long_expression}")
  end
end
