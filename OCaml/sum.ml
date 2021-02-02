(* https://en.wikipedia.org/wiki/OCaml *)

let rec sum integers =
    match integers with
    | [] -> 0
    | first :: rest -> first + sum rest;;

Printf.printf "Sum: %d\n" (sum [1; 2; 3; 4; 5]);;

