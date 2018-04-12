using System;
using System.Collections.Generic;
using System.Text;

namespace Checkers
{
    interface IReferee
    {
        IPlayer Winner();
        bool IsDraw();
        void Play();

    }
}
