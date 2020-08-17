module Accumulate



let accumulate (func: 'a -> 'b) (input: 'a list): 'b list = 
    let result = Seq.map func input
    Seq.toList result
