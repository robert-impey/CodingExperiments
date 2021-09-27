(* See https://ocaml.org/learn/tutorials/a_first_hour_with_ocaml.html#Imperative-OCaml *)

let swap a b =
  let t = !a in
  a := !b;
  b := t
