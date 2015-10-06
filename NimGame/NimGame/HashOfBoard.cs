using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimGame
{
    class HashOfBoards
    {
        public class meanOcc
        {
            double mean;
            int occ;

            public meanOcc(double mean, int occ)
            {
                this.mean = mean;
                this.occ = occ;
            }
            override
            public string ToString()
            {
                return ("{" + this.mean + "," + this.occ + "}");
            }
            public double getMean()
            {
                return this.mean;
            }
        }
        Dictionary<Board, meanOcc> boards = new Dictionary<Board, meanOcc>();

        public Dictionary<Board, meanOcc> getBoards()
        {
            return boards;
        }

        public HashOfBoards()
        {
            for (int row1 = 0; row1 <= 3; row1++)
            {
                for (int row2 = 0; row2 <= 5; row2++)
                {
                    for (int row3 = 0; row3 <= 7; row3++)
                    {
                        boards.Add(new Board(row1, row2, row3), new meanOcc(0.0, 0));
                    }

                }
            }
        }
        override
        public string ToString()
        {
            string retVal = "";
            foreach(KeyValuePair<Board, meanOcc> element in boards)
            {
                retVal +=(element.Key.ToString() + " : " + element.Value.ToString() + "\n");
            }
            return retVal;
        }
    }
}
