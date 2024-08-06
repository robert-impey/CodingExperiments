open FSharp.Data
open System

let dataDir = Environment.GetEnvironmentVariable("DATA")

type BaltimoreRestaurants = XmlProvider<"BaltimoreRestaurantsSample.xml">

let restaurantsFile = IO.Path.Join(dataDir, "BaltimoreRestaurants.xml")

let restaurants = BaltimoreRestaurants.Load(restaurantsFile)

let names = restaurants.Rows |> Array.map (fun r -> r.Name)

for n in names do
  printfn "Name: %s" n

printfn "There are %d restaurants in the list" restaurants.Rows.Length
