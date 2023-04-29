using System.Collections.Generic;

namespace GoFPatterns.Structural {
    public interface ISite {
        string GetPage(int num);
    }

    public class Site: ISite {
        public string GetPage(int num) => "Это страница " + num;
    }

    public class SiteProxy: ISite {
        private readonly ISite _site;
        private Dictionary<int, string> cache;

        public SiteProxy(ISite site) {
            _site = site;
            cache = new Dictionary<int, string>();
        }

        public string GetPage(int num) {
            string page;
            if (cache.ContainsKey(num)) {
                page = "из кэша: " + cache[num];
            }
            else {
                page = _site.GetPage(num);
                cache.Add(num, page);
            }

            return page;
        }
    }
}