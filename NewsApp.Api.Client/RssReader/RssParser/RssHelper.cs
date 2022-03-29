using CodeHollow.FeedReader;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;

namespace NewsApp.Api.Client.RssReader.RssParser
{
    public class RssHelper
    {

        public static List<string> ParseImage(FeedItem feedItem)
        {
            List<string> imgUrls = new List<string>();
            HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();
            htmlDocument.LoadHtml(feedItem.Description);

            HtmlNodeCollection htmlNodes = htmlDocument.DocumentNode.SelectNodes("//img");

            if (htmlNodes != null)
            {
                foreach (HtmlNode node in htmlNodes)
                {
                    HtmlAttribute src = node.Attributes[@"src"];
                    imgUrls.Add(src.Value);
                }
            }


            return imgUrls;
        }

        public static List<string> ParseUrl(FeedItem feedItem)
        {
            List<string> imgUrls = new List<string>();
            HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();
            htmlDocument.LoadHtml(feedItem.Description);

            HtmlNodeCollection htmlNodes = htmlDocument.DocumentNode.SelectNodes("//a");

            if (htmlNodes != null)
            {
                foreach (HtmlNode node in htmlNodes)
                {
                    HtmlAttribute src = node.Attributes[@"href"];
                    imgUrls.Add(src.Value);
                }
            }


            return imgUrls;
        }

        public static string ParseImageEnclosure(Feed feed, int index)
        {
            List<string> imgUrls = new List<string>();
            HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();
            htmlDocument.LoadHtml(feed.OriginalDocument);

            HtmlNodeCollection htmlNodes = htmlDocument.DocumentNode.SelectNodes("//enclosure");

            if (htmlNodes != null)
            {
                foreach (HtmlNode node in htmlNodes)
                {
                    HtmlAttribute src = node.Attributes[@"url"];
                    imgUrls.Add(src.Value);
                }
            }
            return imgUrls[index];
        }

        public static string ParseLinkToId(string link)
        {
            string returnId = "";
            string[] linkArray = link.Split('-');
            foreach (var item in linkArray)
            {
                if (Char.IsDigit(Convert.ToChar(item.Substring(0, 1))))
                    returnId = ClearText(item, null);
            }
            return returnId;
        }
        public static List<CreateNewsCommandRequest> GenerateBaseFeedItem(Feed feed, string xmlPath)
        {
            int i = 0;
            List<CreateNewsCommandRequest> baseFeedItems = new List<CreateNewsCommandRequest>();
            foreach (var item in feed.Items)
            {

                List<string> imgUrls = new List<string>();
                List<string> clearUrls = new List<string>();
                imgUrls.AddRange(ParseImage(item));
                if (imgUrls.Count == 0 || imgUrls == null)
                {
                    imgUrls.Add(ParseImageEnclosure(feed, i));
                }
                var href = ParseUrl(item);

                clearUrls.AddRange(imgUrls);
                clearUrls.AddRange(href);

                CreateNewsCommandRequest baseFeedItem = new CreateNewsCommandRequest();
                if (string.IsNullOrEmpty(item.Id) || item.Id.Contains("http"))
                    baseFeedItem.ProviderNewsId = ParseLinkToId(item.Link);
                else
                {
                    baseFeedItem.ProviderNewsId = item.Id;
                }
                baseFeedItem.Title = ClearText(item.Title, null);
                baseFeedItem.Link = feed.Link;
                baseFeedItem.ImagePaths = imgUrls;
                baseFeedItem.Description = ClearText(item.Description, clearUrls);
                baseFeedItem.ChannelCategoryMapId = "62059faab34c10f51c97c9a9";
                baseFeedItem.Language = feed.Language;

                baseFeedItems.Add(baseFeedItem);
                i++;

            }
            return baseFeedItems;

        }
        public static string ClearText(string text, List<string>? clearUrls)
        {
            try
            {
                if (clearUrls != null && clearUrls.Count > 0)
                {
                    foreach (var clearUrl in clearUrls)
                    {
                        text = text.Replace(clearUrl, "");
                    }
                }

                return text.Replace("<a", "").Replace("&#46;", "").Replace("<p>", "").Replace("</p>", "").Replace("<a>", "").Replace("</a>", "").Replace("&#8217;", "").Replace("[&#8230;]", "")
                     .Replace("<a rel=", "").Replace("nofollow", "").Replace("href=", "").Replace(">", "").Replace('"', ' ').Replace("img src=", "").Replace("<", "").Replace("/", "").Replace("alt=", "").Replace("'", "");

            }
            catch (NullReferenceException ex)
            {
                return "Açıklama Bulunamadı";
            }
        }

    }
}
