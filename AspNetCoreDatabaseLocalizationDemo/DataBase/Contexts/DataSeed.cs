using System.Collections.Generic;
using AspNetCoreDatabaseLocalizationDemo.DataBase.Entities;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreDatabaseLocalizationDemo.DataBase.Contexts
{
    public static class DataSeed
    {
        public static ModelBuilder Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Language>().HasData(new List<Language>
            {
                new() {Id = 1, Name = "English (United States)", Culture = "en-US"},
                new() {Id = 2, Name = "French (France)", Culture = "fr-FR"},
                new() {Id = 3, Name = "German (Germany)", Culture = "de-DE"},
                new() {Id = 4, Name = "Arabic (Egyptian)", Culture = "ar-EG"},
            });

            modelBuilder.Entity<StringResource>().HasData(new List<StringResource>
            {
                new() {Id = 1, LanguageId = 1, Name = "home.index.welcome", Value = "Welcome"},
                new() {Id = 2, LanguageId = 2, Name = "home.index.welcome", Value = "Bienvenue"},
                new() {Id = 3, LanguageId = 3, Name = "home.index.welcome", Value = "Willkommen"},
                new() {Id = 4, LanguageId = 4, Name = "home.index.welcome", Value = "أهلا بك"},
            });

            return modelBuilder;
        }
    }
}
