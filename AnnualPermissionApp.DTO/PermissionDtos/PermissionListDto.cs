using System;

namespace PermissionApp.AnnualPermissionApp.DTO.PermissionDtos
{
    public class PermissionListDto
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string RequestPicturePath { get; set; }
        public int DaysCount { get; set; }
        public string Description { get; set; }
    }



}