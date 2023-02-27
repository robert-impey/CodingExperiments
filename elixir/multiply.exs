defmodule Multiply do
  def multiply(a, 1), do: a
  def multiply(a, n), do: a + multiply(a, n - 1)
end
