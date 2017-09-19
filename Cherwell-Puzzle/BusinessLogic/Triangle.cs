using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cherwell_Puzzle.BusinessLogic
{
    public class Triangle
    {
        internal static ArrayList GetVertices(string row, string column)
        {
            ArrayList vertices = new ArrayList();

            int rowNum = int.Parse(row);
            int colNum = int.Parse(column);

            int v1x = 0;
            int v1y = 0;

            int v2x = 0;
            int v2y = 0;

            int v3x = 0;
            int v3y = 0;
            double test = colNum % 2;
            if (colNum % 2 == 0)
            {
                //Triangle has two top vertices 
                v1x = (colNum / 2) * 10;
                v1y = (rowNum - 1) * 10;
                if (v1x >= 10)
                    v2x = v1x - 10;
                else v2x = 0;
                v2y = v1y;

                //One bottom set of vertices 
                v3x = (colNum / 2) * 10;
                v3y = rowNum * 10;
            }
            else
            {
                //Triangle has one top set of vertices 
                v3x = ((colNum+1)/2) * 10;
                v3y = rowNum * 10;

                v1x = v3x - 10;
                v1y = v3y;

                v2x = v1x;
                v2y = v1y - 10;
            }
            vertices.Add("("+v1x + ", " + v1y+")");
            vertices.Add("("+v2x + ", " + v2y+")");
            vertices.Add("(" + v3x + ", " + v3y + ")");
            return vertices;
        }
    }
}