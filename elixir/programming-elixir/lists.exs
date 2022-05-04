defmodule MyList do
    def len([]), do: 0
    def len([_|tail]), do: 1 + len(tail)
    
    def square([]), do: []
    def square([head|tail]), do: [head * head | square(tail) ]
    
    def add_1([]), do: []
    def add_1([h|t]), do: [h + 1 | add_1(t)]
end
