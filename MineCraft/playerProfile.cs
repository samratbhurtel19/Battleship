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
    public class playerProfile
    {

            // Create an instantiable class for player profiles
            public class PlayerProfile
            {
                public string txtProfileName { get; set; } // Unique name for each profile

                public enum InputDevices
                {
                    Keyboard,
                    Controller,
                    Touch
                }

                public enum CameraPerspectives
                {
                    FirstPerson,
                    ThirdPersonFront,
                    ThirdPersonBack
                }

                // Movement Properties
                public InputDevices cbxInputDevice { get; set; } = InputDevices.Keyboard;
                public bool cbxAutoJump { get; set; } = true; // Default: On
                public int nudMouseSensitivity { get; set; } = 50; // Default: 50
                public int nudControllerSensitivity { get; set; } = 50; // Default: 50
                public bool cbxYaxis { get; set; } = false; // Default: Off

                // Video Properties
                public int nudBrightness { get; set; } = 50; // Default: 50
                public bool cbxFancyGraphics { get; set; } = true; // Default: On
                public bool cbxVsync { get; set; } = true; // Default: On
                public bool cbxFullScreen { get; set; } = false; // Default: Off
                public int nudRenderDistance { get; set; } = 16; // Default: 16
                public int nudFieldofView { get; set; } = 64; // Default: 64
                public bool cbxRayTracing { get; set; } = false; // Default: Off
                public bool cbxUpscaling { get; set; } = false; // Default: Off

                // Audio Properties
                public int trckbrMusicVolume { get; set; } = 100; // Default: 100
                public int trckbrSoundVolume { get; set; } = 100; // Default: 100

                // Interface Properties
                public int nudTransparency { get; set; } = 100; // Default: 100
                public bool cbxShowCoordinates { get; set; } = false; // Default: Off
                public CameraPerspectives cbxCameraPerspective { get; set; } = CameraPerspectives.FirstPerson; // Default: First-person

                // Step 3: Create a method to build the string output for saving
                public string ToProfileString()
                {
                    return $"txtProfileName={txtProfileName}, cbxInputDevice={cbxInputDevice}, cbxAutoJump={cbxAutoJump}, " +
                           $"nudMouseSensitivity={nudMouseSensitivity}, nudControllerSensitivity={nudControllerSensitivity}, " +
                           $"cbxYaxis={cbxYaxis}, nudBrightness={nudBrightness}, cbxFancyGraphics={cbxFancyGraphics}, " +
                           $"cbxVsync={cbxVsync}, cbxFullScreen={cbxFullScreen}, nudRenderDistance={nudRenderDistance}, " +
                           $"nudFieldofView={nudFieldofView}, cbxRayTracing={cbxRayTracing}, cbxUpscaling={cbxUpscaling}, " +
                           $"trckbrMusicVolume={trckbrMusicVolume}, trckbrSoundVolume={trckbrSoundVolume}, nudTransparency={nudTransparency}, " +
                           $"cbxShowCoordinates={cbxShowCoordinates}, cbxCameraPerspective={cbxCameraPerspective}";
                }
            }
        }
    }
