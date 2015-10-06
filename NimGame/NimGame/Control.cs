using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimGame
{
    class Control
    {
        public static List<Board> getPossibleMoves(Board start, Dictionary<Board, HashOfBoards.meanOcc> boards)
        {
            //a = d b = e c > f
            //a = d b > e c = f
            //a > d b = e c = f
            List<Board> retVal = new List<Board>();
            foreach (KeyValuePair<Board, HashOfBoards.meanOcc> element in boards)
            {
                if (start.isValid(element.Key)){
                    retVal.Add(element.Key);
                }
            }

            return retVal;
        }
    }
}
