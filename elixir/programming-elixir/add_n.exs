add_n = fn n ->
  fn a -> n + a end;
end

incr = add_n.(1);
IO.puts incr.(99);
