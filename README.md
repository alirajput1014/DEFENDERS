# DEFENDERS (3D Top-Down Tower Defense Game)

A robust and modular 3D Tower Defense game built in Unity, featuring a classic top-down isometric camera angle inspired by games like *Plants vs. Zombies*. This project implements core tactical defense mechanics, including 3D grid layout management, tile-based unit placement, strategic wave spawning, and unique projectile/attack behaviors for different defensive units.

---
## 🎬 Gameplay Demo

[![Watch Gameplay Demo](https://drive.google.com/thumbnail?id=1rA7eTO2NuR6_yPRoD_nkDuUi1khUkt82&sz=w800)](https://drive.google.com/file/d/1rA7eTO2NuR6_yPRoD_nkDuUi1khUkt82/view?usp=sharing)

> *Click the thumbnail above to watch the full gameplay demo.*

---

## 🚀 Key Features

* **3D Isometric Perspective:** A fixed top-down camera system optimized for full visibility of the battlefield lanes.
* **Dynamic Grid & Slot System:** Automated grid generation that maps specific 3D interaction slots for tactical unit deployment.
* **Click-to-Place Mechanics:** A seamless placement controller that manages resource allocation, unit selection via card buttons, and valid tile deployment.
* **Progressive Wave Management:** A structured wave system that handles enemy scaling, spawn intervals, and level progression logic.
* **Diverse Defensive Units:** Modular unit logic supporting unique attack types (Archers, Wizards, Ninjas, Cyborgs, and specialized traps like Mines or Electric Shocks).
* **Robust Enemy AI & Health Loops:** 3D pathfinding/movement for incoming enemies coupled with localized damage and death handling.

---

## 📂 Project Architecture & Script Breakdown

The codebase is highly organized inside the `Assets/Scripts` folder, separating core management systems from unit and combat logic:

### ⚙️ Core Game Management
* **`GameManager.cs`**: Handles the global state of the game, tracking player lives, resources, score, and core win/loss states.
* **`GridManager.cs`**: Automatically handles the layout generation of the 3D battlefield, creating and structuring coordinate grids.
* **`Slot.cs`**: Represents individual tiles or slots on the grid, tracking whether a slot is occupied or available for unit placement.
* **`PlacementController.cs`**: Detects user inputs, processes card button selections, and deploys 3D units onto valid grid slots.
* **`CardButton.cs`**: UI component managing unit selection cards, costs, and passing the data to the placement system.

### 🛡️ Defensive Units & Traps
* **`Unit.cs`**: The base class for all defensive towers, handling attack ranges, detection loops, and targeting states in 3D space.
* **`Mine.cs`**: Proximity-based explosive trap logic that triggers localized high-damage explosions upon enemy contact.
* **`ElectricShock.cs`**: Continuous or area-of-effect (AoE) energy trap behavior dealing damage to multiple passing enemies.

### 🏹 Projectile System (Unit Combat)
* **`Arrow.cs` / `Blade.cs`**: Base projectile behaviors handling linear physics trajectories and impact logic.
* **`ArcherProjectile.cs`**: Fires projectiles with realistic arcs/trajectories tailored for the 3D top-down viewpoint.
* **`WizardProjectile.cs` / `Fireball.cs`**: Magic-based projectiles managing specialized damage types or splash radius logic.
* **`NinjaProjectile.cs` / `CyborgProjectile.cs`**: High-velocity or mechanized projectiles tailored for rapid-fire or futuristic defender variants.

### 👹 Enemy AI & Waves
* **`WaveManager.cs`**: Manages the spawning logic, configuration of enemy types per wave, and timing delays between enemy groups.
* **`EnemyMove.cs`**: Controls enemy path navigation across the 3D grid rows toward the player's base.
* **`EnemyHealth.cs`**: Manages individual enemy health bars, damage reduction, and score/resource generation upon death.

---

## 🎮 Controls & Gameplay Mechanics

* **Select Unit:** Click on any active Unit Card on the screen's UI overlay.
* **Place Unit:** Hover your mouse over an empty 3D grid slot and **Left-Click (LMB)** to deploy your defender.
* **Start Wave / Fast Forward:** Interact with the Wave UI buttons to summon the incoming horde.

---

## 🛠️ Getting Started

### Prerequisites
* **Unity Editor:** Version 2021.3 LTS or higher recommended.
* **Render Pipeline:** Built-in or Universal Render Pipeline (URP) optimized for 3D game objects.

### Installation & Setup
1. Clone the repository to your local workspace:
   ```bash
   git clone [https://github.com/alirajput1014/DEFENDERS.git](https://github.com/alirajput1014/DEFENDERS.git)
