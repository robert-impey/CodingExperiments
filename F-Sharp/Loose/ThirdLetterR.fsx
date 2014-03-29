open System.Text.RegularExpressions

let words = System.IO.File.ReadLines(@"C:\Users\Robert\data\british-english.csv")

Seq.length words

let isPossessiveRegex = Regex(@"'s\s*$")

let wordsWithoutPossessives =
    words 
    |> Seq.filter (fun word -> not <| isPossessiveRegex.IsMatch(word))

Seq.length wordsWithoutPossessives

let firstLetterIsRRegex = Regex(@"^R", RegexOptions.IgnoreCase)
let thirdLetterIsRRegex = Regex(@"^\w{2}R", RegexOptions.IgnoreCase)

let findWordsMatchingRegex (regex : Regex) =
    wordsWithoutPossessives
    |> Seq.filter (fun word -> regex.IsMatch(word)) 

let wordsBeginningWithR = findWordsMatchingRegex firstLetterIsRRegex
let wordsWhereThirdLetterIsR = findWordsMatchingRegex thirdLetterIsRRegex

wordsBeginningWithR |> Seq.length
wordsWhereThirdLetterIsR |> Seq.length

wordsBeginningWithR |> Seq.iter (printfn "%s")
wordsWhereThirdLetterIsR |> Seq.iter (printfn "%s")
