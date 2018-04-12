using System;
using System.Collections.Generic;
using System.Text;

namespace Checkers
{
    public enum Color { Black, White}
    public enum Status { Captured, Active}
    public interface IPiece
    {
        IEnumerable<int> NormalMoves(IBoard board);
        IEnumerable<int> CapturingMoves(IBoard board);
        Status Status { get; }
        Color Color { get; }

        int Position { get;  }
        void Move(int destination);

    }
}
