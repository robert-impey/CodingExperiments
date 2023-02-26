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
end
