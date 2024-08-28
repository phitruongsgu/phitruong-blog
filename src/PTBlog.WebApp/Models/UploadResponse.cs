using System.Text.Json.Serialization;

namespace PTBlog.WebApp.Models
{
    public class UploadResponse
    {
        [JsonPropertyName("path")]
        public string Path { get; set; }
    }
}
