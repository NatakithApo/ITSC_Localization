using Localization.Localization;
using Localization.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System.Globalization;

namespace Localization.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IStringLocalizer<Resource> _localizer;
        private readonly CultureHelper _cultureHelper;

        public WeatherForecastController(
            IStringLocalizer<Resource> localizer,
            CultureHelper culture
            )
        {
            _localizer = localizer;
            _cultureHelper = culture;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public string Get()
        {
            _cultureHelper.SetCulter(Request);

            //throw new Exception(_localizer["HELLO"]);

            return _localizer["HELLO"];
        }
    }
}