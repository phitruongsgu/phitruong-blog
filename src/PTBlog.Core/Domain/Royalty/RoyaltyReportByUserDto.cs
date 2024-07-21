namespace PTBlog.Core.Domain.Royalty
{
    public class RoyaltyReportByUserDto
    {
        public Guid UserId { get; set; }
        public required string UserName { get; set; }
        public int NumberOfDraftPosts { get; set; }
        public int NumberOfWaitingApprovalPosts { get; set; }
        public int NumberOfRejectedPosts { get; set; }
        public int NumberOfUnpaidPublishPosts { get; set; }
        public int NumberOfPaidPublishPosts { get; set; }
        public int NumberOfPublishPosts { get; set; }

    }
}
