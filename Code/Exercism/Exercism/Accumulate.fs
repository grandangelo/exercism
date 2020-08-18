module Accumulate

let rec private applyFunc (accumulator: 'b list) (func: 'a -> 'b) (input: 'a list): 'b list =
    match input with
    | [] -> accumulator
    | head::tail -> applyFunc ((accumulator::(func head)) (func) (tail)

let accumulate (func: 'a -> 'b) (input: 'a list): 'b list = 
    applyFunc [] func input
