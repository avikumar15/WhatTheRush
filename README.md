# Car Racing Game 

"What The Rush" is a car racing game which can be played in two modes - "Practice Mode" and "Race Mode".

## Features

The practice mode consists of a single car running around a track with multiple ramps and a broken bridge for 3 laps. Whenever the player jumps over a threshold height, gameplay goes in slow-motion and jump height is shown. There is a lap timer running on the screen, which restarts when another lap is over. The best time in the current game is displayed under "Best Lap" and user's best time from all his best time is stored under Stats by implementation of PlayerPrefs (which is quite similar to SharedPreferences in android studio). 

The track is fenced on one side and the other side is open. Once the car falls down in the river, player is wasted and game ends. Also random obstacles of random heights are generated in the game (obstacle generation is based on randomly activating obstacles out of the total obstacles already on the track).

I have also added feature of cheat code in practice mode. So, when you press "whatthefuss" more obstacles pop up in the game. Also Nitro is added in the practice mode, so when you press N, Nitro is boosted.

Coming to the racing mode, I have set up an AI car, which goes as per a path set up by checkpoints. A dummy marker is used here which initially points to the first checkpoint, as and when AI car reaches, it points to the next one.

Pause menu is added in both the modes, and, whenever game ends, best lap time is shown on the screen.

Coming to the part of libraries used, I used a "Standard Assets" library, from where I used only "Player Car", "AI car" and "Trees" for the environment. Player Car came with standard arrow key navigation to which WASD was added by me while the AI car came with no controls. I had to assign a marker to the AI car, which AI car followed, and in the run time I moved the marker so the AI car continued moving.

In addition to all the coding part for above features, I had to set up the terrain, the track, jumping area, river body, sand, trees, etc.

## 

The actual build file that is the game is available under Game/ directory.

## Future plans -
- To have a day and night track separately.

- More cheat codes.

- Efficient implementation of nitros.

- More AI Car

- Give user an option of more cars to select from, with different physics in all car. Also if possible set up garage store, where user can buy from points he gain while racing.

- Set up a leaderboard for people playing across the world.

- And anything else that seems feasible.

