using System;
using System.Collections.Generic;
using System.Text;

namespace GYM_GetYourMuscles.Exception
{
    public class UnauthorizedException : BaseException
    {
        public UnauthorizedException(string error) : base(error)
        {
            _status = 401;
        }
    }
}
