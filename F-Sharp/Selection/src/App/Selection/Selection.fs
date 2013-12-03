namespace Selection

module SelectionHelper =
    /// Assumes items are sorted
    let getLowestOrLowestItemGreaterThan (bar : int) (items : int seq) = 
        if Seq.isEmpty items then None
        else
            Seq.tryPick (fun item -> 
                if item > bar then Some item 
                else None
            ) items