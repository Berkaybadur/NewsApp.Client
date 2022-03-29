using System;

namespace NewsApp.Api.Client
{
    public class ListTagQueryResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public int DisplayOrder { get; set; }

    }
}
