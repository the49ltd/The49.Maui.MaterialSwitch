using Microsoft.Maui.Handlers;
using ASwitch = Google.Android.Material.MaterialSwitch.MaterialSwitch;

namespace The49.Maui.MaterialSwitch.Handlers;

public partial class MaterialSwitchHandler : SwitchHandler
{
    protected override ASwitch CreatePlatformView()
    {
        return new ASwitch(Context);
    }
}