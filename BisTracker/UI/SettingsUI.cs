using Dalamud.Interface.Components;
using ImGuiNET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BisTracker.UI
{
    internal static unsafe class SettingsUI
    {
        internal static void Draw()
        {
            ImGui.TextWrapped($"Here you can change some of the main settings for BisTracker.");

            bool ShowMateriaMeldingWindows = P.Config.ShowMateriaMeldingWindows;
            bool HighlightBisMateriaInMateriaMelder = P.Config.HighlightBisMateriaInMateriaMelder;

            ImGui.Separator();

            if (ImGui.CollapsingHeader("General Settings"))
            {
                if (ImGui.Checkbox("Show Materia Melding Menu Windows", ref ShowMateriaMeldingWindows))
                {
                    P.Config.ShowMateriaMeldingWindows = ShowMateriaMeldingWindows;
                    P.Config.Save();
                }
                ImGuiComponents.HelpMarker($"Draw the windows/UI edits tied to the Materia Melding window in game.");

                if (ShowMateriaMeldingWindows)
                {
                    if (ImGui.Checkbox("Highlight BiS Materia for BiS Pieces", ref HighlightBisMateriaInMateriaMelder))
                    {
                        P.Config.HighlightBisMateriaInMateriaMelder = HighlightBisMateriaInMateriaMelder;
                        P.Config.Save();
                    }
                    ImGuiComponents.HelpMarker($"Color the names of materia to be melded into the selected BiS gear piece.");
                }
            }
        }
    } 
}
