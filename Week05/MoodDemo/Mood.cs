using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodDemo
{
    class Mood
    {
        AColor red, green, blue;
        public Mood(double rStart, double rIncremente, double gStart, double gIncremente, double bStart, double bIncremente)
        {
            red = new AColor(rStart, rIncremente);
            green = new AColor(gStart, gIncremente);
            blue = new AColor(bStart, bIncremente);
        }
        public Color Color
        {
            get
            {
                return Color.FromArgb(red.Value, green.Value, blue.Value);
            }
        }
        class AColor
        {
            double value, increment;
            public AColor(double value, double increment)
            {
                this.value = value;
                this.increment = increment;
            }
            public int Value
            {
                get
                {
                    if (value + increment > 1 || value + increment < 0)
                        increment *= -1;
                        value += increment;
                    return (int)(value * 255);
                }
            }
        }
    }
}
