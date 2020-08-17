module Accumulate

let accumulate (func: 'a -> 'b) (input: 'a list): 'b list = 
    let rec accumulateTo accumulator func list =      
        match list with
        | [] -> accumulator
        | head::tail -> accumulateTo (func(head)::accumulator) (func) (tail)

    accumulateTo [] func input 
    |> accumulateTo [] id

