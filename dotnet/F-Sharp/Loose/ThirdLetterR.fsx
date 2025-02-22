open System.IO
open System.Text.RegularExpressions

let dataDir = System.Environment.GetEnvironmentVariable("DATA")

let englishCsv = Path.Join(dataDir, "british-english.csv")

let words = File.ReadLines(englishCsv)

words |> Seq.length

let isPossessiveRegex = Regex(@"'s\s*$")

let wordsWithoutPossessives =
    words 
    |> Seq.filter (fun word -> not <| isPossessiveRegex.IsMatch(word))

wordsWithoutPossessives |> Seq.length

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
