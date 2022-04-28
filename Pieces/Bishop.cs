﻿using System;
using System.Collections.Generic;
using System.Text;
using PointLibrary;
using Interfaces;

namespace Pieces
{
    public class Bishop : Piece
    {
        public Bishop(PieceColors color, Point currentPosition, IChessBoard<Piece> board) : base(color, currentPosition, board)
        {
            if (IsWhite())
            {
                FENNotation = 'B';
            }
            else
            {
                FENNotation = 'b';
            }
        }
        public override List<Point> PossibleMoves()
        {
            List<Point> moves = new List<Point>();

            var directions = new[] { new Point(1, 1), new Point(-1, 1), new Point(-1, -1), new Point(1, -1)};
            Point currentPoint = CurrentPosition + new Point(1, 1);
            while (currentPoint.IsInside() && owningBoard[currentPoint] is EmptyPiece)
            {
                moves.Add(currentPoint);
                currentPoint += new Point(1, 1);
            }
            if (currentPoint.IsInside() && owningBoard[currentPoint].IsWhite() != IsWhite())
            {
                moves.Add(currentPoint);
            }


            currentPoint = CurrentPosition + new Point(1, -1);
            while (currentPoint.IsInside() && owningBoard[currentPoint] is EmptyPiece)
            {
                moves.Add(currentPoint);
                currentPoint += new Point(1, -1);
            }
            if (currentPoint.IsInside() && owningBoard[currentPoint].IsWhite() != IsWhite())
            {
                moves.Add(currentPoint);
            }

            currentPoint = CurrentPosition + new Point(-1, -1);
            while (currentPoint.IsInside() && owningBoard[currentPoint] is EmptyPiece)
            {
                moves.Add(currentPoint);
                currentPoint += new Point(-1, -1);
            }
            if (currentPoint.IsInside() && owningBoard[currentPoint].IsWhite() != IsWhite())
            {
                moves.Add(currentPoint);
            }

            currentPoint = CurrentPosition + new Point(-1, 1);
            while (currentPoint.IsInside() && owningBoard[currentPoint] is EmptyPiece)
            {
                moves.Add(currentPoint);
                currentPoint += new Point(-1, 1);
            }
            if (currentPoint.IsInside() && owningBoard[currentPoint].IsWhite() != IsWhite())
            {
                moves.Add(currentPoint);
            }


            return moves;
        }
    }
}
