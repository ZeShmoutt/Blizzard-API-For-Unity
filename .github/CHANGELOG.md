# Changelog
All notable changes to this package will be documented in this file.

The format is based on [Keep a Changelog](http://keepachangelog.com/en/1.0.0/), and this project *somewhat* adheres to [Semantic Versioning](http://semver.org/spec/v2.0.0.html).

## Unreleased
### To do
 - Update to Unity 2019.x.x

### Added
 - Added an editor-only window to quickly retrieve an OAuth access token (menu : `Blizzard API/Get Access Token`)
   - This is mostly useful in Blizzard's documentation, by providing an access token to test endpoints
  
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