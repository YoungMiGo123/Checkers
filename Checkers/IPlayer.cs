using System;
using System.Collections.Generic;
using System.Text;

namespace Checkers
{
    interface IPlayer
    {
        string Name { get; }
        (int, int) GetMove();
    }
}
