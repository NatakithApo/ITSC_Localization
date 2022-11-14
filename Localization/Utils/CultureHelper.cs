using System.Globalization;

namespace Localization.Utils
{
    public class CultureHelper
    {
        public void SetCulter(HttpRequest request)
        {
            CultureInfo cultureInfo = new CultureInfo("en-US");
            if (request.Headers.ContainsKey("culture"))
            {
                cultureInfo = new CultureInfo(request.Headers["culture"]);
            }
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;
        }
    }
}
