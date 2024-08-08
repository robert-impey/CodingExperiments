open System.Text

let multiply n a = [1 .. n ] |> List.fold (fun a' _ -> a' + a) 0

multiply 5 10

let sumOfFirst n = [1 .. n] |> List.fold (fun a n' -> a + n') 0

sumOfFirst 10

let numbers = ["one"; "two"; "three"]

let forwardSb = numbers |> List.fold (fun (a: StringBuilder) w -> a.Append(w)) (StringBuilder())
forwardSb.ToString()
