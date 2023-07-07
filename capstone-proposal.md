## Name of Student: Max Betich

## Name of Project: Character Creator

## Project's Purpose or Goal:
This application is intended to function as a tool to help create and track the progression of characters for roleplaying games similar to Dungeons and Dragons or Pathfinder. It will, once completed, allow users to log in and see a list of their previously created characters, give them the ability to create new characters, and selected a character and advance them by increasing in level and gaining new powers and abilities.

## List the absolute minimum features the project requires to meet this purpose or goal:
* The ability to store created characters, as well as related character data, such as options for race, class, background, etc. in a database.
* The ability for a user to log in, and have the application identify based on their credentials which characters belong to them, and retrieve and display that information as appropriate.
* The ability to validate choices made when creating or progressing a character to ensure the rules of character creation are being followed, ie. no invalid or incomplete characters will be able to be created.

## What tools, frameworks, libraries, APIs, modules and/or other resources (whatever is specific to your track, and your language) will you use to create this MVP? List them all here. Be specific.
* C#/.NET v6
* Entity Framework Core
* Identity
* HTML
* CSS
* Bootstrap
* MySQL 8.0
* Razor

## If you finish developing the minimum viable product (MVP) with time to spare, what will you work on next? Describe these features here: Be specific.
* The ability to add an inventory to characters, allowing them to track what items they might be carrying or wearing, and what effects those items might have on the character's abilities.
* Functionality to allow a user of the application to roll dice and display results according to the abilities of a currently selected character, ie. clicking an icon to roll an attack and see what the result is based on the character's strength and what weapon they may have equipped.
* Transferring some of the back-end data, such as lists of classes, races, feats, and items, to a back-end database that be accessed by making API calls, thereby reducing the size of the front-end application.

## What additional tools, frameworks, libraries, APIs, or other resources will these additional features require?
* ASP.NET Core MVC
