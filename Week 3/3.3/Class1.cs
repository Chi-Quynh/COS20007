using SplashKitSDK;
using System.Runtime.Intrinsics.X86;

namespace ShapeDrawer
{
    public class Program
    {
        public static void Main()
        {
            

            
            Drawing _drawing = new Drawing();


            Window window = new Window("Shape Drawer", 800, 600);
            do
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();
                _drawing.Draw();
                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    Shape myShape = new Shape();
                    myShape.X = SplashKit.MouseX();
                    myShape.Y = SplashKit.MouseY();
                    _drawing.AddShape(myShape);
                    
                    
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