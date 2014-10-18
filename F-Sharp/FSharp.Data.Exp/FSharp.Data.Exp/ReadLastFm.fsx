#r @"bin\Debug\FSharp.Data.dll"

open FSharp.Data

type LastFm = HtmlProvider<"http://www.last.fm/user/robert_impey">

let lastFm = LastFm()
