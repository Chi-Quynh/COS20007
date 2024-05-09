using SplashKitSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDrawer
{
    public abstract class Shape
    {
        private Color _color;
        private float _x, _y;
        private bool _selected;

        public Shape()
        {
            _color = Color.Yellow;
            _x = 0;
            _y = 0;
            _selected = false;
        }

        public Color Color
        {
            get { return _color; }
            set { _color = value; }
        }
        public float X
        {
            get { return _x; }
            set { _x = value; }
        }
        public float Y
        {
            get { return _y; }
            set { _y = value; }
        }


        public abstract void Draw();

        public abstract void DrawOutline();

        public abstract bool IsAt(Point2D pt);


        public bool Selected
        {
            get { return _selected; }
            set { _selected = value; }
        }



    }
}
