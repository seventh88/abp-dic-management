using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace Light.Abp.DicManagement
{
    public class QueryDicDto : PagedAndSortedResultRequestDto
    {
        [Required]
        public string Category { get; set; }

        public string Filter { get; set; }
    }
}