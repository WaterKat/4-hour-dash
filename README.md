# 4-Hour Dash

A Geometry Dash-style auto-runner built in about four hours for a game jam in October 2019.

The player runs right at constant speed and jumps with the space bar. Enemies and pillars deal damage, health pickups restore it, and the scene reloads shortly after death. The score is the number of seconds survived.

## Status

Archived. This is a snapshot of a jam project and is not maintained.

## Opening the project

- Unity version: 2018.4.8f1 (see `4HourDash/ProjectSettings/ProjectVersion.txt`)
- Open the `4HourDash` folder as a Unity project.
- Newer Unity versions will prompt an upgrade, and some APIs used here (such as `Rigidbody2D.velocity`) are deprecated in recent releases.
- The game is in `Assets/Scenes/SampleScene.unity`, the only scene in the build settings.

## Layout

- `4HourDash/Assets/WaterKat/` - player, enemy, pickup and environment scripts and prefabs
- `4HourDash/Assets/Scenes/SampleScene.unity` - the game scene
- `4HourDash/Assets/Animator/` - player animator and clips
