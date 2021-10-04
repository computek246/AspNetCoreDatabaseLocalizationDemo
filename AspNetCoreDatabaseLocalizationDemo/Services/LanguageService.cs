using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreDatabaseLocalizationDemo.DataBase.Contexts;
using AspNetCoreDatabaseLocalizationDemo.DataBase.Entities;

namespace AspNetCoreDatabaseLocalizationDemo.Services
{
    public class LanguageService : ILanguageService
    {
        private readonly ApplicationDbContext _context;

        public LanguageService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Language> GetLanguages()
        {
            return _context.Languages.ToList();
        }

        public Language GetLanguageByCulture(string culture)
        {
            return _context.Languages.FirstOrDefault(x =>
                x.Culture.Trim().ToLower() == culture.Trim().ToLower());
        }

        public CultureInfo[] GetCultures()
        {
            return _context.Languages.ToList().Select(x => new CultureInfo(x.Culture)).ToArray();
        }
    }
}
