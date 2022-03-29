﻿using MediatR;

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NewsApp.Api.Client
{
    public class CreateNewsCommandRequest : IRequest<CreateNewsCommandResponse>
    {
        public string ProviderNewsId { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
        public int DisplayOrder { get; set; }
        public string ChannelCategoryMapId { get; set; }
        public List<string> ImagePaths { get; set; }
        [JsonIgnore]
        public string UserId { get; set; }
    }
}
