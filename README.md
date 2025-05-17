# The Asylum - First-Person VR Horror Game

"The Asylum" is an immersive first-person VR horror game developed for the Oculus Quest 2 using Unity.

## Table of Contents
1.  [Game Overview](#game-overview)
2.  [Features](#features)
3.  [Gameplay](#gameplay)
4.  [Technical Details](#technical-details)
5.  [Project Iterations](#project-iterations)
6.  [Future Modifications](#possible-future-modifications)
7.  [Controls](#controls)
8.  [Credits](#credits)

## Game Overview
The game is set in a mental asylum at night, where the player's objective is to escape. The environment is designed to be immersive, with multiple floors, numerous rooms, and various interactive elements to enhance the horror experience. The primary goal is to unlock the main door to win the game.

## Features
* **VR Experience**: Designed for Oculus Quest 2, providing a realistic and engaging horror experience.
* **Interactive Environment**:
    * **Doors**: Realistic door interactions, including grabbing handles and opening/closing. Some doors require keys or specific actions (levers, buttons) to unlock.
    * **Weapons**:
        * **Gun**: Players can find and use a gun, pick up bullet boxes to reload, and shoot bullets.
        * **Axe**: A melee weapon that can be used to attack enemies.
    * **Puzzles**: Interact with keys, levers, and buttons to solve puzzles and progress.
* **Enemy AI**:
    * Features an enemy with idle, chasing, and attacking animations.
    * The enemy can detect and pursue the player, dealing damage upon attack.
* **Player Mechanics**:
    * **Health System**: The player has a health level that decreases when attacked by the enemy; reaching zero health results in a "lose" game state.
    * **Movement**: Continuous movement and turning using the VR controller's joystick.
    * **Object Interaction**: Players can grab and interact with various objects in the game world.
* **User Interface**:
    * **Menu System**: Includes a main menu with options to play, view options, and exit.
    * **Options Screen**: Allows adjustment of settings like sensitivity and music volume via sliders.
    * **End Screen**: Displays "You Win" or "You Lose" based on the game outcome.
* **Atmosphere**:
    * Background music to enhance immersion (volume adjustable).

## Gameplay
The player navigates a two-story asylum with many rooms, searching for a way to escape. This involves:
* **Exploration**: Moving through the asylum, opening doors, and discovering new areas.
* **Puzzle Solving**: Finding keys to unlock specific doors, activating levers, or pressing buttons to enable access to new parts of the map. The main objective is to unlock the main exit door.
* **Combat & Evasion**: Encountering an enemy that will chase and attack. The player can use weapons like a gun or an axe to defend themselves or choose to evade the enemy. The enemy also takes damage and can be defeated.
* **Resource Management**: Finding bullet boxes to reload the gun.
* **Winning/Losing**: The player wins by escaping through the main door. The player loses if their health reaches zero.

## Technical Details
* **Game Engine**: Unity
* **Platform**: Oculus Quest 2
* **Primary Programming Language**: C#
* **VR Interaction**: Utilizes the XR Interaction Toolkit for grabbing objects, player movement, and other VR-specific interactions.
* **Key Scripts/Classes Developed**:
    * `Gun`: Manages gun firing, bullet spawning, reloading, and bullet count.
    * `BulletCollision`: Handles bullet collision events.
    * `bulletBox`: Defines the properties of bullet boxes, including the quantity of bullets.
    * `ChangeText`, `bulletBoxText`: Update in-game text displays for bullet counts.
    * `Colliderdamage`: Attached to weapons to define their damage value.
    * `Health` (Player): Manages player health and death state.
    * `Enemy` (or similar for enemy AI): Manages enemy behavior including patrolling, chasing, attacking, and taking damage.
    * `UnlockDoor`, `UnlockDoorLever`, `UnlockDoorButton`: Handle the logic for unlocking doors via keys, levers, or buttons.
    * `checkDistance`: Disables object grabbing if the player moves too far away, preventing glitches (e.g., with doors).
    * `ActivateLever`, `ActivateButton`: Manage the state of levers and buttons.
    * `MenuScreen`, `SensitivityChanger`, `MusicChanger`, `MusicFixer`, `EndText`: Manage UI screen transitions, options adjustments, and end-game text.

## Project Iterations
The game was developed iteratively:
* **First Iteration**: Focused on basic player movement, object grabbing (initially with a cube), initial enemy AI (idle, chasing, attacking), and basic door interaction. Testing identified issues with player collision, headset height, enemy AI bugs, and door glitching when grabbed from afar.
* **Second Iteration**: Implemented gun mechanics (firing, reloading from bullet boxes), axe weapon, player health system, and puzzle elements like keys, levers, and buttons for unlocking doors. Further testing addressed bugs related to enemy targeting, door unlocking logic, and item grab-ability. Player health depletion rate was also adjusted.
* **Third Iteration**: Developed UI screens (menu, options, end screen), implemented sensitivity and music volume controls, and finalized win/lose conditions. Addressed issues with UI state persistence across scenes and player spawn positions on scene changes.

## Possible Future Modifications
Based on the project report, potential future enhancements include:
* **High Score Screen**: Implement a system for players to enter their names and track high scores/completion times.
* **Sound Effects**: Add more detailed sound effects for player actions (walking, running, attacking), enemy movements, and interactions.
* **Bandages/Healing Items**: Introduce items that allow the player to restore health.
* **Inventory System**: Develop an inventory system for the player to store and manage collected items.
* **Expanded Puzzles**: Include more complex puzzles, such as code-operated doors or mini-games.
* **Tutorial Screen**: Add a tutorial to explain game controls, especially for less intuitive actions like grabbing items.
* **Optimization**: Further optimize algorithms for smoother gameplay, particularly for fast-paced interactions like using the axe.
* **Loading Screens**: Implement loading screens for smoother transitions between scenes.
* **Map Expansion & Graphics**: Enlarge the map, add more content, and improve graphical resolution.
* **Advanced Enemy AI**: Utilize pathfinding algorithms like A* for more realistic enemy movement.
* **Cross-Platform Support**: Modify the game to run on other VR headsets beyond Oculus devices.

## Controls
* **Movement**: Left joystick.
* **Turning**: Right joystick (sensitivity adjustable in options).
* **Grab Objects**: Grip button on controllers.
* **Fire Gun**: Trigger button when the gun is equipped and activated.
* **Interact with UI**: Point and trigger/select.

## Credits
* **Game Map Model**: Downloaded from the Unity Asset Store.
* **Background Music**: From Chosic.com (specific track: `https://www.chosic.com/download-audio/25499/`).
* **Developer**: Vaseegaran Vasantharajan.
