using AutoMapper;
using PTBlog.Core.Domain.Content;
using System.ComponentModel.DataAnnotations;

namespace PTBlog.Core.Models.Content
{
    public class SeriesDto : SeriesInListDto
    {
        [MaxLength(250)]
        public string? SeoDescription { get; set; }

        [MaxLength(250)]
        public string? Thumbnail { set; get; }

        public string? Content { get; set; }

        public class AutoMapperProfiles : Profile
        {
            public AutoMapperProfiles()
            {
                CreateMap<Series, SeriesDto>();
            }
        }
    }
}
