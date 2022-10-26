﻿using HarmonyLib;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Newtonsoft.Json;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley;
using StardewValley.Locations;
using StardewValley.TerrainFeatures;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using xTile;
using xTile.Tiles;

namespace StardewOpenWorld
{
    /// <summary>The mod entry point.</summary>
    public partial class ModEntry : Mod
    {

        public static IMonitor SMonitor;
        public static IModHelper SHelper;
        public static ModConfig Config;
        public static ModEntry context;

        public static string dataPath = "aedenthorn.StardewOpenWorld/dictionary";
        public static string namePrefix = "StardewOpenWorld";
        public static string tilePrefix = "StardewOpenWorldTile";
        public static readonly int openWorldTileSize = 250;
        public static bool warping = false;
        private static GameTime deltaTime;

        private static GameLocation openWorldLocation;
        private static Dictionary<Vector2, Tile> openWorldBack = new Dictionary<Vector2, Tile>();
        private static Dictionary<Vector2, Tile> openWorldBuildings = new Dictionary<Vector2, Tile>();
        private static Dictionary<Vector2, Tile> openWorldFront = new Dictionary<Vector2, Tile>();

        /// <summary>The mod entry point, called after the mod is first loaded.</summary>
        /// <param name="helper">Provides simplified APIs for writing mods.</param>
        public override void Entry(IModHelper helper)
        {
            Config = Helper.ReadConfig<ModConfig>();
            SMonitor = Monitor;
            SHelper = helper;

            context = this;

            helper.Events.GameLoop.GameLaunched += GameLoop_GameLaunched;
            helper.Events.GameLoop.UpdateTicked += GameLoop_UpdateTicked;
            helper.Events.Content.AssetRequested += Content_AssetRequested;

            var harmony = new Harmony(ModManifest.UniqueID);
            harmony.PatchAll();
        }

        private void Content_AssetRequested(object sender, AssetRequestedEventArgs e)
        {
            if (e.NameWithoutLocale.IsEquivalentTo("Maps/Backwoods"))
            {
                e.LoadFromModFile<Map>(Path.Combine("assets", "BackwoodsEdit.tmx"), AssetLoadPriority.High);
            }
            else if (e.NameWithoutLocale.Name.Contains("StardewOpenWorldTileMap"))
            {
                Helper.GameContent.InvalidateCache(Helper.ModContent.GetInternalAssetName("assets/StardewOpenWorldTile.tmx"));
                e.LoadFromModFile<Map>("assets/StardewOpenWorldTile.tmx", AssetLoadPriority.Exclusive);
            }
        }

        private void GameLoop_UpdateTicked(object sender, UpdateTickedEventArgs e)
        {
            if (!Config.ModEnabled || !Context.IsWorldReady)
                return;
            if (Game1.player.currentLocation.Name.StartsWith(tilePrefix))
            {
                warping = CheckPlayerWarp();
            }
            if (!Game1.isWarping && Game1.player.currentLocation.Name.Equals("Backwoods") && Game1.player.getTileLocation().X == 24 && Game1.player.getTileLocation().Y < 6)
            {
                Game1.warpFarmer($"{tilePrefix}_100_199", 125, 249, false);
            }
        }

        private void GameLoop_GameLaunched(object sender, GameLaunchedEventArgs e)
        {
            // get Generic Mod Config Menu's API (if it's installed)
            var configMenu = Helper.ModRegistry.GetApi<IGenericModConfigMenuApi>("spacechase0.GenericModConfigMenu");
            if (configMenu is null)
                return;

            // register mod
            configMenu.Register(
                mod: ModManifest,
                reset: () => Config = new ModConfig(),
                save: () => Helper.WriteConfig(Config)
            );

            configMenu.AddBoolOption(
                mod: ModManifest,
                name: () => "Mod Enabled",
                getValue: () => Config.ModEnabled,
                setValue: value => Config.ModEnabled = value
            );
        }
    }
}