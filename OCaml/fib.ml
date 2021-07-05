let rec fib n = if n = 0 || n = 1 then 1 else fib (n - 1) + fib (n - 2)

;;
print_int (fib 5)

;;
print_newline ()
