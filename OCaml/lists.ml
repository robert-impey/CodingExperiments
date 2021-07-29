(* 
 * https://en.wikipedia.org/wiki/OCaml 
 * https://ocaml.org/learn/tutorials/a_first_hour_with_ocaml.html#Lists
 *)

let rec sum integers =
  match integers with [] -> 0 | first :: rest -> first + sum rest
