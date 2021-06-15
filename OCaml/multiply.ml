let rec multiply0 n a =
    match n with
    | 1 -> a
    | _ -> a + multiply0 (n - 1) a
