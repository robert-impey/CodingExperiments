let multiply n a =
    [1 .. n ]
    |> List.fold (fun a' _ ->
       a' + a 
    ) 0

multiply 5 10
