using System;
using System.Collections.Generic;
using System.Text;

namespace Checkers
{
    class Piece : IPiece
    {
        virtual public Status Status => throw new NotImplementedException();

        virtual public Color Color => throw new NotImplementedException();

        virtual public int Position => throw new NotImplementedException();

        public IEnumerable<int> CapturingMoves(IBoard board)
        {
            throw new NotImplementedException();
        }

        virtual public void Move(int destination)
        {
            throw new NotImplementedException();
        }

        virtual public IEnumerable<int> NormalMoves(IBoard board)
        {
            throw new NotImplementedException();
        }
    }
}
