// Name: Samrat Jayanta Bhurtel
// Student ID: 100949545
// Date: 13th November 2024
// Purpose: Create a static class for file input/output operations
// Title: fileIOTools.cs
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MineCraft
{
    public static class fileIOTools
    {
        public static void SaveProfile(string filePath, PlayerProfile profile)
        {
            try
            {
                StringBuilder profileData = new StringBuilder();
                profileData.AppendLine($"ProfileName={profile.ProfileName}");
                profileData.AppendLine($"InputDevice={profile.InputDevice}");
                profileData.AppendLine($"AutoJump={profile.AutoJump}");
                profileData.AppendLine($"MouseSensitivity={profile.MouseSensitivity}");
                profileData.AppendLine($"ControllerSensitivity={profile.ControllerSensitivity}");
                profileData.AppendLine($"InvertYAxis={profile.InvertYAxis}");
                profileData.AppendLine($"Brightness={profile.Brightness}");
                profileData.AppendLine($"FancyGraphics={profile.FancyGraphics}");
                profileData.AppendLine($"VSync={profile.VSync}");
                profileData.AppendLine($"Fullscreen={profile.Fullscreen}");
                profileData.AppendLine($"RenderDistance={profile.RenderDistance}");
                profileData.AppendLine($"FieldOfView={profile.FieldOfView}");
                profileData.AppendLine($"RayTracing={profile.RayTracing}");
                profileData.AppendLine($"Upscaling={profile.Upscaling}");
                profileData.AppendLine($"MusicVolume={profile.MusicVolume}");
                profileData.AppendLine($"SoundVolume={profile.SoundVolume}");
                profileData.AppendLine($"HUDTransparency={profile.HUDTransparency}");
                profileData.AppendLine($"ShowCoordinates={profile.ShowCoordinates}");
                profileData.AppendLine($"CameraPerspective={profile.CameraPerspective}");

                File.WriteAllText(filePath, profileData.ToString());
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Failed to save profile to file.", ex);
            }
        }

        public static PlayerProfile LoadProfile(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                    throw new FileNotFoundException("Profile file does not exist.", filePath);

                var profile = new PlayerProfile();
                foreach (var line in File.ReadAllLines(filePath))
                {
                    var parts = line.Split('=');
                    if (parts.Length != 2) continue;

                    var key = parts[0].Trim();
                    var value = parts[1].Trim();

                    switch (key)
                    {
                        case "ProfileName": profile.ProfileName = value; break;
                        case "InputDevice": profile.InputDevice = value; break;
                        case "AutoJump": profile.AutoJump = bool.Parse(value); break;
                        case "MouseSensitivity": profile.MouseSensitivity = int.Parse(value); break;
                        case "ControllerSensitivity": profile.ControllerSensitivity = int.Parse(value); break;
                        case "InvertYAxis": profile.InvertYAxis = bool.Parse(value); break;
                        case "Brightness": profile.Brightness = int.Parse(value); break;
                        case "FancyGraphics": profile.FancyGraphics = bool.Parse(value); break;
                        case "VSync": profile.VSync = bool.Parse(value); break;
                        case "Fullscreen": profile.Fullscreen = bool.Parse(value); break;
                        case "RenderDistance": profile.RenderDistance = int.Parse(value); break;
                        case "FieldOfView": profile.FieldOfView = int.Parse(value); break;
                        case "RayTracing": profile.RayTracing = bool.Parse(value); break;
                        case "Upscaling": profile.Upscaling = bool.Parse(value); break;
                        case "MusicVolume": profile.MusicVolume = int.Parse(value); break;
                        case "SoundVolume": profile.SoundVolume = int.Parse(value); break;
                        case "HUDTransparency": profile.HUDTransparency = int.Parse(value); break;
                        case "ShowCoordinates": profile.ShowCoordinates = bool.Parse(value); break;
                        case "CameraPerspective": profile.CameraPerspective = value; break;
                    }
                }
                return profile;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Failed to load profile from file.", ex);
            }
        }
    }
}
