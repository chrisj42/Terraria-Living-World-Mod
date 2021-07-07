﻿using System.IO;
using Terraria.ModLoader;

namespace LivingWorldMod.Custom.Utilities {

    /// <summary>
    /// Utilities class that handles reading, writing, and general I/O management.
    /// </summary>
    public static class IOUtilities {

        /// <summary>
        /// Directory of the Sprites for LivingWorldMod.
        /// </summary>
        public static string LWMSpritePath => nameof(LivingWorldMod) + "/Assets/Sprites";

        /// <summary>
        /// Returns the LWM File path in the ModLoader folder, and creates the directory if it does
        /// not exist.
        /// </summary>
        /// <returns> </returns>
        public static string GetLWMFilePath() {
            string LWMPath = ModLoader.ModPath.Replace("Mods", "LivingWorldMod");

            if (!Directory.Exists(LWMPath)) {
                Directory.CreateDirectory(LWMPath);
            }

            return LWMPath;
        }
    }
}