# GBMTemplates

Standard MelonLoader mod templates for use in Gang Beasts mods.

## Installation

Once you've installed the prerequisites below, install the templates with the following command:

```dotnet new install GBMTemplates```

Then, create a new mod using:

```dotnet new gbm-ml-standalone -o <mod name>```.

It will tell you to add a file named `game_dir.txt` next to the solution file. Write the path to your game folder in this new text file.

## Prerequisites

- A copy of Gang Beasts ran once after installing MelonLoader
- [.NET (Core) SDK 8](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [.NET (Core) SDK 6](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
- [.NET (Core) 6 Desktop Runtime](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
