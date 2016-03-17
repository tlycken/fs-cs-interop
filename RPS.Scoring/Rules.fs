namespace RPS.Scoring

module Rules =

    let above a =
        match a with
        | Rock -> Paper
        | Paper -> Scissors
        | Scissors -> Rock

    let below a =
        match a with
        | Rock -> Scissors
        | Paper -> Rock
        | Scissors -> Paper

    let outcome (a : Play) (b : Play) =
        if a.Move = above b.Move then Winner a.Player
        else if b.Move = above a.Move then Winner b.Player
        else Draw
