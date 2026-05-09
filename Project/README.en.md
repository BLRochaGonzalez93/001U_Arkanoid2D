# U001_BrickBreaker_2D

[English](README.en.md) | [Español](README.md)

[2022.1.4f1 in May 2023] migrated to [6000.3.14f1 in May 2026]

## Summary

Playable prototype inspired by Arkanoid, developed in Unity. The project includes a functional one-level demo with custom designs for the bricks, paddle and ball. The core mechanic consists of controlling a horizontal paddle to hit the ball, destroy bricks, score points and avoid losing all lives.

The project includes collision particle systems, scoring, lives-based defeat, progressive ball acceleration over time and bricks with different durability levels represented through colors.

## Technologies

- Unity
- C#
- Unity 2D physics system
- Collider2D / Rigidbody2D
- Particle System
- Basic UI for score and lives
- Scoring system
- Lives system
- Git LFS
- GitHub Releases

## Main features

- Arkanoid-inspired 2D gameplay.
- Horizontal paddle movement controlled by the player.
- Ball with 2D physics and bounces.
- Playable demo composed of one level.
- Custom designs for bricks, paddle and ball.
- Particle system triggered on collisions.
- Scoring system based on brick destruction.
- Lives system and defeat condition.
- Progressive ball acceleration over time.
- Bricks with variable durability according to their color.
- Brick destruction after receiving the required number of hits.
- Playable Windows build.

## Screenshots

![Gameplay](./Media/screenshots/gameplay-01.png)

## Architecture

The main logic is divided into:

- `PlayerController` — player-controlled paddle.
- `BallManager` — ball movement and bounces.
- `BlockManager` — bricks, durability and destruction.
- `BaseManager` — bottom fall detection.
- `AnimControl` — particle systems.
- `GameManager` — global phase, score and game-state control.

## Recommended code to review

[`Project/Assets/Scripts/GameManager.cs`](./Project/PRJ_Arkanoid2D/Assets/Scripts/GameManager.cs)

## Build

The build is available through GitHub Releases.

[`Releases/Download.md`](../Releases/Download.md)

[Download build U001-v1.0.0](https://github.com/BLRochaGonzalez93/U001_BrickBreaker_2D/releases/tag/U001-v1.0.0)

## Status

Playable project. The demo includes one functional level with paddle, ball, destructible bricks, score, lives, defeat condition and collision particle effects.

Possible pending improvements:

- Add a main menu.
- Add a victory screen after completing the level.
- Add more levels.
- Add a pause system.
- Add sound effects for collisions and brick destruction.
- Add background music.
- Add power-ups.
- Improve the ball bounce behavior depending on the impact point on the paddle.
- Add high-score saving.
- Add transitions between levels.
- Improve the balance of the ball acceleration.
- Add extra animations or visual feedback for damaged bricks.

## Learnings

This project allowed me to work on classic 2D gameplay mechanics in Unity, including `Rigidbody2D` physics, collision detection, player control, score management, lives system and defeat logic.

It also helped me practice visual feedback through particle systems, the design of bricks with variable durability and the implementation of progressive difficulty through ball acceleration over time.

In addition, the project helped me better understand how to structure a simple arcade prototype by separating responsibilities between the player paddle, the ball, the bricks, global game systems and visual effects.
