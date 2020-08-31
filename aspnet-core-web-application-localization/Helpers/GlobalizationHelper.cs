namespace aspnet_core_web_application_localization.Helpers
{
    using Microsoft.Extensions.Localization;

    public class GlobalizationHelper
    {
        private readonly IStringLocalizer<GlobalizationHelper> _localizer;
        public GlobalizationHelper(IStringLocalizer<GlobalizationHelper> localizer)
        {
            _localizer = localizer;
        }

        public string GetLocalizedString()
        {
            return _localizer["My localized string"];
        }
    }
}
