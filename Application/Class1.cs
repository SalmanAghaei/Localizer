using Resources.Resources;

namespace Application
{
    public class ServiceTest
    {
        private readonly LocalizationService _localizationService;
        public ServiceTest(LocalizationService localizationService)
        {
            _localizationService = localizationService;
        }
        public string GetLocaliz(string key)=>_localizationService.GetLocalizedString(key); 
    }
}