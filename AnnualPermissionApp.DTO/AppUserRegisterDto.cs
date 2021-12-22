using System;

namespace AnnualPermissionApp.DTO{
    public class AppUserRegisterDto{
        public string Username { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime EnterDate { get; set; }
        public string Title { get; set; }
    }
}