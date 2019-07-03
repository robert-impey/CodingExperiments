list_concat = fn a, b -> a ++ b end
list_concat.([:a, :b], [:c, :d])

sum = fn v -> Enum.sum(v) end
sum.([1, 2, 3])

pair_tuple_to_list = fn {a, b} -> [a, b] end
pair_tuple_to_list.({1234, 5678})
