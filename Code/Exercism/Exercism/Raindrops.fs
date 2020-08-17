module Raindrops

let private isFactor target divider =
    target % divider = 0

let private getNote factor =
    match factor with
    | 3 -> "Pling"
    | 5 -> "Plang"
    | 7 -> "Plong"
    | _ -> failwith "Unsupported factor"

let convert (number: int): string = failwith "You need to implement this function."