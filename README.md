# **Character Creator**

### By _Max Betich_

## Technologies Used

* _C#/.NET v6_
* _HTML_
* _CSS_
* _Bootstrap_
* _MySQL 8.0_

## Description
This application is intended to function as a tool to help create and track the progression of characters for roleplaying games similar to Dungeons and Dragons or Pathfinder. It will, once completed, allow users to log in and see a list of their previously created characters, give them the ability to create new characters, and selected a character and advance them by increasing in level and gaining new powers and abilities.
The application currently has stored seed data for creating pre-generated ancestries, backgrounds, and classes. Future versions of the application will potentially utilize an external API to store this information, as well as tables of items, spells, and other information.

Further exploration of the project suggests that setting up the pages using React tools would likely simplify the amount of information being kept track of between pages, but I believe it remains workable in a C#/.NET MVC setup.

## Setup/Installation Requirements
* Clone project from this [GitHub repository](https://github.com/MaxBetich/character-creator.git) to your desktop.
* Navigate to the CharacterCreator directory inside this repo in your terminal and create a new file called `appsettings.json`.
* Within `appsettings.json` put in the following code, replacing the `[UID HERE]` and `[PWD HERE]` values with your own username and password for MySQL.

```json
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=charactercreator;uid=[UID HERE];pwd=[PWD HERE];"
  }
}
```
* Run the command `dotnet restore` in your terminal to initialize the program.
* Run the command `dotnet ef database update` after ensuring your MySQL workbench is running to create the project database.
* Within the CharacterCreator directory run `dotnet watch run` in the terminal to start the program in your default browser.
 
## Known Bugs

None

## License

MIT

Copyright (c) _2023_ _Max Betich_