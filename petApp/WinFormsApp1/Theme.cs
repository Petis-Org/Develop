using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Theme
    {
        public static class ThemeColor
        {
            public static List<string> ColorList = new List<string>() { "#120061",
                                                                        "#6245E6",
                                                                        "#2B00E1",
                                                                        "#2A1D61",
                                                                        "#2000AD",};

            public static Color ChangeColorBrightness(Color color, double correctionFactor) {
                double red = color.R;
                double green = color.G;
                double blue = color.B;

                if (correctionFactor < 0) { 
                    correctionFactor = 1 + correctionFactor;
                    red *= correctionFactor;
                    blue *= correctionFactor;
                    green *= correctionFactor;
                }
                else {
                    red = (255 - red) * correctionFactor + red;
                    green = (255 - green) * correctionFactor + green;
                    blue = (255 - blue) * correctionFactor + blue;
                }

                return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
            }
        }
    }
}
