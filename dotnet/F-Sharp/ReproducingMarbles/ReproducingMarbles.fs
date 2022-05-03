module ReproducingMarbles

type Colour = 
    | Blue
    | Brown

type Population = Map<Colour, int>

let countPopulation (population : Population) = 
    population
    |> Map.toSeq
    |> Seq.sumBy snd

let private randomNumberGenerator = System.Random()

let pickFromPopulation (population : Population) = 
    let size = countPopulation population
    let randomIndex = randomNumberGenerator.Next size
    
    let pickedColour = 
        population
        |> Map.toSeq
        |> Seq.fold (fun (pickedColour, taken) (colour, size) -> 
               match pickedColour with
               | None -> 
                   let newTaken = taken + size
                   if newTaken > randomIndex then Some colour, 0
                   else None, newTaken
               | Some _ -> pickedColour, 0) (None, 0)
        |> fst
    match pickedColour with
    | Some pickedColour' -> pickedColour'
    | None -> failwith "No colour picked!"

let addColourToPopulation (population : Population) (colour : Colour) = 
    let newColourCount = 
        if Map.containsKey colour population then population.[colour] + 1
        else 1
    Map.add colour newColourCount population

let colourListToPopulation : Colour list -> Population = List.fold addColourToPopulation Map.empty

let colourToString = 
    function 
    | Blue -> "Blue"
    | Brown -> "Brown"

let reproduce (population : Population) = 
    let populationSize = countPopulation population
    
    let rec reproduce' (currentPopulation : Colour list) = 
        if currentPopulation.Length = populationSize then currentPopulation
        else 
            let newIndividual = pickFromPopulation population
            let newPopulation = newIndividual :: currentPopulation
            reproduce' newPopulation
    []
    |> reproduce'
    |> colourListToPopulation

let evolve generations (population : Population) = 
    let rec evolve' currentGeneration currentPopulation = 
        if currentGeneration = generations then currentPopulation
        else 
            let newPopulation = reproduce currentPopulation
            let newGeneration = currentGeneration + 1
            evolve' newGeneration newPopulation
    evolve' 0 population

let printPopulation (population : Population) = 
    population
    |> Map.toSeq
    |> Seq.iter (fun (colour, count) -> printfn "%s - %d" (colourToString colour) count)
