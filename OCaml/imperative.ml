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

let smallest_power_of_two x =
  let t = ref 1 in
  while !t < x do
    t := !t * 2
  done;
  !t

let rec sp2_ x x_ = if x_ >= x then x_ else sp2_ x (2 * x_)

let sp2 x = sp2_ x 1

let arr = [| 1; 2; 3 |];;

print_string (string_of_int arr.(0));
print_newline ();

print_string (string_of_int arr.(1));
print_newline ();

arr.(1) <- 0;

print_string (string_of_int arr.(1));
print_newline ()
