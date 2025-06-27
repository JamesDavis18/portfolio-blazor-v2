using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Options;
using System.Reflection.Metadata.Ecma335;

namespace portfolio_blazor_v2.ViewComponents
{
    public class CultureSwitchViewComponent : ViewComponent
    {
        private readonly IOptions<RequestLocalizationOptions> _localizationOptions;
        public CultureSwitchViewComponent(IOptions<RequestLocalizationOptions> localizationOptions) =>
            this._localizationOptions = localizationOptions;

        public IViewComponentResult Invoke()
        {
            var cultureFeature = HttpContext.Features.Get<IRequestCultureFeature>();
            var model = new CultureSwitcherModel
            {
                SupportedCulteres = _localizationOptions.Value.SupportedCultures.ToList(),
                CurrentUICulture = cultureFeature.RequestCulture.UICulture
                //CurrentCulture = cultureFeatures?.RequestCulture.Culture.Name,
                //AvailableCultures = _localizationOptions.Value.SupportedCultures.Select(c => c.Name).ToList()
            };
            return View(model);
        }
    }
}
