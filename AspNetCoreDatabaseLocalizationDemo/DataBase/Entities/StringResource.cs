namespace AspNetCoreDatabaseLocalizationDemo.DataBase.Entities
{
    public class StringResource
    {
        public int Id { get; set; }
        public int? LanguageId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        public virtual Language Language { get; set; }
    }
}
