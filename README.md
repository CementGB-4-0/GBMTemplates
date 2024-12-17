# GBMTemplates

Standard MelonLoader mod `dotnet new` templates for use in Gang Beasts mods.

## Currently Included Templates

| Display Name                             | Short Name        | Version Added |
|------------------------------------------|-------------------|---------------|
| Gang Beasts Mod (MelonLoader Standalone) | gbm-ml-standalone | v1.0.0        |

## Installation

**Once you've installed the prerequisites below,** open your terminal and install the templates with the following command:

```dotnet new install GBMTemplates```

or, if you want the latest CI build, [download the artifact](https://nightly.link/TheUltimateNuke/GBMTemplates/workflows/ci/main/build-artifact), extract the zipped file, and install using the same command as above but with the path to the `.nuget` file within the extracted zip.

Then, create a new mod using the short name of one of the templates, like so:

```dotnet new gbm-ml-standalone -o <mod name>```.

It will tell you to add a file named `game_dir.txt` next to the solution file. Write the path to your game folder in this new text file. **Ensure there are not multiple lines in the file, as this breaks the build system currently.**  
After that, run `dotnet build`. The built dll should be automatically copied to your game's `Mods` folder for rapid iteration.

## Prerequisites

- [MelonLoader](https://melonwiki.xyz/#/)
- A **legal** copy of Gang Beasts ran once after installing MelonLoader
- [.NET (Core) SDK 8](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [.NET (Core) SDK 6](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
- [.NET (Core) 6 Desktop Runtime](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
