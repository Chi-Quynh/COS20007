using System;
using System.IO;
using SplashKitSDK;

namespace ShapeDrawer
{
    public static class ExtensionMethods
    {
        public static int ReadInteger(this StreamReader reader)
        {
            return Convert.ToInt32(reader.ReadLine());
        }
        public static float ReadSingle(this StreamReader reader)
        {
            return Convert.ToSingle(reader.ReadLine());
        }
        public static Color ReadColor(this StreamReader reader)
        {
            return Color.RGBColor(reader.ReadSingle(), reader.ReadSingle(),
            reader.ReadSingle());
        }

        public static string ReadLine(this StreamReader reader)
        {
            return Convert.ToString(reader.ReadLine());
        }
        public static void WriteColor(this StreamWriter writer, Color clr)
        {
            writer.WriteLine($"{clr.R}\n{clr.G}\n{clr.B}");
        }

        public static void WriteLine(this StreamWriter writer, object shapecount )
        {
            writer.WriteLine($"{shapecount}");
        }
    }
}
