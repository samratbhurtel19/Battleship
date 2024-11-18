// Purpose: Create an instantiable class for player profiles
// Title: playerProfile.cs
// Name: Samrat Jayanta Bhurtel
// Student ID: 100949545
// Date: 13th November 2024
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MineCraft
{
    /// <summary>
    /// This class represents a player profile with various settings and preferences.
    /// </summary>
    public class PlayerProfile
    {
        public string ProfileName { get; set; }
        public string InputDevice { get; set; } = "Keyboard";
        public bool AutoJump { get; set; } = true;
        public int MouseSensitivity { get; set; } = 50;
        public int ControllerSensitivity { get; set; } = 50;
        public bool InvertYAxis { get; set; } = false;
        public int Brightness { get; set; } = 50;
        public bool FancyGraphics { get; set; } = true;
        public bool VSync { get; set; } = true;
        public bool Fullscreen { get; set; } = false;
        public int RenderDistance { get; set; } = 16;
        public int FieldOfView { get; set; } = 64;
        public bool RayTracing { get; set; } = false;
        public bool Upscaling { get; set; } = false;
        public int MusicVolume { get; set; } = 100;
        public int SoundVolume { get; set; } = 100;
        public int HUDTransparency { get; set; } = 100;
        public bool ShowCoordinates { get; set; } = false;
        public string CameraPerspective { get; set; } = "First-person";

        // Method to output profile as a string
        public string ToProfileString()
        {
            return $"ProfileName:{ProfileName}, InputDevice:{InputDevice}, AutoJump:{AutoJump}, " +
                   $"MouseSensitivity:{MouseSensitivity}, ControllerSensitivity:{ControllerSensitivity}, " +
                   $"InvertYAxis:{InvertYAxis}, Brightness:{Brightness}, FancyGraphics:{FancyGraphics}, " +
                   $"VSync:{VSync}, Fullscreen:{Fullscreen}, RenderDistance:{RenderDistance}, " +
                   $"FieldOfView:{FieldOfView}, RayTracing:{RayTracing}, Upscaling:{Upscaling}, " +
                   $"MusicVolume:{MusicVolume}, SoundVolume:{SoundVolume}, HUDTransparency:{HUDTransparency}, " +
                   $"ShowCoordinates:{ShowCoordinates}, CameraPerspective:{CameraPerspective}";
        }
    }
}
