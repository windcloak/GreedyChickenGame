# Greedy Chicken

[Play Greedy Chicken on Unity website](https://play.unity.com/mg/other/webgl-builds-14188)

## Implementation
Greedy Chicken is a 3D game made in Unity. It's based off of [Brackey's how to make a game tutorial](https://www.youtube.com/watch?v=j48LtUkZRjU&list=PLPV2KyIb3jR53Jce9hP7G5xC4O9AgnOuL&index=1), with some modifications
All scripts are written in C# in Visual Studio:
- AudioManager manages all the audio files. It is a list, and it plays the audio with a certain name.
- GameManager manages the transitions betweel levels. It has the methods: CompleteLevel(), EndGame(), and Restart(). It must be present in scenes where the player can transition to another scene, and when displaying the final score. 
- SettingsMenu, PauseMenu, and LevelComplete all have methods that can be called on by the buttons in those menus
- Coin has methods for when the Player gets it. OnTriggerEnter() method fires when the Player collides with it, and it calls the GetCoin() method, which is has the score increase, eaten effect (sparkly effect when Player gets a coin), and destroy game object.
- Strawberry is almost the same as Coin, but with a different eatenEffect and points
- Bomb and Fox is almost the same as Coin, except it has onCollisionEnter() instead because I want the Player to physically hit it 

## Screenshots
![Intro Menu](https://github.com/windcloak/GreedyChickenGame/blob/main/screenshots/Screenshot_1.jpg)
https://github.com/windcloak/GreedyChickenGame/blob/main/screenshots/Screenshot_2.jpg
https://github.com/windcloak/GreedyChickenGame/blob/main/screenshots/Screenshot_3.jpg
https://github.com/windcloak/GreedyChickenGame/blob/main/screenshots/Screenshot_4.jpg
https://github.com/windcloak/GreedyChickenGame/blob/main/screenshots/Screenshot_5.jpg
https://github.com/windcloak/GreedyChickenGame/blob/main/screenshots/Screenshot_5.jpg
https://github.com/windcloak/GreedyChickenGame/blob/main/screenshots/Screenshot_6.jpg
https://github.com/windcloak/GreedyChickenGame/blob/main/screenshots/Screenshot_7.jpg
https://github.com/windcloak/GreedyChickenGame/blob/main/screenshots/Screenshot_8.jpg
https://github.com/windcloak/GreedyChickenGame/blob/main/screenshots/Screenshot_9.jpg
https://github.com/windcloak/GreedyChickenGame/blob/main/screenshots/Screenshot_10.jpg

## Assets Used
- https://assetstore.unity.com/packages/3d/characters/3d-monster-bomb-145319
- https://assetstore.unity.com/packages/3d/characters/animals/toon-fox-183005
- https://assetstore.unity.com/packages/audio/sound-fx/sound-fx-retro-pack-121743
- https://assetstore.unity.com/packages/3d/props/food/low-poly-fruit-pickups-98135
- https://assetstore.unity.com/packages/3d/props/food/allsorts-candy-12512
- https://assetstore.unity.com/packages/vfx/particles/spells/52-special-effects-pack-10419
- https://assetstore.unity.com/packages/audio/music/free-music-tracks-for-games-156413
- https://assetstore.unity.com/packages/3d/characters/animals/meshtint-free-chicken-mega-toon-series-151842
- https://assetstore.unity.com/packages/2d/textures-materials/sky/fantasy-skybox-free-18353
