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
            // Save profile to a file
            public static void SaveProfile(string filePath, playerProfile.PlayerProfile profile)
            {
                try
                {
                    // Serialize the PlayerProfile object to plain text format
                    StringBuilder profileData = new StringBuilder();
                    profileData.AppendLine($"txtProfileName={profile.txtProfileName}");
                    profileData.AppendLine($"cbxInputDevice={profile.cbxInputDevice}");
                    profileData.AppendLine($"cbxAutoJump={profile.cbxAutoJump}");
                    profileData.AppendLine($"nudMouseSensitivity={profile.nudMouseSensitivity}");
                    profileData.AppendLine($"nudControllerSensitivity={profile.nudControllerSensitivity}");
                    profileData.AppendLine($"cbxYaxis={profile.cbxYaxis}");
                    profileData.AppendLine($"nudBrightness={profile.nudBrightness}");
                    profileData.AppendLine($"cbxFancyGraphics={profile.cbxFancyGraphics}");
                    profileData.AppendLine($"cbxVsync={profile.cbxVsync}");
                    profileData.AppendLine($"cbxFullScreen={profile.cbxFullScreen}");
                    profileData.AppendLine($"nudRenderDistance={profile.nudRenderDistance}");
                    profileData.AppendLine($"nudFieldofView={profile.nudFieldofView}");
                    profileData.AppendLine($"cbxRayTracing={profile.cbxRayTracing}");
                    profileData.AppendLine($"cbxUpscaling={profile.cbxUpscaling}");
                    profileData.AppendLine($"trckbrMusicVolume={profile.trckbrMusicVolume}");
                    profileData.AppendLine($"trckbrSoundVolume={profile.trckbrSoundVolume}");
                    profileData.AppendLine($"nudTransparency={profile.nudTransparency}");
                    profileData.AppendLine($"cbxShowCoordinates={profile.cbxShowCoordinates}");
                    profileData.AppendLine($"cbxCameraPerspective={profile.cbxCameraPerspective}");

                    // Write the plain text data to the specified file path
                    File.WriteAllText(filePath, profileData.ToString());
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Failed to save profile to file.", ex);
                }
            }

            // Load profile from a file
            public static playerProfile.PlayerProfile LoadProfile(string filePath)
            {
                try
                {
                    // Check if the file exists
                    if (!File.Exists(filePath))
                        throw new FileNotFoundException("Profile file does not exist.", filePath);

                    // Read the plain text data from the file
                    string[] profileData = File.ReadAllLines(filePath);

                    // Create a new PlayerProfile object and populate it with the data
                    var profile = new playerProfile.PlayerProfile();
                    foreach (string line in profileData)
                    {
                        string[] parts = line.Split('=');
                        if (parts.Length != 2) continue;

                        string key = parts[0].Trim();
                        string value = parts[1].Trim();

                        switch (key)
                        {
                            case "txtProfileName":
                                profile.txtProfileName = value;
                                break;
                            case "cbxInputDevice":
                                profile.cbxInputDevice = Enum.TryParse(value, out playerProfile.PlayerProfile.InputDevices device) ? device : playerProfile.PlayerProfile.InputDevices.Keyboard;
                                break;
                            case "cbxAutoJump":
                                profile.cbxAutoJump = bool.Parse(value);
                                break;
                            case "nudMouseSensitivity":
                                profile.nudMouseSensitivity = int.Parse(value);
                                break;
                            case "nudControllerSensitivity":
                                profile.nudControllerSensitivity = int.Parse(value);
                                break;
                            case "cbxYaxis":
                                profile.cbxYaxis = bool.Parse(value);
                                break;
                            case "nudBrightness":
                                profile.nudBrightness = int.Parse(value);
                                break;
                            case "cbxFancyGraphics":
                                profile.cbxFancyGraphics = bool.Parse(value);
                                break;
                            case "cbxVsync":
                                profile.cbxVsync = bool.Parse(value);
                                break;
                            case "cbxFullScreen":
                                profile.cbxFullScreen = bool.Parse(value);
                                break;
                            case "nudRenderDistance":
                                profile.nudRenderDistance = int.Parse(value);
                                break;
                            case "nudFieldofView":
                                profile.nudFieldofView = int.Parse(value);
                                break;
                            case "cbxRayTracing":
                                profile.cbxRayTracing = bool.Parse(value);
                                break;
                            case "cbxUpscaling":
                                profile.cbxUpscaling = bool.Parse(value);
                                break;
                            case "trckbrMusicVolume":
                                profile.trckbrMusicVolume = int.Parse(value);
                                break;
                            case "trckbrSoundVolume":
                                profile.trckbrSoundVolume = int.Parse(value);
                                break;
                            case "nudTransparency":
                                profile.nudTransparency = int.Parse(value);
                                break;
                            case "cbxShowCoordinates":
                                profile.cbxShowCoordinates = bool.Parse(value);
                                break;
                            case "cbxCameraPerspective":
                                profile.cbxCameraPerspective = Enum.TryParse(value, out playerProfile.PlayerProfile.CameraPerspectives perspective) ? perspective : playerProfile.PlayerProfile.CameraPerspectives.FirstPerson;
                                break;
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

           