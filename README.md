# AsteroidsAR: A Classic Arcade Game Reimagined in Augmented Reality
<img src="https://github.com/user-attachments/assets/41829b1e-c963-45bb-b66f-f69584f50c5d" width=50% height=50%>

[AsteroidsAR Demo](https://youtu.be/ygL5PjM235U)

AsteroidsAR is an AR version of the classic arcade game Asteroids, developed as a course project for the Meta AR Developer Certification. This engaging application allows players to defend Earth against incoming asteroids using their phone camera and aiming skills.

## Key Features
- **AR Integration:** Utilizes the phone camera to create an immersive augmented reality experience.
- **Gameplay Mechanics:** Players shoot asteroids before they hit Earth, with large asteroids breaking into smaller ones, increasing the challenge and points.
- **Enemy UFOs:** Occasionally appearing UFOs shoot at the player. Successfully destroying them grants health pickups, weapon upgrades, or both.
- **User Interface:**
  - **_HUD:_** Includes a crosshair for aiming, a health bar for the player and Earth, and screen tints for damage (red), health pickups (green), and weapon upgrades (purple).
  - **_Sound and Particle Effects:_** Enhance the gameplay experience with various sound effects for shooting, explosions, and upgrades, along with visual explosions for asteroid destruction.
   
## Techniques and Coding
- **Scriptable Objects:** Utilized to maintain game state.
- **Coroutines:** Used for handling asynchronous processes without blocking the main game loop.
- **UnityEvents:** Facilitated interaction between different scripts, such as updating the health bar when damaged or when health pickup is received.

## Extra Features 
- **Title Screen:** Added a title screen with simple game instructions and a play button, enhancing the user experience by providing a structured game start.
- **Weapon Upgrade:** Implemented a unique weapon upgrade pickup that generates a straight laser beam from the player, destroying anything in its path for 10 seconds.
- **Screen Tints:** Introduced visual feedback where the screen flashes red on damage, gives a green tint for health pickups, and a purple tint during the weapon upgrade, improving gameplay feedback.

## Assets Used 
- **3D Models:** Provided in the course.
- **Sound Effects:** Sourced from [Arcade SFX Free](https://assetstore.unity.com/packages/audio/sound-fx/arcade-sfx-free-42983) on the Unity Asset Store.
- **Particle Effects:** Sourced from [Hit Impact Effects Free](https://assetstore.unity.com/packages/vfx/particles/hit-impact-effects-free-218385) on the Unity Asset Store.

AsteroidsAR is an immersive AR experiences, integrating advanced coding techniques and enhancing user interaction with thoughtful UI and gameplay elements.

Made in Unity 2021.3.1f1<br />
Tested on Moto Razr+, Android version: 14.
