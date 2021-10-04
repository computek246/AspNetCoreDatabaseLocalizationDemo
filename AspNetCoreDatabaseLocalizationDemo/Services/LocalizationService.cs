using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreDatabaseLocalizationDemo.DataBase.Contexts;
using AspNetCoreDatabaseLocalizationDemo.DataBase.Entities;

namespace AspNetCoreDatabaseLocalizationDemo.Services
{
    public class LocalizationService : ILocalizationService
    {
        private readonly ApplicationDbContext _context;

        public LocalizationService(ApplicationDbContext context)
        {
            _context = context;
        }

        public StringResource GetStringResource(string resourceKey, int languageId)
        {
            return _context.StringResources.FirstOrDefault(x =>
                x.Name.Trim().ToLower() == resourceKey.Trim().ToLower()
                && x.LanguageId == languageId);
        }
    }
}
