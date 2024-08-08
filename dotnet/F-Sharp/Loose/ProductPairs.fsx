// See http://www.geeksforgeeks.org/amazon-interview-experience-set-140-experienced-sde/

let addFactorsPair (x, cur) pairs factor =
    if factor * cur = x then
        (factor, cur) :: pairs
    else
        pairs    

addFactorsPair (15, 5) [] 3
addFactorsPair (15, 5) [] 2

let uniq : int list -> int list  = 
    Set.ofList
    >> List.ofSeq

let findPairs x xs =
    xs
    |> uniq
    |> List.sort
    |> List.fold (fun (pairs, previousFactors) cur ->
        let pairs'', previousFactors' = 
            if x % cur = 0 then
                let newFactors = cur :: previousFactors 
                let pairs' = 
                    List.fold (addFactorsPair (x, cur)) pairs newFactors
                pairs', newFactors
            else
                pairs, previousFactors 
        pairs'', previousFactors'
    ) ([], [])
    |> fst

let xs = [1 .. 10]
let x = 15

findPairs x xs
findPairs x (List.rev xs)
findPairs 17 xs
findPairs 15 [3; 3; 5]
