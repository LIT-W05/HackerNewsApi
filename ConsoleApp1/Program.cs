using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackerNewsDotNet;
using HackerNewsDotNet.Model;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var api = new HackerNewsApi();
            IEnumerable<HackerNewsItem> stories = api.TopStories(20);
            foreach (var item in stories)
            {
                Console.WriteLine(item.Title + " " + item.Score);
            }

            Console.ReadKey(true);
        }
    }
}
