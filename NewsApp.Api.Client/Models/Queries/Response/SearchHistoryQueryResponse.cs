using System;

namespace NewsApp.Api.Client
{
    public class SearchHistoryQueryResponse
    {
        public string Id { get; set; }
        public string SearchText { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
