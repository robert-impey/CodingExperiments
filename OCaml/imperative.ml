(* See https://ocaml.org/learn/tutorials/a_first_hour_with_ocaml.html#Imperative-OCaml *)

let swap a b =
  let t = !a in
  a := !b;
  b := t

let print_number n =
  print_string (string_of_int n);
  print_newline ()
;;

print_number 10

let table n =
  for row = 1 to n do
    for column = 1 to n do
      print_string (string_of_int (row * column));
      print_string " "
    done;
    print_newline ()
  done
;;

table 10
