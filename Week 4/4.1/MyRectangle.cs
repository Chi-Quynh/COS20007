using SplashKitSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDrawer 
{
    public class MyRectangle : Shape
    {
        private int _width, _height;


        public MyRectangle() :this(Color.Green,0,0,100,100)
        {
        }
        public MyRectangle(Color color, float x, float y, int width, int height)
        {
            Color = color;
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }


        public int Width { get { return _width; } set { _width = value; } }
        public int Height { get { return _height; } set { _height = value; } }

        public override void Draw()
        {
            if (Selected) { DrawOutline(); }
            SplashKit.FillRectangle( Color, X, Y, Width, Height);
        }
        public override void DrawOutline()
        {
            SplashKit.FillRectangle(Color.Black, X-2, Y-2, Width+2, Height + 2);
        }

        public override bool IsAt(Point2D pt)
        {
            if (pt.X < X + Width && pt.X > X)
                {
                 if (pt.Y < Y + Height && pt.Y > Y)
                     {
                     return true;
                     }
                }
            return false;
        }

    }
}
