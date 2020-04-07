# Blizzard API for Unity

A general-purpose collection of scripts for using the Blizzard API inside Unity. In short, an API for an API.

The Blizzard API can be used to retrieve informations about most Blizzard games and player profiles (with the proper credentials). For more informations, check out https://develop.battle.net/.

This repo aims to provide tools and shortcuts to use the Blizzard API in your Unity projects.

**WORK IN PROGRESS.**

## Uses and restrictions

As per the MIT license, this is pretty much unrestricted in use and modification.

I'd appreciate a lot if you could mention me somewhere if you use it, though.

## Installation

1. If you don't have one already, go [here](https://develop.battle.net/access/) and create a client. This will give you an unique client ID and client secret.
2. Clone/download the repo and put it in your Unity project's assets.
3. Find the BlizzardAppInfos.cs script, and change the values with your cliend ID and client secret.

Later on I'll add some custom editor tools that need coroutines, so you might want to install Unity's editor coroutines package. you can download it from the package manager, by showing preview packages.

## Removing unused API endpoints

Each category (such as World of Warcraft Profile, World of Warcraft game data, Hearthstone, etc.) is in a separate folder. You're free to remove those folders as long as you don't touch the "\_Common" folder.

## How to use

First off, add those two lines with the other `using`s :

- `using ZeShmouttsAssets.BlizzardAPI;`
- `using ZeShmouttsAssets.BlizzardAPI.JSON;`

Due to how web requests work, everything is made with coroutines : use `StartCoroutine` (from a `MonoBehaviour`) with the corresponding endpoint coroutine (such as `BlizzardAPI_WowGameData.CGetAchievement`).

An example is included in the "\_Example" folder.
