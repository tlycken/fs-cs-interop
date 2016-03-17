namespace RPS.Scoring
open RPS.Scoring.IO
open RPS.Scoring.Rules

module Gameplay =

    let yesOrNo = ["Y"; "n"]
    let validMoves = ["rock"; "paper"; "scissors"];

    let getMove (p : Player) =
        let input = prompt (sprintf "%s, make a move!" p.Name) validMoves
        match input with
        | "rock" -> Some Rock
        | "paper" -> Some Paper
        | "scissors" -> Some Scissors
        | _ -> None

    let getPlay (p : Player) =
        let m = getMove p
        match m with
        | Some m' -> Some { Player = p; Move = m' }
        | _ -> None

    let getOutcome (m1 : Play option) (m2 : Play option) =
        match (m1, m2) with
        | (Some m1', Some m2') -> Some (outcome m1' m2')
        | _ -> None

    let getMessage (o : Outcome option) =
        match o with
        | Some (Winner w) -> sprintf "%s won this round!" w.Name
        | Some Draw -> "Nobody wins!"
        | None -> "Something went wrong"

    let rec playGame (p1 : Player) (p2 : Player) =
        let m1 = getPlay p1
        let m2 = getPlay p2
        let o = getOutcome m1 m2
        let output = getMessage o

        printfn "%s" output

        let again = prompt "Play again?" yesOrNo

        if (again = "y") then playGame p1 p2