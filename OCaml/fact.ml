(* https://ocaml.org/learn/tutorials/a_first_hour_with_ocaml.html#Pattern-matching *)

let rec fact0 x = if x <= 1 then 1 else x * fact0 (x - 1)

let rec fact1 n = match n with 0 | 1 -> 1 | x -> x * fact1 (x - 1)

let rec fact2 n = match n with 0 | 1 -> 1 | _ -> n * fact2 (n - 1)

let rec fact3 = function 0 | 1 -> 1 | n -> n * fact3 (n - 1)
