[assembly: XmlnsDefinition("https://schemas.the49.com/dotnet/2023/maui", "The49.Maui.MaterialSwitch")]


namespace The49.Maui.MaterialSwitch;

public static partial class AppHostBuilderExtensions
{
    public static MauiAppBuilder UseMaterialSwitch(this MauiAppBuilder builder, bool applyToAll = true)
    {
#if ANDROID
        builder.ConfigureMauiHandlers(handlers =>
        {
            if (applyToAll)
            {
                handlers.AddHandler<Switch, Handlers.MaterialSwitchHandler>();
            }
            else
            {
                handlers.AddHandler<MaterialSwitch, Handlers.MaterialSwitchHandler>();
            }
        });
#endif
        return builder;
    }
}