namespace PTBlog.Core.Domain.Royalty
{
    public class RoyaltyReportByMonthDto
    {
        public int Month { get; set; }
        public int Year { get; set; }
        public int NumberOfDraftPosts { get; set; } // số lượng bài đăng nháp
        public int NumberOfWaitingApprovalPosts { get; set; }// số lượng bài đang chờ duyệt
        public int NumberOfRejectedPosts { get; set; } // số lượng bài bị từ chối

        public int NumberOfUnpaidPublishPosts { get; set; } // số lượng bài đã đăng nhưng chưa thanh toán cho người đăng bài đó
        public int NumberOfPaidPublishPosts { get; set; } // số lượng bài đã đăng đã thanh toán cho người đăng bài đó rồi
        public int NumberOfPublishPosts { get; set; } // tổng số lượng bài đã đăng
    }
}
