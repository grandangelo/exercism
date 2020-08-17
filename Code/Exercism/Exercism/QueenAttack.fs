module QueenAttack

let private isValidIndex (index: int) =
    index >= 0 && index <= 7

let private isValidPosition (position: int * int) =
    isValidIndex(fst position) && isValidIndex(snd position)

let private isSameLine (queen1: int * int) (queen2: int * int) =
    fst queen1 = fst queen2 || snd queen1 = snd queen2

let private isSameDiagonal (queen1: int * int) (queen2: int * int) =
    abs(fst queen1 - fst queen2) = abs(snd queen1 - snd queen2)

let private isSameSquare (queen1: int * int) (queen2: int * int) =
    queen1 = queen2

let create (position: int * int) = 
    isValidPosition(position)

let canAttack (queen1: int * int) (queen2: int * int) = 
    if isSameSquare queen1 queen2 then failwith "Can not occupy same square"
    isSameLine queen1 queen2 || isSameDiagonal queen1 queen2
