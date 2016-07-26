using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Log4NetLibrary;
using Microsoft.Practices.ServiceLocation;

namespace MSSearchProvider
{
    public class WebHoseSearchProvider : ICustomSearch
    {
        private readonly ILogService _logService;

        public WebHoseSearchProvider()
        {
            _logService = ServiceLocator.Current.GetInstance<ILogService>();
        }

        public async Task<IList<SearchStory>> GetSearchStories(string searchKey)
        {
            string storyXml;
            Uri webHoseUrl = new Uri(String.Format("https://webhose.io/search?token=3b19b415-cf96-440d-bdeb-b190041f31b5&size=10&q=language%3A(english)&format=xml&q=thread.title%3A({0})", searchKey));
            using (var webClient = new WebClient())
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls11;
                webClient.Encoding = Encoding.UTF8;
                storyXml = await webClient.DownloadStringTaskAsync(webHoseUrl);
                
            }

            var list = ParseStoriesXmlToList(storyXml);

            return list;
        }

        private List<SearchStory> ParseStoriesXmlToList(string storyXml)
        {
            IList<SearchStory> stories = new List<SearchStory>();
            try
            {
                var reader = new StringReader(storyXml);
                var document = XDocument.Load(reader);
                
                var xElement = document.Element("results");
                if (xElement == null) return stories.ToList();
                var element = xElement.Element("posts");
                if (element == null) return stories.ToList();
                foreach (var itemXml in element.Descendants("thread"))
                {
                    var image = itemXml.Element("main_image");
                    if (image != null)
                    {
                        SearchStory searchStory = new SearchStory
                        {
                            Id = itemXml.Element("uuid").Value,
                            Title = itemXml.Element("title").Value,
                            Description = itemXml.Element("title_full").Value,
                            Site = itemXml.Element("site_full").Value,
                            HrefLink = new Uri(itemXml.Element("url").Value),
                            Image = image.Value,

                            PublishedDate = Convert.ToDateTime(itemXml.Element("published").Value).ToLongDateString()
                        };
                        stories.Add(searchStory);
                    }
                }

                return stories.ToList();
            }
            catch (Exception exception)
            {
                _logService.WriteLog(LogLevel.Error, exception.Message);
                return stories.ToList();
            }
            
            
        }
    }
}
