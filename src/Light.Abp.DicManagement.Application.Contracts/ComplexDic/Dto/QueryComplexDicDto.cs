using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace Light.Abp.DicManagement
{
    public class QueryComplexDicDto : PagedAndSortedResultRequestDto
    {
        [Required]
        public string Category { get; set; }

        public string Filter { get; set; }

    }
}