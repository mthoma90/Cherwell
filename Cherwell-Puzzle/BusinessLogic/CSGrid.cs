using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cherwell_Puzzle.BusinessLogic
{
    public class CSGrid
    {

        public enum Rows
        {
            A = 1,
            B = 2,
            C = 3,
            D = 4,
            E = 5,
            F = 6
        };
        public enum Columns
        {
            col1 = 1,
            col2 = 2,
            col3 = 3,
            col4 = 4,
            col5 = 5,
            col6 = 6,
            col7 = 7,
            col8 = 8,
            col9 = 9,
            col10 = 10,
            col11 = 11,
            col12 = 12
        }

        internal static string GetRow(Dictionary<string, int> vertices)
        {
            string maxKey = vertices.Keys.Max();
            int max = vertices[maxKey];

            int rowNum = max / 10;
            string row = Enum.GetName(typeof(Rows), rowNum);
            return row;
        }
        
        internal static string GetColumn(Dictionary<string, int> vertices)
        {
            Dictionary<string, int> xVertices = new Dictionary<string, int>();
            foreach (var item in vertices)
            {
                if (item.Key.Contains("x"))
                {
                    xVertices.Add(item.Key, item.Value);
                }
            }
           //Get duplicate X vertices 
            var dupX = xVertices.GroupBy(x => x.Value).Where(x => x.Count() > 1).ToArray();
            
            int maxX = xVertices.Values.Max();
            var maxDupX = dupX.First().Key;
            int colNum = 1;
            string minKey = vertices.Keys.Min();

            if (maxDupX == maxX)//column is in an even column
                colNum = (maxX / 10) * 2;
            else if (maxDupX != maxX)//column is in an odd column.
                colNum = ((maxX / 10) * 2) - 1;

            string thisCol = Enum.GetName(typeof(Columns), colNum);
            return thisCol;
        }
    }
}