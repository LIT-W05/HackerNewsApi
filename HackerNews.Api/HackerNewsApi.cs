using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HackerNews.Api
{
    public class HackerNewsApi
    {
        public IEnumerable<NewsStory> GetTopStories(int amount)
        {
            var client = new WebClient();
            string topIdsJson =
                client.DownloadString("https://hacker-news.firebaseio.com/v0/topstories.json?print=pretty");
            var ids = JsonConvert.DeserializeObject<IEnumerable<int>>(topIdsJson).Take(amount);
            return ids.Select(GetStory);
        }

        private NewsStory GetStory(int id)
        {
            var client = new WebClient();
            var json = client.DownloadString($"https://hacker-news.firebaseio.com/v0/item/{id}.json?print=pretty");
            return JsonConvert.DeserializeObject<NewsStory>(json);
        }
    }
}
