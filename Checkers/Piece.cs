using System;
using System.Collections.Generic;
using System.Text;

namespace Checkers
{
    public class Piece : IPiece
    {
        public Piece(Color color, int pos)
        {
            Status = Status.Active;
            Position = pos;
            Color = color;
        }
        public virtual Status Status { get; set; }
        public virtual Color Color { get; private set; }
        public virtual int Position { get; private set; }
        virtual public IEnumerable<int> CapturingMoves(IBoard board)
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
