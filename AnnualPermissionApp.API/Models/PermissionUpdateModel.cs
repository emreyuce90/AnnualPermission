using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace PermissionApp.AnnualPermissionApp.API.Models
{
    public class PermissionUpdateModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Employee Id alanı boş geçilemez")]
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "İzin başlangı tarihi boş geçilemez")]
        public DateTime StartDate { get; set; }
        [Required(ErrorMessage = "İzin bitiş tarihi boş geçilemez")]
        public DateTime EndDate { get; set; }
        public IFormFile RequestPicture { get; set; }
        public string RequestPicturePath { get; set; }
         [Required(ErrorMessage ="İzin günü sayısı boş geçilemez")]
        public int DaysCount { get; set; }
        public string Description { get; set; }
    }
}