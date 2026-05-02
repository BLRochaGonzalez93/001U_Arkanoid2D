# 001_Unity_Basic_Collision_Hunter

[2022.1.4f1 en Octubre 2022] adaptacion a [6000.3.14f1 en Mayo 2026]

## Resumen

Prototipo de controlador en tercera persona desarrollado en Unity. Incluye movimiento relativo a camara, salto, gravedad personalizada, animacion es basicas e integracion con el sistema de input.

## Tecnologias

- Unity
- C#
- Unity Input System
- Animator
- Git LFS
- GitHub Releases

## Caracteristicas principales

- Movimiento en tercera persona.
- Camara orbital.
- Salto y gravedad.
- Animaciones basicas.
- Separacion entre input, movimiento y animacion.
- Build jugable para Windows.

## Capturas

![Gameplay](./Media/screenshots/gameplay-01.png)

## Arquitectura

La logica principal se divide en:  
- `PlayerInputReader`
- `ThirdPersonMotor`
- `CameraController`
- `PlayerAnimationController`
Mas informacion en:  
`Docs/Architecture.md`

## Codigo recomendado para revisar

`Project/Assets/Scripts/Player/ThirdPersonMotor.cs`
`Project/Assets/Scripts/Player/PlayerInputReader.cs`
`Project/Assets/Scripts/Camera/CameraController.cs`

## Build

La build esta disponible en GitHub Releases.  
`Releases/Download.md`

## Estado

Proyecto jugable. Pendiente de mejoras en camara, pulido de animaciones y sistema de lock-on.

## Aprendizajes

Este proyecto me permitio trabajar la separacion de responsabilidades entre input, movimiento, camara y animacion.