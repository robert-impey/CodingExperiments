<Query Kind="FSharpProgram" />

type Answers =
	| FlightStatus
	| PackageTracking
	| Sports

//let answer = Sports
let answer = PackageTracking

match answer with
| Sports -> printfn "Sports"
| _ -> printfn "Something else!"