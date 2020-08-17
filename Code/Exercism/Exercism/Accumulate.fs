module Accumulate

let rec private applyFunction (func: 'a -> 'b) (input: 'a list) (currentResult: 'b list): 'b list =
    match input with
    | [] -> currentResult
    | _ -> let newResult = Seq.append currentResult (func input.Head) |> Seq.toList 
           applyFunction func input.Tail newResult

let accumulate (func: 'a -> 'b) (input: 'a list): 'b list = 
    let result = []
    applyFunction func input result

