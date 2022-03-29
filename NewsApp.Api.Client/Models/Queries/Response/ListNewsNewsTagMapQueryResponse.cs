using System;

namespace NewsApp.Api.Client
{
    public class ListNewsNewsTagMapQueryResponse
    {
        public string Id { get; set; }
        public string NewsId { get; set; }
        public string TagId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
