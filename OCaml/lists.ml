(* 
 * https://ocaml.org/learn/tutorials/a_first_hour_with_ocaml.html#Lists
 *)

let rec total l = match l with [] -> 0 | h :: t -> h + total t
let rec length l = match l with [] -> 0 | _ :: t -> 1 + length t
let rec append a b = match a with [] -> b | h :: t -> h :: append t b
let rec map f l = match l with [] -> [] | h :: t -> f h :: map f t
let add a b = a + b
