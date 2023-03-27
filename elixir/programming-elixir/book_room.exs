defmodule HotelRoom do
  def book(%{ name: name, height: height})
  when height > 1.9 do
    IO.puts "We'll need an extra long bed for #{name}"
  end

  def book(%{ name: name, height: height})
  when height < 1.5 do
    IO.puts "We'll need lower shower controls for #{name}"
  end

  def book(person) do
    IO.puts "A normal bed for #{person.name}"
  end
end
