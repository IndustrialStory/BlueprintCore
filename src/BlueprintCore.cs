using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.API.Server;
using System;

[assembly: ModInfo( "BlueprintCore",
    Description = "Blueprints for your structural modding needs.",
    Website     = "https://eln2.org",
    Authors     = new []{ "jrddunbr" } )]

namespace BlueprintCore {
    public class BlueprintCore : ModSystem {
        public override void StartServerSide(ICoreServerAPI api) {
            Console.WriteLine("Hello World! This is Server Start!");
            //String iwcr = api.Assets.GetMany<String[]>("recipes/inworld");
        }
    }
}