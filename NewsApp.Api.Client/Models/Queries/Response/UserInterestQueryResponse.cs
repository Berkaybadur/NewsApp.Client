using System;

namespace NewsApp.Api.Client
{
    public class UserInterestQueryResponse
    {
        public string Id { get; set; }
        public string ChannelCategoryMapId { get; set; }
        public string UserId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
