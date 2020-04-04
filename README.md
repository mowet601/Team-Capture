![Logo](tc-logo.png)

# Team Capture

Team Capture is a multiplayer first person shooter game inspired by [Quake](https://store.steampowered.com/app/2310/QUAKE/), [Half-Life 2: Deathmatch](https://store.steampowered.com/app/320/HalfLife_2_Deathmatch/), [Team Fortress 2](http://www.teamfortress.com/) and a tf2 mod called [Open Fortress](https://www.openfortress.fun/) (yes, very [Quake engine family](https://commons.wikimedia.org/wiki/File:Quake_-_family_tree.svg) based games).

Team Capture is still in very early development and is developed by a very small team!

Team Capture is built using the [Unity game engine](https://unity.com/) with [our fork](https://github.com/Creepysin-Studios/TC-Mirror) of the [Mirror](https://mirror-networking.com/) networking system.

## Features

Please remember that this project is still in early development!

- In-Game Console

    - With commands!

- Working weapon shooting

- Working pickups (Weapons/Health)

- BHopping

- Per scene Discord RPC

- Dynamic Settings UI

- Settings save system

## The Team

Here is everyone who is currently working on the project:

* [Voltstro](https://github.com/Voltstro) - *Project Lead*

    - [Email](mailto:me@voltstro.dev) - [Website](https://voltstro.dev)

* [EternalClickbait](https://github.com/EternalClickbait) - *Programmer*

If you think you can help out the team, please don't hesitate to email me (project lead)

## Getting the project

We currently don't offer any prebuilt builds of the project yet.

You will need to build the project yourself to play!

### Prerequisites

```
Unity 2019.3.3f1
Blender
```

### Pre Setup

Since within the assets of our game we use straight raw Blender files, you will needed to have downloaded and installed [Blender](https://www.blender.org/), and to make sure `.blend` files are associated with the Blender program.

### Setup

Once you have Blender ready:

1. Fork and clone the project

2. Open the project up in Unity

* When opening the project for the first time, it can take awhile to open!

3. There seems to be an issue with Blender model's default material not working, re-import the models folder if you are having this issue

### Testing the project

While working on the project, when you go to test your scene or code, remember to start from either the `MainMenu` scene, or from the `Bootstrapper` scene if you want an in-game console.

# Q & A

**Q:** When will this project be finished?

**A:** We don't know, it will be a long time, and the team only consists
 of students currently.

---

**Q:** Will this game be free when it comes out?

**A:** Yes! This game and its source code will be completely free when it comes out.

---

**Q:** Why did you use the Unity game engine? Why not engine *x*?

**A:** We used the Unity game engine because it is C#, and the two members of the team are most familiar with C# and Unity.

---

**Q:** I can't program or make assets, is there any other way I can support the project?

**A:** If you want to support the project, and you can't make assets, then you can help by sharing the project. Tell your friends, family or hell, even your dog about the project, and it can massively help us!

# Special Thanks

- [Mirror](https://mirror-networking.com/)

- [Discord RPC CSharp](https://github.com/Lachee/discord-rpc-csharp)

- [Newtonsoft.Json](https://www.newtonsoft.com/json)

- Friends, family, and students at school for suggestions, ideas and bug hunting.
