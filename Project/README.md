# U001_BrickBreaker_2D

[English](README.en.md) | [Español](README.md)

[2022.1.4f1 en mayo de 2023] adaptación a [6000.3.14f1 en mayo de 2026]

## Resumen

Prototipo jugable inspirado en Arkanoid desarrollado en Unity. El proyecto incluye una demo funcional de un nivel, con diseños propios para los ladrillos, la barra y la pelota. La mecánica principal consiste en controlar una barra horizontal para golpear la pelota, destruir ladrillos, conseguir puntuación y evitar perder todas las vidas.

El proyecto incorpora sistemas de partículas en las colisiones, puntuación, derrota por vidas, aceleración progresiva de la pelota con el paso del tiempo y ladrillos con diferentes niveles de durabilidad representados por colores.

## Tecnologías

- Unity
- C#
- Sistema de físicas 2D de Unity
- Collider2D / Rigidbody2D
- Particle System
- UI básica para puntuación y vidas
- Sistema de puntuación
- Sistema de vidas
- Git LFS
- GitHub Releases

## Características principales

- Gameplay inspirado en Arkanoid 2D.
- Movimiento horizontal de la barra controlada por el jugador.
- Pelota con físicas 2D y rebotes.
- Demo jugable compuesta por un nivel.
- Diseños propios para ladrillos, barra y pelota.
- Sistema de partículas al producirse colisiones.
- Sistema de puntuación por destrucción de ladrillos.
- Sistema de vidas y condición de derrota.
- Aceleración progresiva de la pelota con el paso del tiempo.
- Ladrillos con durabilidad variable según su color.
- Destrucción de ladrillos tras recibir el número necesario de impactos.
- Build jugable para Windows.

## Capturas

![Gameplay](../Media/screenshots/gameplay-01.png)

## Arquitectura

La lógica principal se divide en:

- `PlayerController` — barra controlada por el jugador.
- `BallManager` — pelota, movimiento y rebotes.
- `BlockManager` — ladrillos, durabilidad y destrucción.
- `BaseManager` — detección de caída al fondo.
- `AnimControl` — sistemas de partículas.
- `GameManager` — control global de fase, puntuación y estado de partida.

## Código recomendado para revisar

[`PRJ_Arkanoid2D/Assets/Scripts/GameManager.cs`](./PRJ_Arkanoid2D/Assets/Scripts/GameManager.cs)

## Build

La build está disponible en GitHub Releases.

[`Releases/Download.md`](../Releases/Download.md)

[Descargar build U001-v1.0.0](https://github.com/BLRochaGonzalez93/U001_BrickBreaker_2D/releases/tag/U001-v1.0.0)

## Estado

Proyecto jugable. La demo incluye un nivel funcional con barra, pelota, ladrillos destruibles, puntuación, vidas, derrota y efectos de partículas en las colisiones.

Pendiente de posibles mejoras:

- Añadir menú principal.
- Añadir pantalla de victoria al completar el nivel.
- Añadir más niveles.
- Añadir sistema de pausa.
- Añadir efectos de sonido para colisiones y destrucción de ladrillos.
- Añadir música de fondo.
- Añadir power-ups.
- Mejorar el comportamiento de rebote de la pelota según el punto de impacto en la barra.
- Añadir guardado de puntuación máxima.
- Añadir transición entre niveles.
- Mejorar el balance de aceleración de la pelota.
- Añadir animaciones o feedback visual adicional en los ladrillos dañados.

## Aprendizajes

Este proyecto me permitió trabajar mecánicas clásicas de gameplay 2D en Unity, incluyendo físicas con `Rigidbody2D`, detección de colisiones, control del jugador, gestión de puntuación, sistema de vidas y lógica de derrota.

También me sirvió para practicar la creación de feedback visual mediante sistemas de partículas, el diseño de ladrillos con durabilidad variable y la implementación de una dificultad progresiva mediante aceleración de la pelota con el paso del tiempo.

Además, el proyecto me ayudó a entender mejor cómo estructurar un prototipo arcade sencillo separando responsabilidades entre la barra del jugador, la pelota, los ladrillos, los sistemas globales de partida y los efectos visuales.
