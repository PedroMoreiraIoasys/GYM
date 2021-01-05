using System;

namespace GYM_GetYourMuscles.Services.Requests
{
    public class SignRequest
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Birthday { get; set; }
        public string Height { get; set; }
    }
}
