let findSum n =
    let rec findSum' n acc =
        if n < 1 then
            acc
        else if n % 3 = 0 || n % 5 = 0 || n % 7 = 0 then
            findSum' (n - 1) (n + acc)
        else
            findSum' (n - 1) acc
    findSum' n 0

//findSum 1

//> findSum 3;;
//>val it: int = 3

//> findSum 5;;
//> val it: int = 8

//> findSum 7;;
//> val it: int = 21

//> findSum 10;;
//>val it: int = 40

//> findSum 50;;
//>val it: int = 691

findSum 100

//> val it: int = 2838
