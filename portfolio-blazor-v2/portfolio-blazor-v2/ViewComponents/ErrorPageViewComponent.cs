using Microsoft.AspNetCore.Mvc;
using MudBlazor;
using System.Reflection.Metadata;

namespace portfolio_blazor_v2.ViewComponents
{
    public class ErrorPageViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string title, string message, string icon = Icons.Material.Filled.Error)
        {
            var model = new ErrorPageModel
            {
                Title = title,
                Message = message,
                Icon = icon
            };
            return View(model);
        }
    }

    public class ErrorPageModel
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public string Icon { get; set; } = Icons.Material.Filled.Error;
    }
}
