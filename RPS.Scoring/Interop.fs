namespace RPS.Scoring

[<System.Runtime.CompilerServices.Extension>]
module Interop =

    let PlayGame (p1 : Player) (p2 : Player) =
        RPS.Scoring.Gameplay.playGame p1 p2
