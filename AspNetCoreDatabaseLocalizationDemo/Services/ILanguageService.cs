using System.Collections.Generic;
using System.Globalization;
using AspNetCoreDatabaseLocalizationDemo.DataBase.Entities;

namespace AspNetCoreDatabaseLocalizationDemo.Services
{
    public interface ILanguageService
    {
        IEnumerable<Language> GetLanguages();
        Language GetLanguageByCulture(string culture);
        CultureInfo[] GetCultures();
    }
}
