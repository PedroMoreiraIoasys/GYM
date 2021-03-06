﻿using System;
using System.Collections.Generic;

namespace GYM_GetYourMuscles.Domain.Model
{
    public class User : BaseClass
    {
        public User()
        {
            Training = new List<WorkoutRoutine>();
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Birthday { get; set; }
        public string Height { get; set; }
        public string Role { get; set; }
        public IEnumerable<WorkoutRoutine> Training { get; set; }
}
}
