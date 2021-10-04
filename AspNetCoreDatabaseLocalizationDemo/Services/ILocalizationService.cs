using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreDatabaseLocalizationDemo.DataBase.Entities;

namespace AspNetCoreDatabaseLocalizationDemo.Services
{
    public interface ILocalizationService
    {
        StringResource GetStringResource(string resourceKey, int languageId);
    }
}
