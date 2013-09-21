// Translating the algebra at http://www.purplemath.com/modules/fcncomp.htm to F#
// Robert Impey 2013-09-21

let f = 
    function
    | Some -2 -> Some 3
    | Some -1 -> Some 1
    | Some 0 -> Some 0
    | Some 1 -> Some -1
    | Some 2 -> Some -3
    | _ -> None

let g =
    function
    | Some -3 -> Some 1
    | Some -1 -> Some -2
    | Some 0 -> Some 2
    | Some 2 -> Some 2
    | Some 3 -> Some 1
    | _ -> None

let i = f (Some 1)

let ii = g (Some -1)

// Nested
let iiiN = g (f (Some 1))

// Pipe-forward
let iiiP = Some 1 |> f |> g

// Backward function composition

let gComposeF = g << f
let iiiF = gComposeF (Some 1)

// Backward composition with pipe-backward
let iiiBCP = g << f <| Some 1

// Forward composition with pipe-backward
let iiiFCBP = f >> g <| Some 1
