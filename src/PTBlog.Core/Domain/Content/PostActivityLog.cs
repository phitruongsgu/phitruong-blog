using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PTBlog.Core.Domain.Content
{
    [Table("PostActivityLogs")]
    public class PostActivityLog
    {
        [Key]
        public Guid Id { get; set; }
        public Guid PostId { get; set; }

        public PostStatus FromStatus { set; get; }

        public PostStatus ToStatus { set; get; }

        public DateTime DateCreated { get; set; }

        [MaxLength(500)]
        public string? Note { set; get; }

        public Guid UserId { get; set; }

        [MaxLength(250)]
        public string UserName { get; set; }
    }
}
