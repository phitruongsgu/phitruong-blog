namespace PTBlog.Core.Models.System
{
    public class ChangeMyPasswordRequest
    {
        public string OldPassword { get; set; }

        public string NewPassword { get; set; }
    }
}
