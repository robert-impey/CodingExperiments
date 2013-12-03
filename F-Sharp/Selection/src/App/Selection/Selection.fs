namespace Selection

module SelectionHelper =
    let getLowestOrLowestItemGreaterThan (bar : int) (items : int seq) = 
        if Seq.isEmpty items then None
        else
            let bigEnough = 
                items 
                |> Seq.filter (fun item -> item > bar)
        
            if Seq.isEmpty bigEnough then
                None
            else
                Some (bigEnough |> Seq.min)
        