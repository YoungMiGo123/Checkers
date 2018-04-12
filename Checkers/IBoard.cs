using System;
using System.Collections.Generic;
using System.Text;

namespace Checkers
{

    interface IBoard
    {
        IPiece Occupant(int position);
        IEnumerable<int> Pieces(Color color);
        void Move(IPiece piece, int destination);
        void RemoveCapturedPieces();
        void Promote(IPiece piece);

    }
}
 