## What is Maui.MaterialSwitch?

The .NET MAUI MaterialSwitch plugin adds the ability to use android Material 3 switches instead of the `SwitchCompat` used as default.

## Getting Started

In order to use the plugin you need to call the extension method in your `MauiProgram.cs` file as follows:

```cs
using Plugin.ContextMenu;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		
		// Initialise the plugin
		builder.UseMauiApp<App>()
			.UseMaterialSwitch();

		// the rest of your logic...
	}
}
```

You also need to make sure your application's theme extends the Material3 theme. This mean you need a `Platforms/Android/Resources/values/styles.xml` file with the following content:

```xml
<?xml version="1.0" encoding="utf-8" ?>
<resources>
	<style name="Maui.MainTheme" parent="Theme.Material3.DayNight"></style>
</resources>
```

If you aleready have this file, just make sure the `Maui.MainTheme` style inherits the `Theme.Material3.DayNight` parent.

## Selectively use the MaterialSwitch

You can decide to not change the default `Switch` control. Call `UseMaterialSwitch` with `applyToAll` set to false.

```cs
	.UseMaterialSwitch(applyToAll: false)
```

You can then use the `MaterialSwitch` control selectively. Simply add the following namespace:

```xml
xmlns:the49="https://schemas.the49.com/dotnet/2023/maui"
```

Then use `<the49:MaterialSwitch />` alongside `<Switch />`.

## Notes

This will NOT change the switches on any other platform than Android

---

Made within The49
