namespace PTBlog.Core.Models.System
{
    public class RoleClaimsDto
    {
        public required string Type { get; set; }
        public required string Value { get; set; }
        public string? DisplayName { get; set; }
        public bool Selected { get; set; }
    }
}
