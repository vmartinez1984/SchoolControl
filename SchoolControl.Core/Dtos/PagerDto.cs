using System.ComponentModel.DataAnnotations;

namespace SchoolControl.Core.Dtos
{
    public class PagerDto
    {
        public int TotalRecordsFiltered { get; set; }

        public int TotalRecords { get; set; }

        public object List { get; set; }

        public int PageCurrent { get; set; } = 1;

        [Range(10, 50)]
        public int RecordsPerPage { get; set; } = 10;
    }
}
