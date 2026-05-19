# 🎮 TileVenia
This is an adventure 2D platformer game made with Unity.
<img width="938" height="452" alt="Tilevenia" src="https://github.com/user-attachments/assets/b0236aed-9d97-408f-8301-d6407c9732cd" />

---

## 🛠️ Technical details
* **Animator** -> All character states are animated frame-by-frame using Unity's Animator controller (states include: idle, walking, climbing, jumping, and death).
* **Tile Palette** -> Environment sprites and level layouts were managed and organized efficiently using Unity's Tile Palette tool.
* **Enemy AI** -> The enemy moves forward until it collides with a wall, then reverses its direction automatically. If the player and an enemy collide, the player dies.
* **Climbing system** -> When the player collides with a ladder, they snap to its vertical axis, allowing them to climb up or down using the W / UP arrow keys.
* **Movement system** -> Control mechanics are built via Unity's Input System: A/D or LEFT/RIGHT arrow keys for walking, W/UP arrow key for climbing ladders, and SPACE to jump.
* **Traps** -> Hazardous hazards like spikes trigger an instant player death upon collision.
* **Bouncing mechanics** -> Stepping on a mushroom launcher temporarily multiplies your base jump force by a factor of 1.2 for that bounce, without altering the player's permanent jump attributes.
* ⚠️ *Note: I do not own the art/UI assets used in this project.*

---

## 📷 Screenshots
<p align = "center">
  <img width="1527" height="727" alt="Screenshot 2026-05-12 152411" src="https://github.com/user-attachments/assets/3484aed0-58cb-4a60-ac47-e68183eebb24"    />
  <img width="1527" height="726" alt="Screenshot 2026-05-12 152435" src="https://github.com/user-attachments/assets/cfa9596d-c82e-493d-b94e-76513d2ecfc8"    />
  <img width="1528" height="727" alt="Screenshot 2026-05-12 152511" src="https://github.com/user-attachments/assets/5d067bb6-dcde-4e3b-bdbe-7a1af9a4ba03"    />
  <img width="1528" height="720" alt="Screenshot 2026-05-12 152528" src="https://github.com/user-attachments/assets/12f3630b-398e-45d2-9b4d-1d097ea8074b"    />
  <img width="1527" height="726" alt="Screenshot 2026-05-12 152537" src="https://github.com/user-attachments/assets/26aaeca8-4fe6-4d1e-b062-fa4c2e4ae554"    />
</p>

---

## 🚀 How to open the project
1. Clone the repository.
2. Open in Unity 2021.3.25f1.
3. Press the Run button.
