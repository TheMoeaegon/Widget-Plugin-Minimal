using Microsoft.AspNetCore.Mvc;
using Nop.Web.Framework.Components;

namespace Nop.Plugin.Widgets.PluginName.Components;

public class WidgetPluginNameViewComponent : NopViewComponent
{

    #region Ctor
    public WidgetPluginNameViewComponent() { }

    #endregion

    #region Methods

    /// <returns>A task that represents the asynchronous operation</returns>
    public async Task<IViewComponentResult> InvokeAsync(string widgetZone, object additionalData)
    {
        return View("~/Plugins/Widgets.PluginName/Views/Index.cshtml");
    }

    #endregion
}
