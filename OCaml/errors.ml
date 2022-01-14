(* See https://ocaml.org/learn/tutorials/a_first_hour_with_ocaml.html#Dealing-with-errors *)

exception E
exception E2 of string

let f1 a b = if b = 0 then raise (E2 "Division by zero!") else a / b
let v1 = try f1 10 0 with E2 _ -> 0
let f2 a b = if b = 0 then None else Some (a / b)
let v2 = f2 10 0
let v3 = f2 10 5
let list_find_opt1 p l = try Some (List.find p l) with Not_found -> None
let l1 = [ 1; 2; 3; 4 ]
let first_even1 = list_find_opt1 (fun (x : int) -> 0 = x mod 2) l1
let first_even1a = list_find_opt1 (fun (x : int) -> 0 = x mod 2) [ 1; 3; 5 ]

let list_find_opt2 p l =
  match List.find p l with v -> Some v | exception Not_found -> None

let first_even2 = list_find_opt2 (fun (x : int) -> 0 = x mod 2) l1
let first_even2a = list_find_opt2 (fun (x : int) -> 0 = x mod 2) [ 1; 3; 5 ]
