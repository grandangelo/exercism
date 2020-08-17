module QueenAttack

let private isValidIndex (index: int) =
    index >= 0 && index <= 7

let private isValidPosition (position: int * int) =
    isValidIndex(fst position) && isValidIndex(snd position)

let create (position: int * int) = 
    isValidPosition(position)

let canAttack (queen1: int * int) (queen2: int * int) = failwith "You need to implement this function."
