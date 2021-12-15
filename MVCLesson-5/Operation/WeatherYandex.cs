using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace MVCLesson_5.Operation
{
    public class WeatherYandex
    {
        public string weather { get; set; }
        public void GetWeather()
        {
            var url = "https://yandex.ru/";
            HtmlWeb web = new HtmlWeb();
            var doc = web.Load(url);
            var node = doc.DocumentNode.SelectNodes("//div");
            for (int i = 0; i < node.Count; i++)
            {
                var a = node[i].GetClasses();
                foreach (var s in a)
                {
                    if (s.ToString() == "weather")
                    {
                        weather = node[i].InnerHtml;
                    }
                }
            }
        }
}
