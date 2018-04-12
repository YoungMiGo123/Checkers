﻿using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System.Linq;

namespace Checkers.Test
{
    [TestFixture]
    class Tests
    {
       [Test]
       public void ABoardHas12BlackAnd12WhitePieces()
        {
            Board b = new Board();
            int blackCount = b.Pieces(Color.Black).Count();
            int WhiteCount = b.Pieces(Color.White).Count();
            Assert.That(blackCount == 12);
            Assert.That(WhiteCount == 12);
        }
    }
}
