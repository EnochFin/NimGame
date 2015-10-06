using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimGame
{
    class Board
    {
        private int row1;
        private int row2;
        private int row3;
        
        public Board()
        {
            this.row1 = 3;
            this.row2 = 5;
            this.row3 = 7;
        }

        public Board(int row1, int row2, int row3)
        {
            this.row1 = row1;
            this.row2 = row2;
            this.row3 = row3;
        }
        override
        public int GetHashCode()
        {
            return (3 * row1 + 5 * row2 + 7 * row3);
        }

        public bool isValid(Board b)
        {
            bool changeC = (this.row1 == b.row1 && this.row2 == b.row2 && this.row3 > b.row3);
            bool changeB = (this.row1 == b.row1 && this.row2 > b.row2 && this.row3 == b.row3);
            bool changeA = (this.row1 > b.row1 && this.row2 == b.row2 && this.row3 == b.row3);

            return (changeC || changeB || changeA);
        }
        override
        public string ToString()
        {
            return ("(" + row1 + ")(" + row2 + ")(" + row3 + ")");
        }

    }
}
