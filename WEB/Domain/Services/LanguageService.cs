using Domain.DbContexts;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Services
{
    public interface ILanguageService
    {
        List<Language> GetListLanguages();
        Language GetLanguage(string culture);
        void SetLanguage(Language language);
        void SetLanguage(string culture);
        JObject GetResource(string culture);
        JObject GetResource();
        void SetResource(string culture);
        void SetResource(JObject resource);
    }

    public class LanguageService : ILanguageService
    {
        private ApplicationDbContext  _context;

        public LanguageService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Language> GetListLanguages()
        {
            CommonUtil.Languages = _context.Languages.AsNoTracking().Where(x => x.IsDeleted == false && x.IsEnabled == true).ToList();

            return CommonUtil.Languages;
        }

        public Language GetLanguage(string culture)
        {
            var language = _context.Languages.AsNoTracking().First(x => x.IsEnabled == true && x.IsDeleted == false && x.Culture.Equals(culture)) ??
                           _context.Languages.AsNoTracking().First(x => x.IsEnabled == true && x.IsDeleted == false && x.IsDefault == true);
            CommonUtil.CurrentLanguage = language;

            if (CommonUtil.Resource == null) SetResource(culture);

            return language;
        }

        public void SetLanguage(Language language)
        {
            CommonUtil.CurrentLanguage = language;
        }

        public void SetLanguage(string culture)
        {
            var language = _context.Languages.AsNoTracking().First(x => x.IsEnabled == true && x.IsDeleted == false && x.Culture.Equals(culture));
            CommonUtil.CurrentLanguage = language;
        }

        public JObject GetResource(string culture)
        {
            var resourceObject = new JObject();

            var query = from lt in _context.LanguageTexts
                        join la in _context.Languages on lt.LanguageId equals la.Id
                        where la.IsDeleted == false && lt.IsDeleted == false && la.IsEnabled == true && la.Culture.Equals(culture)
                        select lt;

            foreach (var lt in query)
            {
                resourceObject.Add(lt.Caption, lt.Value);
            }
            CommonUtil.Resource = resourceObject;

            return resourceObject;
        }

        public JObject GetResource()
        {
            return CommonUtil.Resource;
        }

        public void SetResource(string culture)
        {
            var resourceObject = new JObject();

            var query = from lt in _context.LanguageTexts
                        join la in _context.Languages on lt.LanguageId equals la.Id
                        where la.IsDeleted == false && lt.IsDeleted == false && la.IsEnabled == true && la.Culture.Equals(culture)
                        select lt;

            foreach (var lt in query)
            {
                resourceObject.Add(lt.Caption, lt.Value);
            }
            CommonUtil.Resource = resourceObject;
        }

        public void SetResource(JObject resource)
        {
            CommonUtil.Resource = resource;
        }
    }

    public static class CommonUtil
    {
        public static List<Language> Languages { get; set; }
        public static Language CurrentLanguage { get; set; }
        public static JObject Resource { get; set; }

        public static string ResourceValue(string caption)
        {
            try
            {
                return Resource[caption].HasValues ? caption : Resource[caption].Value<string>();
            }
            catch (Exception)
            {
                return caption;
            }
        }
    }
}
