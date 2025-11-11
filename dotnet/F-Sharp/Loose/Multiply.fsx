// See Chapter 1 of "From Mathematics to Generic Programming"
// by Stepanov and Rose

let rec multiply0 n a =
    match n with
    | 1 -> a
    | _ -> a + multiply0 (n - 1) a

printfn "multiply0 50 100 = %d" (multiply0 50 100)

let half x = x / 2
let odd x = x % 2 <> 0

let rec multiply1 n a =
  match n with
  | 1 -> a
  | _ ->
      let r = multiply1 (half n) (a + a) in
      if odd n then r + a else r

printfn "multiply1 50 100 = %d" (multiply1 50 100)

let rec mult_acc0 n a =
    let rec mult_acc0' r n a =
      match n with
      | 1 -> r + a
      | _ ->
          if odd n then mult_acc0' (r + a) (half n) (a + a)
          else mult_acc0' r (half n) (a + a)
    mult_acc0' 0 n a

printfn "mult_acc0 50 100 = %d" (mult_acc0 50 100)

let rec mult_acc1 n a =
    let rec mult_acc1' r n a =
      match n with
      | 1 -> r + a
      | _ ->
          let r_updated = if odd n then r + a else r in
          mult_acc1' r_updated (half n) (a + a)
    mult_acc1' 0 n a

printfn "mult_acc1 50 100 = %d" (mult_acc1 50 100)
