(* See https://ocaml.org/learn/tutorials/a_first_hour_with_ocaml.html#Other-built-in-types *)

let t = (1, "one", '1')

type person = { first_name : string; surname : string; age : int }

let frank = { first_name = "Frank"; surname = "Smith"; age = 40 }

let s = frank.surname

type colour = Red | Green | Blue | Yellow | RGB of int * int * int

let l = [ Red; Blue; Red; RGB (30, 255, 154) ]

type 'a tree = Leaf | Node of 'a tree * 'a * 'a tree

let t = Node (Node (Leaf, 1, Leaf), 2, Node (Node (Leaf, 3, Leaf), 4, Leaf))

let rec total t =
  match t with Leaf -> 0 | Node (l, x, r) -> total l + x + total r

let rec flip t =
  match t with Leaf -> Leaf | Node (l, x, r) -> Node (flip r, x, flip l)

let all = total t

let flipped = flip t
