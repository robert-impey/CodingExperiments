open FSharp.Data
open System

let dataDir = Environment.GetEnvironmentVariable("DATA")

type BaltimoreRestaurants = XmlProvider<"BaltimoreRestaurantsSample.xml">

let restaurantsFile = IO.Path.Join(dataDir, "BaltimoreRestaurants.xml")

let restaurants = BaltimoreRestaurants.Load(restaurantsFile)

let names = restaurants.Rows |> Array.map (fun r -> r.Name)

printfn "There are %d restaurants in the list" restaurants.Rows.Length

for n in names do
  printfn "Name: %s" n
