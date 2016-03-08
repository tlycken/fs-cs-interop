namespace RPS.Scoring

type Move = 
| Rock
| Paper
| Scissors

type Player = { Name : string }

type Play = {
    Player : Player;
    Move : Move
}

type Outcome = 
| Winner of Player
| Draw
