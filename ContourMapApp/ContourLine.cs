using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ContourMapApp
{
    internal class ContourLine
    {
        List<Vector3> points;
        Microsoft.Xna.Framework.Color color;
        VertexPositionColor[] verts;

        public List<Vector3> Points
        {
            get { return points; }
            set { points = value; }
        }

        public Microsoft.Xna.Framework.Color Color
        {
            get { return color; }
            set { color = value; }
        }

        public VertexPositionColor[] Verts
        {
            get { return verts; }
            set { verts = value; }
        }

        public ContourLine(Microsoft.Xna.Framework.Color c)
        {
            points = new List<Vector3>();
            color = c;
        }

        public void GeneVertList()
        {
            List<VertexPositionColor> vertList = new List<VertexPositionColor>();
            vertList.Add(new VertexPositionColor(points[0], color));
            for (int i = 1; i < points.Count; i++)
            {
                vertList.Add(new VertexPositionColor(points[i], color));
            }
            verts = vertList.ToArray();
        }
    }
}
