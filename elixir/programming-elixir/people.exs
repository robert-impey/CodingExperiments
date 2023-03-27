defmodule People do
  @people [
    %{name: "Grumpy", height: 1.24},
    %{name: "Rob", height: 1.83},
    %{name: "Dopey", height: 1.32},
    %{name: "Shaquille", height: 2.16},
    %{name: "Sneezy", height: 1.28}
  ]

  def inspect_people do
    IO.inspect(@people)
  end

  def inspect_tall_people do
    IO.inspect(for person = %{height: height} <- @people, height > 1.5, do: person)
  end

  # E.g. People.apply_to_people(&HotelRoom.book/1)
  def apply_to_people func do
    @people |> Enum.each(func)
  end
end
