using System;
using System.Collections.Generic;
using System.Text;

namespace GYM_GetYourMuscles.Exception
{
    public class UnprocessableException : BaseException
    {
        public UnprocessableException(string error) : base(error)
        {
            _status = 422;
        }
    }
}
