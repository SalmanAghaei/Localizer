﻿using Microsoft.Extensions.Localization;
using System.Reflection;

namespace Resources.Resources
{
    public class LocalizationService
    {
        private readonly IStringLocalizer _stringLocalizer;
        public LocalizationService(IStringLocalizerFactory factory)
        {
            var type = typeof(ApplicationResource);
            var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName!);
            _stringLocalizer = factory.Create("ApplicationResource", assemblyName.Name);
        }
        public LocalizedString GetLocalizedString(string key)
        {
            return _stringLocalizer[key];
        }
    }
}
