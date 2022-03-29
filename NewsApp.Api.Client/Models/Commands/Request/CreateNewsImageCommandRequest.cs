using MediatR;


namespace NewsApp.Api.Client
{
    public class CreateNewsImageCommandRequest : IRequest<CreateNewsImageCommandResponse>
    {
        public string NewsId { get; set; }
        public string ImagePath { get; set; }
        public int DisplayOrder { get; set; }

    }
}
