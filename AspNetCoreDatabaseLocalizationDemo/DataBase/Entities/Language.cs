using System.Collections.Generic;

namespace AspNetCoreDatabaseLocalizationDemo.DataBase.Entities
{
    public class Language
    {
        public Language()
        {
            StringResources = new HashSet<StringResource>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Culture { get; set; }
        public bool IsDefault { get; set; }

        public virtual ICollection<StringResource> StringResources { get; set; }
    }
}
