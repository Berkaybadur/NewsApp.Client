using System;

namespace NewsApp.UI.Models.ViewModel
{
    public class UserQueryResponseViewModel
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string AppId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
