// 2013-05-25
let cube x = x * x * x
cube 4 
cube 4 |> ignore

let names = ("Robert", "Impey")
fst names
snd names

let allNames = ("Robert", "Francis", "Impey")
fst allNames

let add x y = x + y
add 4 5

let tupleAdd (x, y) = x + y
tupleAdd (4, 5)
tupleAdd 4 5

let vowels = ['a'; 'e'; 'i'; 'o'; 'u']
let sometimes = 'y' :: vowels

let someConsonants = ['b'; 'c'; 'd']
let someOfTheAlphabet = vowels @ someConsonants

let countDown = [5 .. -1 .. 0]

let isMultipleOfFour x = x % 4 = 0

let evens = [for i in [1 .. 10] do if i % 2 = 0 then yield i]
let odds = [for i in [1 .. 10] do if i % 2 <> 0 then yield i]
List.length evens
List.head evens
List.tail evens
List.exists isMultipleOfFour evens
List.exists isMultipleOfFour odds
List.map cube evens

for i in [1..10] do printfn "%d" i
let printI x = printfn "%d" x
List.iter printI [1..10]

// 2013-05-29
let isEven x = (x % 2 = 0)
let moreEvens, moreOdds = List.partition isEven [1 .. 10]

// 2013-07-16
0b001
0b010
0b011
0b100
0b101
0b110
0b111

0b001 <<< 2
0b010 >>> 1
0b001 <<< 1
0b011 <<< 1
