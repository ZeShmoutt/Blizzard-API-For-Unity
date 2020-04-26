# Blizzard API for Unity

A general-purpose collection of scripts for using the Blizzard API inside Unity. In short, an API for an API.

The Blizzard API can be used to retrieve informations about most Blizzard games and player profiles (with the proper credentials). For more informations, check out https://develop.battle.net/.

This repo aims to provide tools and shortcuts to use the Blizzard API in your Unity projects.

**WORK IN PROGRESS.**

## Uses and restrictions

As per the MIT license, this is pretty much unrestricted in use and modification.

I'd appreciate a lot if you could mention me somewhere if you use it, though.

## Installation

1. If you don't have one already, follow [this link](https://develop.battle.net/access/), register or login, and create a client. This will give you an unique client ID and client secret.
2. Install the package :
 - Unity 2019 or newer : Open the Package manager, select  and import the package with the git URL.
 - Unity 2018 or older : Clone/download the repo and put it in your Unity project's assets.
3. Go to the Project Settings, section "Blizzard App Infos", and change the values with your cliend ID and client secret.

Note that this package requires Unity's Editor Coroutines package. You can download it from the Package Manager.

## How to use

First off, add those two lines with the other `using`s :

- `using ZeShmouttsAssets.BlizzardAPI;`
- `using ZeShmouttsAssets.BlizzardAPI.JSON;`

Then, use `StartCoroutine()` (from a `MonoBehaviour`) with the corresponding endpoint coroutine (such as `BlizzardAPI.WowGameData.GetAchievement()`) to retrieve your data.

An example is included in the "\_Example" folder.

## Useful links

For this package :
 - [License](https://github.com/ZeShmoutt/Blizzard-API-For-Unity/blob/master/.github/LICENSE)
 - [Changelog](https://github.com/ZeShmoutt/Blizzard-API-For-Unity/blob/master/.github/CHANGELOG.md)

For Blizzard's API :
 - [Front page](https://develop.battle.net/)
 - [Documentation](https://develop.battle.net/documentation)