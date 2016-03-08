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

    let outcome (a' : Play option) (b' : Play option) =
        match (a',b') with
        | Some a, Some b -> if a.Move = above b.Move then Some (Winner a.Player)
                            else if b.Move = above a.Move then Some (Winner b.Player)
                            else Some Draw
        | _ -> None
