# NopCommerce Widget Plugin Template

A `dotnet new` template for creating NopCommerce widget plugins.

## Installation

```bash
git clone https://github.com/TheMoeaegon/Widget-Plugin-Minimal.git
------ or --------  
git clone git@github.com:TheMoeaegon/Widget-Plugin-Minimal.git
cd Widget-Plugin-Minimal
dotnet new install .
```

## Usage

Navigate to your NopCommerce plugins directory:
```bash
cd /path/to/nopCommerce/src/Plugins
```

Create a new plugin:
```bash
dotnet new nop-plugin -n YourPluginName -o Nop.Plugin.Widgets.YourPluginName
```

Example:
```bash
dotnet new nop-plugin -n ProductSlider -o Nop.Plugin.Widgets.ProductSlider
```

This creates a folder `Nop.Plugin.Widgets.ProductSlider` with all files where `PluginName` is replaced with `ProductSlider`.

## Build and Run

```bash
cd Nop.Plugin.Widgets.YourPluginName
dotnet build
```

Plugin will be copied to `Presentation/Nop.Web/Plugins/Widgets.YourPluginName`

Run NopCommerce and install the plugin from Admin → Configuration → Local plugins

## What You Get

- Basic widget plugin structure
- View component
- Default view
- plugin.json configured
- Ready to build and install

## Uninstall Template

```bash
dotnet new uninstall /path/to/Widget-Plugin-Minimal
```

## Author

TheMoeaegon
