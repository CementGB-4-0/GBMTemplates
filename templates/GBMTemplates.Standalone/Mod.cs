using GBMTemplates.Standalone;
using MelonLoader;

[assembly: MelonInfo(typeof(Mod), "ModName", "AuthorName", "0.1.0")]
[assembly: MelonGame("Boneloaf", "Gang Beasts")]

namespace GBMTemplates.Standalone;

public class Mod : MelonMod
{
    public override void OnInitializeMelon()
    {
        LoggerInstance.Msg(System.ConsoleColor.Green, $"Mod ModName initialized!");
    }
}
