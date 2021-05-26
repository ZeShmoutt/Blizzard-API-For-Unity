# Changelog
All notable changes to this package will be documented in this file.

The format is based on [Keep a Changelog](http://keepachangelog.com/en/1.0.0/), and this project *somewhat* adheres to [Semantic Versioning](http://semver.org/spec/v2.0.0.html).

## [1.13.2] - 2021-05-26
### Unity version
 - Updated project to Unity 2020.2.2f1

## [1.13.1] - 2021-03-15
### Bug fix
 - Added the missing script files for Hearthstone spell schools metadata

## [1.13.0] - 2021-03-15
### Added
 - Added spell school support for Hearthstone card search

## [1.12.0] - 2020-10-17
### API Update
 - Updated the API according to Blizzard's changelog :
   - [API Changes - WoW Shadowlands Pre-Patch](https://us.forums.blizzard.com/en/blizzard/t/api-changes-wow-shadowlands-pre-patch/11826)

## [1.11.1] - 2020-10-12
### Bug fix
 - Fixed `action_onError` actually not working

## [1.11.0] - 2020-10-10
### Added
 - Added `action_onError` to all endpoints
  - This action will be triggered if the request returns an error

### Changed
 - Removed hard dependancies from the package
  - This means that the Unity Editor Coroutines package is no longer required, but it can still be added to enable additional tools
 - Internal naming changes for consistency

### Bug fix
 - Separated the editor scripts into their own assembly to avoid compilation bugs

## [1.10.1] - 2020-07-10
### API update
 - Updated TODO.md according to Blizzard's changelog :
   - [World of Warcraft API Patch Notes - 2020/07/08](https://us.forums.blizzard.com/en/blizzard/t/world-of-warcraft-api-patch-notes-20200708/10310)

## [1.10.0] - 2020-06-10
### Added
 - Added support for the new endpoints in the WoW Game Data / Pet category (cf [\[1.7.1\]](#171---2020-06-09)) :
   - Pet Media
   - Pet Abilities Index
   - Pet Ability
   - Pet Ability Media

## [1.9.0] - 2020-06-10
### Added
 - Added support for the following WoW Classic Game Data endpoint categories :
   - Connected Realm
     - Except `Connected Realms Search`
   - Realm
     - Except `Realm Search`
   - Region

## [1.8.0] - 2020-06-09
### Added
 - Added support for the following Diablo III Game Data endpoint category :
   - Season & Era

### Changed
 - StarCraft II endpoint files are now automatically generated from a CSV
   - Moved the related enum into their own files to avoid problems with that
 - Slightly changed how WowProfile files are generated, especially the summary formatting
 - Moved the `Editor` folder inside the `_Core` folder

## [1.7.1] - 2020-06-09
### API update
 - Updated TODO.md according to Blizzard's changelog :
   - [World of Warcraft API Patch Notes - 2020/06/09](https://us.forums.blizzard.com/en/blizzard/t/world-of-warcraft-api-patch-notes-20200609/8902)

## [1.7.0] - 2020-06-08
### Added
 - Added support for the following StarCraft II Game Data endpoint category :
   - League

### Removed
 - Removed the `HttpUtility` class, now that it isn't needed anymore (cf : [\[1.3.0\]](#130---2020-06-07))

### Bug fixes
 - Fixed the very slightly longer length of the `action` enum popups in the API Testing Tool
 - Added support for enums in the API Testing Tool

## [1.6.0] - 2020-06-08
### Added
 - Added support for the following Hearthstone Game Data endpoint category :
   - Decks

## [1.5.0] - 2020-06-08
### Added
 - Added support for the following Hearthstone Game Data endpoint category :
   - Card Backs

### Changed
 - Slightly changed the Hearthstone card search parameters to use a new, auto-generated list of values

### Bug fixes
 - Fixed an incorrect summary in `FetchOneCard`
 - Fixed a bug where the API Testing Tool would blank out and throw errors after a recompile

## [1.4.0] - 2020-06-08
### Added
 - Added support for the following WoW Classic Game Data endpoint category :
   - WoW Token
     - Note : for WoW Classic, the Token is only available in China

## [1.3.0] - 2020-06-07
### Added
 - Added support for the following Hearthstone Game Data endpoint category :
   - Cards

### Changed
 - Added special support for Hearthstone card searchs in the testing window
 - Custom requests by URL no longer attempt to find a namespace in the request parameters
   - Use the `additionalHeaders` parameter instead, with the key "Battlenet-Namespace"

## [1.2.1] - 2020-06-07
### Changed
 - Hearthstone Metadata endpoint files are now automatically generated from a CSV
   - This also fixed incorrect API paths with most metadata

## [1.2.0] - 2020-06-05
### Added
 - Added support for the following Hearthstone Game Data endpoint category :
   - Metadata
 - Added support for additional languages in the `LocalizedString` struct :
   - Japanese : `ja_JP`
   - Polish : `pl_PL`
   - Thai : `th_TH`

## [1.1.0] - 2020-05-29
### Added
 - Added support for the following WoW Classic Game Data endpoint categories :
   - Creature
   - Guild Crest
   - Item
   - Playable Class
   - Playable Race
   - Power Type

## [1.0.6] - 2020-05-27
### Added
 - Added the missing fields `alliance_crafted_item` and `horde_crafted_item` for the WoW Recipe JSON

## [1.0.5] - 2020-05-20
### Added
 - Added the new field `crafted_quantity` for the WoW Recipe JSON

## [1.0.4] - 2020-05-16
### Added
 - Added the missing fields `minimum_skill_level` and `maximum_skill_level` for the WoW Profession JSON (only used by Archaeology, the last profession that doesn't use skill tiers)

## [1.0.3] - 2020-05-09
### Bug fix
 - Fixed the `BlizzardAppInfos` ScriptableObject not being properly created when opening the project settings

## [1.0.2] - 2020-05-09
### Bug fix
 - Fixed a bug with `#if UNITY_EDITOR` not working in packages

## [1.0.1] - 2020-05-09
### Bug fix
 - Fixed a very annoying error with .NET 4.0 and `System.Web`

## [1.0.0] - 2020-05-09
### Unity version
 - Updated to Unity 2019.3.10f1
   - Still compatible with older versions, but some features may be disabled

### Added
 - Added an editor-only window to test any endpoint directly in-editor (menu : `Blizzard API/API Testing tool`)
   - Can also save JSON in a folder directly
   - Requires `EditorCoroutines` package and Unity 2019
 - Added an editor-only window to quickly retrieve an OAuth access token (menu : `Blizzard API/Get Access Token`)
   - This is mostly useful in Blizzard's documentation, by providing an access token to test endpoints
   - Requires `EditorCoroutines` package and Unity 2019
 - Added "raw" version of all current endpoints, that apply their actions to the JSON string without converting it

### Changed
 - Endpoint files are now automatically generated from a CSV
   - Summary consistency is now at its highest peak
 - Updated README.md
  
## [0.49.0] - 2020-05-02
### Added
 - Added `BlizzardAPI.CustomRequest<T>()`, allowing custom API requests using URLs found in data provided by other requests (e.g. indexes)
 - Added "raw" versions of `BlizzardAPI.SendRequest()` and `BlizzardAPI.CustomRequest()` that apply their actions to the JSON string without converting it

### Changed
 - Fixed a typo in `WowAchievementCategoriesIndex_JSON`
  
## [0.48.0] - 2020-05-02
### Added
 - Added support for the following WoW Profile endpoint category :
   - Guild
  
## [0.47.0] - 2020-05-02
### Added
 - Added support for the following WoW Profile endpoint category :
   - Character Titles
  
## [0.46.0] - 2020-05-02
### Added
 - Added support for the following WoW Profile endpoint category :
   - Character Statistics
  
## [0.45.0] - 2020-05-02
### Added
 - Added support for the following WoW Profile endpoint category :
   - Character Specializations
  
## [0.44.0] - 2020-05-01
### Added
 - Added support for the following WoW Profile endpoint category :
   - Character Reputations
  
## [0.43.0] - 2020-05-01
### Added
 - Added support for the following WoW Profile endpoint category :
   - Character PvP
  
## [0.42.0] - 2020-05-01
### Added
 - Added support for the following WoW Profile endpoint :
   - Character Profile/Character Profile Status
  
## [0.41.0] - 2020-05-01
### Added
 - Added support for the following WoW Profile endpoint category :
   - Character Mythic Keystone Profile
  
## [0.40.0] - 2020-05-01
### Added
 - Added support for the following WoW Profile endpoint category :
   - Character Hunter Pets
  
## [0.39.0] - 2020-05-01
### Added
 - Added support for the following WoW Profile endpoint category :
   - Character Equipment
  
## [0.38.0] - 2020-04-30
### Added
 - Added support for the following WoW Profile endpoint category :
   - Character Encounters
  
## [0.37.0] - 2020-04-30
### Added
 - Added support for the following WoW Profile endpoint category :
   - Character Collections
  
## [0.36.0] - 2020-04-30
### Added
 - Added support for the following WoW Profile endpoint category :
   - Character Appearance
  
## [0.35.0] - 2020-04-28
### Added
 - Added support for the following WoW Profile endpoint category :
   - Character Achievements
  
## [0.34.0] - 2020-04-28
### Added
 - Added support for the following WoW Game Data endpoint categories :
   - Title
   - WoW Token
  
## [0.33.0] - 2020-04-28
### Added
 - Added support for the following WoW Game Data endpoint category :
   - Talent
  
## [0.32.0] - 2020-04-28
### Added
 - Added support for the following WoW Game Data endpoint categories :
   - Region
   - Reputations
  
## [0.31.0] - 2020-04-27
### Added
 - Added support for the following WoW Game Data endpoint categories :
   - PvP Tier
   - Quest
  
## [0.30.0] - 2020-04-27
### Added
 - Added support for the following WoW Game Data endpoint categories :
   - Power Type
   - PvP Season
 - Added an override for `ToString()` for any JSON-based class that will simply return the whole class in a JSON string

### Bug fix
 - Added a version check on the BlizzardAppInfos to remove the "Experimental" in a namespace for Unity 2019 and newer
 - Changed the file path variables to fit `Resources.Load()` parameters usage
  
## [0.29.0] - 2020-04-26
### Added
 - Added support for the following WoW Game Data endpoint category :
   - Playable Specializations
  
## [0.28.0] - 2020-04-26
### Added
 - Added support for the following WoW Game Data endpoint category :
   - Pets
  
## [0.27.0] - 2020-04-26
### Added
 - Added support for the following WoW Game Data endpoint category :
   - Mythic Raid Leaderboard

### Changed
 - Changed the region parameter to mandatory for the Mythic Keystone Leaderboard endpoint
  
## [0.26.0] - 2020-04-26
### Added
 - Added support for the following WoW Game Data endpoint category :
   - Mythic Keystone Leaderboard

### Bug fix
 - Fixed some incorrect namespaces in the Mythic Keystone Dungeon endpoint
 - Fixed some incorrect formatting in the changelog
  
## [0.25.0] - 2020-04-26
### Added
 - Added support for the following WoW Game Data endpoint categories :
   - Mythic Keystone Affix
   - Mythic Keystone Dungeon

### Changed
 - Updated README.md

## [0.24.0] - 2020-04-26
### Added
 - Finally made a decent changelog
 - Added a quick access to the Blizzard API project settings (menu : `Blizzard API/Settings...`)

### Changed
 - Fixed the package version to the actual version number instead of the amount of commits

## [0.23.0] - 2020-04-26
### Changed
 - Better way of saving the Blizzard client ID and client secret using a ScriptableObject
 - Updated README.md

## [0.22.0] - 2020-04-25
### Added
 - Added support for Unity's Package Manager
   - The package can now be imported directly with the git URL

## [0.21.0] - 2020-04-24
### Added
 - Added support for the following WoW Game Data endpoint category :
   - Mounts

## [0.20.0] - 2020-04-24
### Added
 - Added support for the following WoW Game Data endpoint category :
   - Journal

### Bug fix
 - Fixed some typos

## [0.19.0] - 2020-04-23
### Changed
 - Made the region parameter optional for access tokens

## [0.18.0] - 2020-04-23
### Added
 - Added an optional "Last Modified Since" parameter (HTML-formatted date as a string) to all endpoints, that can be used to pretty much ignore the request if the server data is older

## [0.17.0] - 2020-04-23
### Changed
 - Separated some of the core stuff into different files to make it more convenient to modify

## [0.16.0] - 2020-04-21
### Changed
 - Major refactoring 2 : electric boogaloo
   - Endpoints are now self-contained in their own files
   - Any filde outside of the \_Common folder can be removed without repercussions
   - Updated the example to show how to use the `LastModified` action

## [0.15.0] - 2020-04-20
### Changed
 - Major refactoring to make it easier to use :
   - All endpoints are accessible from the `BlizzardAPI` class (as in, "I discovered the 'partial' keyword")
   - Another pass on the summaries
   - Web requests now use headers instead of cramming everything in the URL
   - Added an optional `Is-Modified-Since` header in the web request
   - Added an optional action in the web request that will be executed with the `Last-Modified` response header

## [0.14.0] - 2020-04-18
### Changed
 - Name correction for `CGetCharacterMediaSummary()`

## [0.13.0] - 2020-04-17
### Changed
 - Reorganized the files and folders

## [0.12.0] - 2020-04-16
### Changed
 - Added more common JSON structures th the base file

## [0.11.0] - 2020-04-16
### Added
 - Added support for the following WoW Game Data endpoint category :
   - Professions
 - Added support for the following WoW Profile endpoint categories :
   - Character Medias
   - Character Professions
   - Character Quests

### Bug fix
- Cleaned the summaries for formatting and consistency

## [0.10.0] - 2020-04-16
### Changed
 - Small changes to URL concatenation

## [0.9.0] - 2020-04-16
### Added
 - Added support for the following WoW Game Data endpoint category :
   - Spells

## [0.8.0] - 2020-04-16
### Changed
 - Small consistency change about lowercase/uppercase

## [0.7.0] - 2020-04-13
### Changed
 - Cleaned and slightly changed the access token saving/loading

## [0.6.0] - 2020-04-13
### Changed
 - Added support for the following WoW Game Data endpoint categories :
   - Guild Crests
   - Items
   - Playable Classes

### Changed
 - Changed the Region to an optional parameter for WoW Game Data endpoints (defaults to "en_US")

### Bug fix
 - Slightly changed the summary for parameters to match Blizzard's documentation

## [0.5.0] - 2020-04-09
### Added
 - Added support for the following WoW Game Data endpoint category :
   - Creatures

### Bug fix
 - Typo corrections

## [0.4.0] - 2020-04-08
### Added
 - Added support for the following WoW Game Data endpoint categories :
   - Auctions
   - Azerite Essence
   - Connected Realms
 - Changed "API" class to "BlizzardAPI" for consistency and clarity
 - Refactored a bit to get less copy-pasting

## [0.3.0] - 2020-04-07
### Changed 
 - Updated README.md

## [0.2.0] - 2020-04-07
### Added 
 - Added an example file and removed the temporary singleton

### Removed
 - Removed the temporary singleton class (everything will be static instead)

## [0.1.0] - 2020-04-07
### First release
 - Added core methods : access token retrieval, web request, etc.
 - Added support for the following WoW Game Data endpoint categories :
   - Achievements
   - Realms
 - Added support for the following WoW Profile endpoint category :
   - Character Profile