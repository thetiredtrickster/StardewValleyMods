﻿using HarmonyLib;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Newtonsoft.Json;
using StardewValley;
using StardewValley.Buildings;
using StardewValley.Characters;
using StardewValley.Locations;
using StardewValley.TerrainFeatures;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using xTile.Dimensions;
using xTile.Tiles;
using Rectangle = Microsoft.Xna.Framework.Rectangle;

namespace StardewOpenWorld
{
    public partial class ModEntry
    {
        [HarmonyPatch(typeof(Game1), nameof(Game1.loadForNewGame))]
        public class Game1_loadForNewGame_Patch
        {
            public static void Postfix()
            {
                if (!Config.ModEnabled)
                    return;


                openWorldLocation = new GameLocation("StardewOpenWorldTileMap", namePrefix) { IsOutdoors = true, IsFarm = true, IsGreenhouse = false };

                List<string> tileNames = new List<string>()
                {
                    $"{tilePrefix}_98_198",
                    $"{tilePrefix}_98_199",
                    $"{tilePrefix}_99_198",
                    $"{tilePrefix}_99_199",
                    $"{tilePrefix}_100_198",
                    $"{tilePrefix}_100_199"
                };
                ReloadOpenWorldTiles(tileNames);
            }
        }

        [HarmonyPatch(typeof(Game1), nameof(Game1.UpdateViewPort))]
        public class Game1_UpdateViewPort_Patch
        {
            public static void Prefix(ref bool overrideFreeze)
            {
                if (!Config.ModEnabled || !Game1.player.currentLocation.Name.StartsWith(tilePrefix))
                    return;
                overrideFreeze = true;
                Game1.forceSnapOnNextViewportUpdate = true;
                Game1.currentLocation.forceViewportPlayerFollow = true;
            }
        }


        [HarmonyPatch(typeof(GameLocation), nameof(GameLocation.drawBackground))]
        public class GameLocation_drawBackground_Patch
        {
            public static Tile lastTile;
            public static void Postfix(GameLocation __instance)
            {
                if (!Config.ModEnabled || !__instance.Name.StartsWith(tilePrefix))
                    return;

                var tile = GetTileFromName(__instance.Name);
                var surrounding = new int[]
                {
                    -1,
                    0,
                    1
                };
                foreach(var x in surrounding)
                {
                    foreach (var y in surrounding)
                    {
                        if (x == 0 && y == 0)
                            continue;
                        if (tile.X + x < 0 || tile.X + x > 199 || tile.Y + y < 0 || tile.Y + y > 199 )
                            continue;

                        if (x == 1 && Game1.viewport.Location.X < openWorldTileSize * 64 - Game1.viewport.Width)
                            continue;
                        if (x == -1 && Game1.viewport.Location.X > Game1.viewport.Width)
                            continue;
                        if (y == 1 && Game1.viewport.Location.Y < openWorldTileSize * 64 - Game1.viewport.Height)
                            continue;
                        if (y == -1 && Game1.viewport.Location.Y > Game1.viewport.Height)
                            continue;
                        GameLocation loc = Game1.getLocationFromName($"{tilePrefix}_{tile.X + x}_{tile.Y + y}");
                        if (loc is null)
                            continue;
                        DrawGameLocation(loc, x * openWorldTileSize * 64, y * openWorldTileSize * 64);
                    }
                }
            }
        }
    }
}