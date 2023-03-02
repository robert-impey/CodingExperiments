defmodule MyList do
  def len([]), do: 0
  def len([_head|tail]), do: 1 + len(tail)

  def test_len() do
    IO.puts len([])
    IO.puts len([1, 2, 3])
    IO.puts len(["dogs", "cats"])
  end

  def square([]), do: []
  def square([head|tail]), do: [ head * head | square(tail) ]

  def test_square() do
    IO.puts square([])
    IO.puts square([0, 1, 2, 3, 4, 5, 6, 7])
  end

  def add_1([]), do: []
  def add_1([head|tail]), do: [ head + 1 | add_1(tail) ]

  def test_add_1() do
    IO.puts add_1([])
    IO.puts add_1([0, 1, 2, 3, 4, 5, 6, 7])
  end

  def map([], _func), do: []
  def map([head|tail], func), do: [ func.(head) | map(tail, func) ]

  def test_map() do
    IO.puts map([], &(&1 * &1))
    IO.puts map([0, 1, 2, 3, 4, 5, 6, 7], &(&1 * &1))

    IO.puts map([], &(&1 + 1))
    IO.puts map([0, 1, 2, 3, 4, 5, 6, 7], &(&1 + 1))
  end

  def reduce([], value, _func), do: value
  def reduce([head|tail], value, func), do: reduce(tail, func.(head, value), func)

  def test_reduce() do
    IO.puts reduce([1,2,3,4,5], 0, &(&1 + &2))
    IO.puts reduce([1,2,3,4,5], 1, &(&1 * &2))
  end

  def fm_(true, old_max, _, []), do: old_max
  def fm_(false, _, new_max, []), do: new_max
  def fm_(_, nil, nil, []), do: nil
  def fm_(true, old_max, _, [h|t]), do: fm_(old_max > h, old_max, h, t)
  def fm_(false, _, new_max, [h|t]), do: fm_(new_max > h, new_max, h, t)
  def fm_(_, nil, nil, [h|t]), do: fm_(false, nil, h, t)

  def find_max(l) do
    fm_(nil, nil, nil, l)
  end

  def test_find_max() do
    IO.puts find_max([])
    IO.puts find_max([1])
    IO.puts find_max([1,2])
    IO.puts find_max([2,1])
    IO.puts find_max([1,2,3])
    IO.puts find_max([1,3,2])
    IO.puts find_max([3,2,3])
  end

  def return_bigger(a, b) do
    if (is_nil b) or b < a do
      a
    else
      b
    end
  end

  def find_max_reduce(l) do
    reduce(l, nil, &(return_bigger(&1, &2)))
  end

  def test_find_max_reduce() do
    IO.puts find_max_reduce([])
    IO.puts find_max_reduce([1])
    IO.puts find_max_reduce([1,2])
    IO.puts find_max_reduce([2,1])
    IO.puts find_max_reduce([1,2,3])
    IO.puts find_max_reduce([1,3,2])
    IO.puts find_max_reduce([3,2,3])
  end
end
