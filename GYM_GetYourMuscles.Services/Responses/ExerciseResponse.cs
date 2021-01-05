using System;

namespace GYM_GetYourMuscles.Services.Responses
{
    public class ExerciseResponse
    {
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }
}
