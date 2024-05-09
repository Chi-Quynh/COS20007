using SplashKitSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ShapeDrawer
{
    public class Drawing
    {
        private readonly List<Shape> _shapes;
        private Color _background;

        
        public Drawing(Color background) 
        {
            _shapes = new List<Shape>();
            _background = background;
        }
        public Drawing() :this(Color.White) { }
        
        int ShapeCount { get { return _shapes.Count; } }
        public Color Background { get { return _background; } set { _background = value; } }

        public void Draw()
            {
            SplashKit.ClearScreen(_background);

            foreach (Shape shape in _shapes) { }

            foreach (Shape i in _shapes)
            {
                i.Draw();
            }


            }
        public void SelectShapesAt( Point2D pt)
        {
            foreach (Shape i in _shapes)
            {
               i.Selected = i.IsAt(pt);

            }
            
        }

        
        public List<Shape> SelectedShapes
        {
 
            
            get 
            {
                List<Shape> result = new List<Shape>();
                foreach (Shape i in _shapes)
                {
                    if (i.Selected == true)
                        result.Add(i);
                }
                return result; 
            }
        }





        public void AddShape(Shape s)
        {
            _shapes.Add(s);
        }

        public void RemoveShape(Shape s) 
        {
            _shapes.Remove(s);
        }

    }
}

/*
 * using SplashKitSDK;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
*/