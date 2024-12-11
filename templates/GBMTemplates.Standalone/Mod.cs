using GBMTemplates.Standalone;
using MelonLoader;

[assembly: MelonInfo(typeof(Mod), "ModName" /* Mod Name */, "AuthorName" /* Your Name */, "0.1.0" /* Version */)] // Can optionally specify a download link for CementGB auto updates
[assembly: MelonGame("Boneloaf", "Gang Beasts")] // Makes sure this mod is only loaded for Gang Beasts. Remove this if you want to use this template for other games.

namespace GBMTemplates.Standalone;

public class Mod : MelonMod
{
    public static MelonLogger.Instance Logger => Melon<Mod>.Logger; // Forwards MelonLoader's Logger to static access, so it is easier to call for it from other classes (instead of Melon<Mod>.Msg("blah blah") it is simply Mod.Logger.Msg("blah blah"))

    public override void OnInitializeMelon()
    {
        // Put starting code here

        LoggerInstance.Msg(System.ConsoleColor.Green, $"Mod ModName initialized!"); // You must use MelonLoader's Logger instance, NOT Unity's Debug.Log or the system console.
    }
}
