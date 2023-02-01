using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    internal class Angle
    {
        private int gradus;
        private int minute;
        private int second;

        public int Gradus
        {
            get
            {
                return gradus;
            }
            set
            {
                if (value < 0)
                {
                    value = -value;
                }
                if (value + gradus > 360)
                {
                    value += gradus;
                    gradus = value % 360;
                }
                else
                {
                    gradus += value;
                }
            }
        }

        public int Minute
        {
            get
            {
                return minute;
            }
            set
            {
                if (value < 0)
                {
                    value = -value;
                }
                if (value + minute > 60)
                {
                    value += minute;
                    gradus += value / 60;
                    minute = value % 60;
                }
                else
                {
                    minute += value;
                }
            }
        }

        public int Second
        {
            get
            {
                return second;
            }
            set
            {
                if (value < 0)
                {
                    value = -value;
                }
                if (value > 60)
                {
                    minute += value / 60;
                    second += value % 60;
                }
                else
                {
                    second += value;
                }
            }
        }

        public Angle(int gradus, int minute, int second)
        {
            this.Second = second;
            this.Minute = minute;
            this.Gradus = gradus;
        }

        public double ToRadians()
        {
            return (gradus + (minute + second / 60) / 60) * Math.PI / 180;
        }
    }

}
