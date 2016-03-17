namespace RPS.Scoring.Tests

open RPS.Scoring
open RPS.Scoring.Rules
open FsCheck
open FsCheck.Xunit
open Swensen.Unquote

module RuleTests =

    [<Property>]
    let ``When the two players make the same move, I expect draw``
        (p0 : Play) (p1 : Play)=

        let p2 = { p0 with Move = p1.Move }

        let actual = outcome p1 p2

        actual =! Draw

    [<Property>]
    let ``When player one makes the better move, I expect player one to win``
        (p0 : Play) (p1 : Play) =

        let p2 = { p0 with Move = below p1.Move }

        let actual = outcome p1 p2

        actual =! Winner p1.Player

    [<Property>]
    let ``When player two makes the better move, I expect player two to win``
        (p0 : Play) (p1 : Play) =

        let p2 = { p0 with Move = above p1.Move }

        let actual = outcome p1 p2

        actual =! Winner p2.Player

