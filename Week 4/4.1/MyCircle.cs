using SplashKitSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDrawer
{
    public class MyCircle : Shape 
    {
        int _radius;

        public int Radius { get { return _radius; } set { _radius = value; } }    

        public MyCircle() :this(50,Color.Blue,0,0)
        {

        }

        public MyCircle(int radius, Color color, float x, float y)
        {
            Color = color;
            _radius = radius;
            X= x;
            Y= y;
        }

        public override void Draw()
        {
            if (Selected)
                DrawOutline();
            SplashKit.FillCircle(Color, X, Y, _radius);
        }
        public override void DrawOutline()
        {
            SplashKit.FillCircle(Color.Black, X-2,Y-2, _radius+2);
        }
        public override bool IsAt(Point2D pt)
        {
            if (pt.X < X + _radius/2 && pt.X > X - _radius / 2)
            {
                if (pt.Y < Y + _radius/2 && pt.Y > Y - _radius / 2)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
