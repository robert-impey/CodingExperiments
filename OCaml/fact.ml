let rec fact x = if x <= 1 then 1 else x * fact (x - 1)

;;
print_int (fact 5)

;;
print_newline ()
