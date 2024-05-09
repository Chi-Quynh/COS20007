using SplashKitSDK;
using System.Runtime.Intrinsics.X86;

namespace ShapeDrawer
{
    public class Program
    {
        private enum ShapeKind
        {
            Rectangle,
            Circle,
            Line
        }
        public static void Main()
        {
            
            ShapeKind kindToAdd = ShapeKind.Circle; 
            
            Drawing _drawing = new Drawing();


            Window window = new Window("Shape Drawer", 800, 600);
            do
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();
                _drawing.Draw();

                ///
                if (SplashKit.KeyDown(KeyCode.RKey))
                {
                    kindToAdd = ShapeKind.Rectangle;
                }
                else if (SplashKit.KeyDown(KeyCode.CKey)) { kindToAdd = ShapeKind.Circle; }
                else if (SplashKit.KeyDown(KeyCode.LKey)) { kindToAdd = ShapeKind.Line; }

                    ///
                    if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    Shape newShape;

                    if (kindToAdd == ShapeKind.Circle)
                    {
                        MyCircle newCircle = new MyCircle();
                        newShape = newCircle;
                    }
                    else if (kindToAdd == ShapeKind.Line)
                    {
                        MyLine newLine = new MyLine();
                        newShape = newLine;
                        newLine.Y2 = SplashKit.MouseY();
                    }
                    else
                    {
                        MyRectangle newRect = new MyRectangle();
                        newShape = newRect;
                    }
                    newShape.X = SplashKit.MouseX();
                    newShape.Y = SplashKit.MouseY();
                    _drawing.AddShape(newShape);

                }

                if (SplashKit.MouseClicked(MouseButton.RightButton))
                {
                    _drawing.SelectShapesAt(SplashKit.MousePosition());
                }


                if (SplashKit.KeyTyped(KeyCode.DeleteKey))
                    {
                    foreach (Shape s in _drawing.SelectedShapes)
                    {
                        _drawing.RemoveShape(s);
                    }
                }

                   


                    if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                {
                    _drawing.Background = SplashKit.RandomRGBColor(255);
                }

                
                
                SplashKit.RefreshScreen();


            } while (!window.CloseRequested);
        }

    }

    
}