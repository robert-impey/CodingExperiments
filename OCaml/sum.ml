(* https://en.wikipedia.org/wiki/OCaml *)

let rec sum integers =
  match integers with [] -> 0 | first :: rest -> first + sum rest
