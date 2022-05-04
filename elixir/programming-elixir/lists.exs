defmodule MyList do
    def len([]), do: 0
    def len([_|tail]), do: 1 + len(tail)
    
    def square([]), do: []
    def square([head|tail]), do: [head * head | square(tail) ]
    
    def add_1([]), do: []
    def add_1([h|t]), do: [h + 1 | add_1(t)]
    
    def map([], _func), do: []
    def map([h|t], func), do: [func.(h)|map(t,func)]
    
    def square_v2(l), do: map(l, &(&1 * &1))
    def add_1_v2(l), do: map(l, &(&1 + 1))
    
    def reduce([], v, _f), do: v
    def reduce([h|t], v, f) do
        reduce(t, f.(h, v), f)
    end
    
    def sum_of(l), do: reduce(l, 0, &(&1 + &2))
    def product_of(l), do: reduce(l, 1, &(&1 * &2))
end
