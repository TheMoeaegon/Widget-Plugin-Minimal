using Microsoft.AspNetCore.Mvc;
using Nop.Web.Framework.Components;

namespace Nop.Plugin.Widgets.MyPlugin.Components;

public class WidgetMyPluginViewComponent : NopViewComponent
{

    #region Ctor
    public WidgetMyPluginViewComponent() { }

    #endregion

    #region Methods

    /// <returns>A task that represents the asynchronous operation</returns>
    public async Task<IViewComponentResult> InvokeAsync(string widgetZone, object additionalData)
    {
        return View("~/Plugins/Widgets.MyPlugin/Views/Index.cshtml");
    }

    #endregion
}