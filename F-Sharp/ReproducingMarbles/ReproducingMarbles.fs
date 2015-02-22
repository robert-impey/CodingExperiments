module ReproducingMarbles

type Colour = 
    | Blue
    | Brown

type Population = Map<Colour, int>

let countPopulation (population : Population) = 
    population
    |> Map.toSeq
    |> Seq.sumBy snd

let pickFromPopulation (population : Population) = 
    let size = countPopulation population
    let randomNumberGenerator = new System.Random()
    let randomIndex = randomNumberGenerator.Next size
    
    let pickedColour = 
        population
        |> Map.toSeq
        |> Seq.fold (fun (pickedColour, taken) (colour, size) -> 
               match pickedColour with
               | None -> 
                   let newTaken = taken + size
                   if newTaken >= randomIndex then Some colour, 0
                   else None, newTaken
               | Some _ -> pickedColour, 0) (None, 0)
        |> fst
    match pickedColour with
    | Some pickedColour' -> pickedColour'
    | None -> failwith "No colour picked!"

let colourListToPopulation (picks : Colour list) = 
    let rec colourListToPopulation' (picks : Colour list) (population : Population) = 
        match picks with
        | [] -> population
        | hd :: tl -> 
            let newColourCount = 
                if Map.containsKey hd population then population.[hd] + 1
                else 1
            
            let newPopulation = Map.add hd newColourCount population
            colourListToPopulation' tl newPopulation
    colourListToPopulation' picks Map.empty

let colourToString = 
    function 
    | Blue -> "Blue"
    | Brown -> "Brown"

let rec evolve generations (marbles : Population) = 
    if generations = 0 then marbles
    else 
        let populationSize = countPopulation marbles
        
        let rec reproduce (currentMarbles : Colour list) = 
            if currentMarbles.Length = populationSize then currentMarbles
            else 
                let newMarble = pickFromPopulation marbles
                reproduce (newMarble :: currentMarbles)
        []
        |> reproduce
        |> colourListToPopulation

let printPopulation (population : Population) = 
    population
    |> Map.toSeq
    |> Seq.iter (fun (colour, count) -> printfn "%s - %d" (colourToString colour) count)
