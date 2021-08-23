(* See https://ocaml.org/learn/tutorials/a_first_hour_with_ocaml.html#Other-built-in-types *)

let t = (1, "one", '1')

type person = { first_name : string; surname : string; age : int }

let frank = { first_name = "Frank"; surname = "Smith"; age = 40 }

let s = frank.surname
