# unity-2d-platformer

A 2D platformer game prototype built with Unity and C# during university (2015).

## Gameplay

- Move left/right and jump across tile-based levels
- Avoid patrolling enemies or lose a life
- Collect coins to increase your score
- 3 lives before game over

## Scripts

| Script | Description |
|---|---|
| `PlayerController.cs` | Handles movement, jumping, and ground detection |
| `CameraFollow.cs` | Smooth camera tracking for the player |
| `EnemyPatrol.cs` | Enemy moves back and forth between patrol points |
| `Coin.cs` | Collectible coin that adds to score on pickup |
| `GameManager.cs` | Tracks score and lives, handles game over |
| `UIManager.cs` | Updates score and lives display on screen |

## Tech Stack

- Unity 2D
- C#

## How to Run

1. Open Unity Hub
2. Click **Add project from disk**
3. Select this folder
4. Open the `Scenes/Level1` scene
5. Hit Play

## Notes

This was my first proper game project — built to learn Unity and C#.
Not a complete game, but a working prototype with core mechanics in place.