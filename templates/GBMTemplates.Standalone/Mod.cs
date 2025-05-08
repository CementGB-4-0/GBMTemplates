using GBMTemplates.Standalone;
using MelonLoader;

// Mod info can be changed in GBMTemplates.Standalone.csproj.
[assembly: MelonInfo(typeof(Mod), MyModInfo.Name /* Mod Name */, MyModInfo.Version /* Version (Semantic versioning convention recommended) */, MyModInfo.Author /* Your Name */, null /* Download Link (optional, null means disabled) */)]
[assembly: MelonGame("Boneloaf", "Gang Beasts")] // Makes sure this mod is only loaded for Gang Beasts. Remove this if you want to use this template for other games.

namespace GBMTemplates.Standalone;

public class Mod : MelonMod
{
    public static MelonLogger.Instance Logger => Melon<Mod>.Logger; // Forwards MelonLoader's Logger to static access, so it is easier to call for it from other classes (instead of Melon<Mod>.Msg("blah blah") it is simply Mod.Logger.Msg("blah blah"))

    public override void OnInitializeMelon()
    {
        // Put starting code here

        LoggerInstance.Msg(System.ConsoleColor.Green, $"Mod {MyModInfo.Name} initialized!"); // You must use MelonLoader's Logger instance, NOT Unity's Debug.Log or the system console.
    }
}
