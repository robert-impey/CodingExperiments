let half n = n / 2
let odd n = n mod 2 == 1

let rec multiply0 n a =
    match n with
    | 1 -> a
    | _ -> a + multiply0 (n - 1) a

let rec multiply1 n a =
    match n with
    | 1 -> a
    | _ ->
            begin
                let r = multiply1 (half n) (a + a) in
                if odd n then r + a else r
            end
