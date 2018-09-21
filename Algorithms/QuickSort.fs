module QuickSort
    let rec quicksort list = 
        printfn "%A" (list)
        match list with
        | [] ->
            []
        | firstElement::otherElements ->
            let smallerElements = 
                otherElements
                |> List.filter(fun e -> e < firstElement)
                |> quicksort
            let largerElements =
                otherElements
                |> List.filter(fun e -> e >= firstElement)
                |> quicksort
            List.concat [smallerElements; [firstElement];largerElements]
