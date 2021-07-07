﻿using System;
using LivingWorldMod.Content.NPCs.Villagers;
using Terraria;
using Terraria.Utilities;

namespace LivingWorldMod.Custom.Utilities {

    /// <summary>
    /// Class that holds all of the class extending methods that this mod uses.
    /// </summary>
    public static class ClassExtensions {

        /// <summary>
        /// Returns whether or not this npc is any type of Villager.
        /// </summary>
        /// <param name="npc"></param>
        /// <returns></returns>
        public static bool IsTypeOfVillager(this NPC npc) {
            return npc.ModNPC?.GetType().IsSubclassOf(typeof(Villager)) ?? false;
        }


        /// <summary>
        /// Adds all of the objects and their weights within another list into this list.
        /// </summary>
        /// <param name="originalList"> List that will be added to. </param>
        /// <param name="list">
        /// List that will have its objects and theirs weights added to the other list.
        /// </param>
        public static void AddList<T>(this WeightedRandom<T> originalList, WeightedRandom<T> list) {
            foreach ((T obj, double weight) in list.elements) {
                originalList.Add(obj, weight);
            }
        }

        /// <summary>
        /// Adds to the <see cref="WeightedRandom{T}"/> only if the given condition returns true.
        /// </summary>
        /// <param name="list"> List to add to. </param>
        /// <param name="obj"> Object to add to the list. </param>
        /// <param name="condition">
        /// Condition that determines whether or not to add the given object to the list.
        /// </param>
        /// <param name="weight"> The potential weight of the object, if required. </param>
        public static void AddConditionally<T>(this WeightedRandom<T> list, T obj, bool condition, double weight = 1) {
            if (condition) {
                list.Add(obj, weight);
            }
        }
    }
}