using SplashKitSDK;
using System.Runtime.Intrinsics.X86;

namespace ShapeDrawer
{
    public class Program
    {
        public static void Main()
        {
            Shape myShape;

            myShape = new Shape();


            Window window = new Window("Shape Drawer", 800, 600);
            do
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();
                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    myShape.X = SplashKit.MouseX();
                    myShape.Y = SplashKit.MouseY();
                }

                if (myShape.IsAt(SplashKit.MousePosition()) && SplashKit.KeyTyped(KeyCode.SpaceKey) )
                    myShape.Color = SplashKit.RandomRGBColor(255);

                myShape.Draw();

                SplashKit.RefreshScreen();


            } while (!window.CloseRequested);
        }

    }

    
}