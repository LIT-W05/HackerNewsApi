﻿namespace HackerNews.Api
{
    public class NewsStory
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public int Score { get; set; }
        public string By { get; set; }
    }
}