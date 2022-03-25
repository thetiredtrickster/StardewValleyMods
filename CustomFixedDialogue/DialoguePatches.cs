﻿using StardewModdingAPI;
using StardewValley;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CustomFixedDialogue
{
    public class DialoguePatches
    {
        private static IMonitor Monitor;
        private static IModHelper Helper;
        private static string CSPrefix = "Strings\\StringsFromCSFiles:";
        private static string CSReplacePrefix = "StringsFromCSFiles_";
        private static string NPCPrefix = "Strings\\StringsFromCSFiles:NPC.cs.";
        private static string eventPrefix = "Strings\\StringsFromCSFiles:Event.cs.";
        private static string utilityPrefix = "Strings\\StringsFromCSFiles:Utility.cs.";
        private static string extraPrefix = "Data\\ExtraDialogue:";
        private static string extraReplacePrefix = "ExtraDialogue_";
        private static string charactersPrefix = "Strings\\Characters:";
        private static string charactersReplacePrefix = "Characters_";
        private static bool dontFix;


        private static List<string> NPCAllowed = new List<string>() { "3926", "3927", "3956", "3957", "3958", "3959", "3960", "3961", "3962", "3963", "3965", "3966", "3967", "3968", "3970", "3971", "3972", "3973", "3974", "3975", "3980", "3985", "3990", "3996", "4001", "4058", "4059", "4060", "4061", "4062", "4063", "4064", "4065", "4066", "4068", "4071", "4072", "4078", "4079", "4080", "4083", "4084", "4086", "4088", "4089", "4091", "4094", "4097", "4100", "4103", "4106", "4109", "4111", "4113", "4114", "4115", "4116", "4118", "4120", "4125", "4126", "4128", "4131", "4135", "4138", "4141", "4144", "4146", "4147", "4149", "4152", "4153", "4154", "4161", "4164", "4170", "4171", "4172", "4174", "4176", "4178", "4180", "4182", "4192", "4274", "4275", "4276", "4277", "4278", "4279", "4280", "4281", "4293", "4294", "4406", "4420", "4421", "4422", "4423", "4424", "4425", "4426", "4427", "4429", "4431", "4432", "4433", "4434", "4435", "4436", "4437", "4438", "4439", "4440", "4441", "4442", "4443", "4444", "4445", "4446", "4447", "4448", "4449", "4452", "4455", "4462", "4463", "4465", "4466", "4470", "4474", "4481", "4485", "4486", "4488", "4489", "4490", "4496", "4497", "4498", "4499", "4500", "4507", "4508", "4509", "4510", "4511", "4512", "4513", "4514", "4515", "4516", "4517", "4518", "4519", "4522", "4523" };

        private static List<string> extraAllowed = new List<string>()
        {
            "LostItemQuest_DefaultThankYou",
            "NewChild_SecondChild1",
            "NewChild_SecondChild2",
            "NewChild_Adoption",
            "NewChild_FirstChild",
            "Spouse_KitchenBlocked",
            "Spouse_MonstersInHouse",
            "Wizard_Hatch",
            "Mines_PlayerKilled_Spouse_PlayerMale",
            "Mines_PlayerKilled_Spouse_PlayerFemale",
            "PurchasedItem_1_QualityHigh",
            "PurchasedItem_1_QualityLow",
            "PurchasedItem_2_QualityHigh",
            "PurchasedItem_2_QualityLow",
            "PurchasedItem_3_QualityLow_Rude",
            "PurchasedItem_3_QualityHigh_Rude",
            "PurchasedItem_3_NonRude",
            "PurchasedItem_4",
            "PurchasedItem_5_VegetableOrFruit",
            "PurchasedItem_5_Cooking",
            "PurchasedItem_5_Foraged",
            "PurchasedItem_Teen",
            "Town_DumpsterDiveComment_Child",
            "Town_DumpsterDiveComment_Teen",
            "Town_DumpsterDiveComment_Adult"
        };
        private static List<string> charactersAllowed = new List<string>()
        {
            "WipedMemory",
            "Divorced_bouquet",
            "Divorced_gift",
            "Saloon_goodEvent_0",
            "Saloon_goodEvent_1",
            "Saloon_goodEvent_2",
            "Saloon_goodEvent_3",
            "Saloon_goodEvent_4",
            "Saloon_badEvent_0",
            "Saloon_badEvent_1",
            "Saloon_badEvent_2",
            "Saloon_badEvent_3",
            "Saloon_badEvent_4",
            "Saloon_neutralEvent_0",
            "Saloon_neutralEvent_1",
            "Saloon_neutralEvent_2",
            "Saloon_neutralEvent_3",
            "Saloon_neutralEvent_4",
            "MovieInvite_InvitedBySomeoneElse",
            "MovieInvite_AlreadySeen",
            "MovieInvite_Invited",
            "MovieInvite_Invited_Rude",
            "MovieInvite_Invited_Child",
            "MovieInvite_Reject_Child",
            "MovieInvite_Reject",
         };

        private static List<string> eventChanges = new List<string>()
        {
            "1497",
            "1498",
            "1499",
            "1500",
            "1501",
            "1503",
            "1504",
            "1632",
            "1633",
            "1634",
            "1635",
            "1736",
            "1738",
            "1801",
        };

        private static List<string> utilityChanges = new List<string>()
        {
            "5348",
            "5349",
            "5350",
            "5351",
            "5352",
            "5353",
            "5356",
            "5357",
            "5360",
            "5361",
            "5362",
            "5363",
            "5364",
        };

        public static void Initialize(IMonitor monitor, IModHelper helper)
        {
            Monitor = monitor;
            Helper = helper;
        }
        public static void LocalizedContentManager_LoadString_Postfix3(string path, object sub1, object sub2, object sub3, ref string __result)
        {
            if (dontFix)
                return;
            try
            {
                ReplaceString(path, ref __result, new object[] { sub1, sub2, sub3 });
            }
            catch (Exception ex)
            {
                Monitor.Log($"Failed in {nameof(LocalizedContentManager_LoadString_Postfix)}:\n{ex}", LogLevel.Error);
            }
        }
        public static void LocalizedContentManager_LoadString_Postfix2(string path, object sub1, object sub2, ref string __result)
        {
            if (dontFix)
                return;

            try
            {
                ReplaceString(path, ref __result, new object[] { sub1, sub2 });
            }
            catch (Exception ex)
            {
                Monitor.Log($"Failed in {nameof(LocalizedContentManager_LoadString_Postfix)}:\n{ex}", LogLevel.Error);
            }
        }
        public static void LocalizedContentManager_LoadString_Postfix1(string path, object sub1, ref string __result)
        {
            if (dontFix)
                return;
            try
            {
                ReplaceString(path, ref __result, new object[] { sub1 });
            }
            catch (Exception ex)
            {
                Monitor.Log($"Failed in {nameof(LocalizedContentManager_LoadString_Postfix)}:\n{ex}", LogLevel.Error);
            }
        }
        public static void LocalizedContentManager_LoadString_Postfix(string path, ref string __result)
        {
            if (dontFix)
                return;
            try
            {
                ReplaceString(path, ref __result);
            }
            catch (Exception ex)
            {
                Monitor.Log($"Failed in {nameof(LocalizedContentManager_LoadString_Postfix)}:\n{ex}", LogLevel.Error);
            }
        }
        public static void Dialogue_Prefix(Dialogue __instance, ref string masterDialogue, NPC speaker)
        {
            try
            {
                FixString(speaker, ref masterDialogue);

            }
            catch (Exception ex)
            {
                Monitor.Log($"Failed in {nameof(Dialogue_Prefix)}:\n{ex}", LogLevel.Error);
            }
        }

        public static void NPC_showTextAboveHead_Prefix(NPC __instance, ref string Text)
        {
            try
            {
                FixString(__instance, ref Text);
            }
            catch (Exception ex)
            {
                Monitor.Log($"Failed in {nameof(NPC_showTextAboveHead_Prefix)}:\n{ex}", LogLevel.Error);
            }
        }

        public static void NPC_getTermOfSpousalEndearment_Postfix(NPC __instance, ref string __result)
        {
            try
            {
                FixString(__instance, ref __result);
            }
            catch (Exception ex)
            {
                Monitor.Log($"Failed in {nameof(NPC_getTermOfSpousalEndearment_Postfix)}:\n{ex}", LogLevel.Error);
            }
        }

        public static void NPC_getHi_Postfix(NPC __instance, ref string __result)
        {
            try
            {
                FixString(__instance, ref __result);

            }
            catch (Exception ex)
            {
                Monitor.Log($"Failed in {nameof(NPC_getHi_Postfix)}:\n{ex}", LogLevel.Error);
            }
        }
        public static void convertToDwarvish_Prefix(ref string str)
        {
            try
            {
                FixString(Game1.getCharacterFromName("Dwarf"), ref str);
            }
            catch (Exception ex)
            {
                Monitor.Log($"Failed in {nameof(convertToDwarvish_Prefix)}:\n{ex}", LogLevel.Error);
            }
        }
        public static void GetSummitDialogue_Patch(string key, ref string __result)
        {
            try
            {
                var spouse = Game1.player.getSpouse();
                if (key.Contains("Spouse") && spouse != null)
                {
                    Dictionary<string, string> dialogueDic = null;
                    try
                    {
                        dialogueDic = Game1.content.Load<Dictionary<string, string>>($"Characters/Dialogue/{spouse.Name}");
                    }
                    catch (Exception ex)
                    {
                        Monitor.Log($"Error loading character dictionary for {spouse.Name}:\r\n{ex}");
                    }

                    if (dialogueDic != null && dialogueDic.ContainsKey(key))
                    {
                        Monitor.Log($"{spouse.Name} has dialogue for {key}", LogLevel.Debug);
                        __result = dialogueDic[key];
                    }
                }
            }
            catch (Exception ex)
            {
                Monitor.Log($"Failed in {nameof(convertToDwarvish_Prefix)}:\n{ex}", LogLevel.Error);
            }
        }
        public static void ReplaceString(string path, ref string text, object[] subs = null)
        {
            if (text.Contains("\""))
            {
                return;
            }
            string original = text;
            string substring = "";
            string modifiedPath;
            if (subs != null)
            {
                substring = "`";
                for (int i = 0; i < subs.Length; i++)
                {

                    substring += subs[i] + "`";
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (text.Contains("{" + i + "}"))
                {
                    if (subs == null)
                        substring = "`";
                    substring += "{" + i + "}`";
                }
            }
            if (path.StartsWith(extraPrefix) && extraAllowed.Contains(path.Substring(extraPrefix.Length)))
            {
                modifiedPath = path.Replace(extraPrefix, extraReplacePrefix);
            }
            else if (path.StartsWith(charactersPrefix) && charactersAllowed.Contains(path.Substring(charactersPrefix.Length)))
            {
                modifiedPath = path.Replace(charactersPrefix, charactersReplacePrefix);
            }
            else if (
                (path.StartsWith(NPCPrefix) && NPCAllowed.Contains(path.Substring(NPCPrefix.Length)))
                || (path.StartsWith(eventPrefix) && eventChanges.Contains(path.Substring(eventPrefix.Length)))
                || (path.StartsWith(utilityPrefix) && utilityChanges.Contains(path.Substring(utilityPrefix.Length)))
                )
            {
                modifiedPath = path.Replace(CSPrefix, CSReplacePrefix);
            }
            else return;

            text = "<" + $"{modifiedPath}{substring}" + ">";
            Monitor.Log($"preparing string {original} for replacement: {text}");
        }

        public static void FixString(NPC speaker, ref string input)
        {

            Dictionary<string, string> dialogueDic = null;
            try
            {
                dialogueDic = Game1.content.Load<Dictionary<string, string>>($"Characters/Dialogue/{speaker.Name}");
            }
            catch (Exception ex)
            {
                Monitor.Log($"Error loading character dictionary for {speaker.Name}:\r\n{ex}");
            }
            //Monitor.Log($"checking string: {input}");
            Regex pattern1 = new Regex(@"<(?<key>[^<>]+)>", RegexOptions.Compiled);
            Regex pattern2 = new Regex(@"<(?<key>[^<`>]+)`(?<subs>[^>]+)`>", RegexOptions.Compiled);
            while (pattern1.IsMatch(input))
            {
                var match = pattern1.Match(input);
                string key = match.Groups["key"].Value;
                string[] subs = null;
                string substring = "";
                if (match.Value.Contains("`"))
                {
                    var match2 = pattern2.Match(match.Value);
                    key = match2.Groups["key"].Value;
                    substring = match2.Groups["subs"].Value;
                    if (substring.Length > 0)
                    {
                        subs = substring.Split('`');
                    }
                }

                Monitor.Log($"Found key {key} with subs: {substring}");
                string newString = "";
                string checkKey = key.Replace(CSReplacePrefix, "");
                if (dialogueDic != null && dialogueDic.TryGetValue(checkKey, out newString))
                {
                    Monitor.Log($"Found custom dialogue for npc {speaker.Name}, path {key}: {newString}");
                    if (subs != null)
                    {
                        Monitor.Log($"Dealing with subs");
                        newString = string.Format(newString, subs);
                    }
                    Monitor.Log($"New string: {newString}");
                }
                else
                {
                    key = key.Replace(extraReplacePrefix, extraPrefix);
                    key = key.Replace(charactersReplacePrefix, charactersPrefix);
                    key = key.Replace(CSReplacePrefix, CSPrefix);
                    dontFix = true;
                    if (subs != null)
                    {
                        newString = Game1.content.LoadString(key, subs);
                        Monitor.Log($"Got vanilla string {newString} for key {key}");
                    }
                    else
                    {
                        newString = Game1.content.LoadString(key);
                        Monitor.Log($"Got vanilla string {newString} for key {key}");
                    }
                    dontFix = false;
                }
                input = input.Replace(match.Value, newString);
                Monitor.Log($"Final replacement for {match.Value}: {newString}.\nCurrent output: {input}");
            }
        }
    }
}