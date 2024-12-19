using GBMTemplates.Standalone;
using MelonLoader;

[assembly: MelonInfo(typeof(Mod), Mod.BuildInfo.Name /* Mod Name */, Mod.BuildInfo.Version /* Version (Semantic versioning convention recommended) */, Mod.BuildInfo.Author /* Your Name */, Mod.BuildInfo.DownloadLink /* Download Link for Cement auto-updating (optional, null means disabled) */)]
[assembly: MelonGame("Boneloaf", "Gang Beasts")] // Makes sure this mod is only loaded for Gang Beasts. Remove this if you want to use this template for other games.

namespace GBMTemplates.Standalone;

public class Mod : MelonMod
{
    public static class BuildInfo
    {
        public const string Name = "ModName";
        public const string Author = "AuthorName";
        public const string Version = "0.1.0";
        public const string DownloadLink = null
    }

    public static MelonLogger.Instance Logger => Melon<Mod>.Logger; // Forwards MelonLoader's Logger to static access, so it is easier to call for it from other classes (instead of Melon<Mod>.Msg("blah blah") it is simply Mod.Logger.Msg("blah blah"))

    public override void OnInitializeMelon()
    {
        // Put starting code here

        LoggerInstance.Msg(System.ConsoleColor.Green, $"Mod ModName initialized!"); // You must use MelonLoader's Logger instance, NOT Unity's Debug.Log or the system console.
    }
}
