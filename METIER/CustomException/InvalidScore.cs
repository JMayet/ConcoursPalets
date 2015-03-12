using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.CustomException
{
    public class InvalidScore : Exception
    {
        private int _board;
        private int[] _score;

        public InvalidScore(int board, int[] score)
        {
            this._board = board;
            this._score = score;
        }
    }
}
