using System;
using System.Collections;

namespace GYM_GetYourMuscles.Exception
{
    public class BaseException : System.Exception
    {
        public string _error { get; set; }
        public int _status { get; set; }

        public BaseException(string error)
        {
            _error = error;
        }
    }
}
