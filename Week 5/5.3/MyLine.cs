using SplashKitSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDrawer
{
    public class MyLine :Shape
    {
        private float _x2;
        private float _y2;


        public float Y2 { get { return _y2; } set { _y2 = value; } }



        public MyLine() : this(Color.Black, 0, 0,0,0)
        {

        }

        public MyLine( Color color, float x, float y,float x2, float y2)
        {
            X=x; Y=y; 
            _x2=x2;
            _y2=y2;

            Color = color;

        }

        public override void Draw()
        {
            if (Selected) { DrawOutline(); }
            SplashKit.DrawLine(Color, X, Y, _x2, _y2);
        }
        public override void DrawOutline()
        {
            SplashKit.FillCircle(Color, X, Y, 10);
            SplashKit.FillCircle(Color, _x2, _y2, 10);
        }
        public override bool IsAt(Point2D pt)
        {
            if (pt.X < X)
            {
                if (pt.Y < Y+5 && pt.Y > Y - 5)
                    return true;
            }
            return false;
        }

        public override void SaveTo(StreamWriter writer)
        {
            ExtensionMethods.WriteLine(writer, "Line");
            base.SaveTo(writer);
            ExtensionMethods.WriteLine(writer, _x2);
            ExtensionMethods.WriteLine(writer, _y2);
        }

        public override void LoadFrom(StreamReader reader)
        {
            base.LoadFrom(reader);
            _x2 = ExtensionMethods.ReadSingle(reader);
            _y2 = ExtensionMethods.ReadSingle(reader);
        }
    }
}
