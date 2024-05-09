using SplashKitSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using System.ComponentModel.Design;

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
        
        public int ShapeCount { get { return _shapes.Count; } }
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

        public void Save(string filepath)
        {
            StreamWriter writer = new StreamWriter(filepath);
            try
            {
                ExtensionMethods.WriteColor(writer, _background);
                ExtensionMethods.WriteLine(writer, _shapes.Count);
                foreach (Shape s in _shapes)
                s.SaveTo(writer);
            }
            finally { writer.Close(); }

        }

        public void Load(string filepath) 
        { 
            StreamReader reader = new StreamReader(filepath);
            try
            {
                _background = ExtensionMethods.ReadColor(reader);

                int count = ExtensionMethods.ReadInteger(reader);
                _shapes.Clear();


                for (int i = 0; i < count; i++)
                {
                    Shape s;
                    string kind = ExtensionMethods.ReadLine(reader);
                    switch (kind)
                    {
                        case "Rectangle":
                            s = new MyRectangle();
                            break;
                        case "Circle":
                            s = new MyCircle();
                            break;
                        case "Line":
                            s = new MyLine();
                            break;
                        default:
                            throw new InvalidDataException("Unknow shape kinda: " + kind);
                    }
                    s.LoadFrom(reader);
                    AddShape(s);

                }
            }
            finally { reader.Close(); }


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