# 🎮 TileVenia
This is an adventure 2D platformer game made with unity.
<img width="938" height="452" alt="Tilevenia" src="https://github.com/user-attachments/assets/b0236aed-9d97-408f-8301-d6407c9732cd" />

## 🛠️ Technical details
* **Animator** -> all the states of the caracters are animated frame by frame using Uinty's animator (states: idle, walking, climbing, jumping, death)
* **Tile Pallete** -> the assets were menged and organized by using the Unity's Tile Pallete
* **Enemy** -> the enemy is walking forward until it collides with a wall, and then it starts walking in the oposite direction, until it hits another wall again (if the player and the enemy collide, the player dies)
* **Climbing system** -> when the player collides with a ledder, he gets stick to it (on the y axis) and if you press the UP/W button, you can climb on the ledder
* **Movement system** -> the movement is made by using Unity's input system (AS/(LEFT, RIGHT) for walking, W/UP for climbing on the ledder, SPACE to jump)
* **Traps** -> there are spikes that kill you if you collide with them
* **Other objects** -> there is a mushroom that you can jump on, and it increases your jump power with 1.2 every time you bounce on it (the original jump power doesn't change)
* !! I don't own the assets.

## 📷 Screenshots
<img width="1527" height="727" alt="Screenshot 2026-05-12 152411" src="https://github.com/user-attachments/assets/3484aed0-58cb-4a60-ac47-e68183eebb24" />
<img width="1527" height="726" alt="Screenshot 2026-05-12 152435" src="https://github.com/user-attachments/assets/cfa9596d-c82e-493d-b94e-76513d2ecfc8" />
<img width="1528" height="727" alt="Screenshot 2026-05-12 152511" src="https://github.com/user-attachments/assets/5d067bb6-dcde-4e3b-bdbe-7a1af9a4ba03" />
<img width="1528" height="720" alt="Screenshot 2026-05-12 152528" src="https://github.com/user-attachments/assets/12f3630b-398e-45d2-9b4d-1d097ea8074b" />
<img width="1527" height="726" alt="Screenshot 2026-05-12 152537" src="https://github.com/user-attachments/assets/26aaeca8-4fe6-4d1e-b062-fa4c2e4ae554" />

## 🚀 How to open the project
1. Clone the repository;
2. Open in unity 2021.3.25f1;
3. Press the run button.
