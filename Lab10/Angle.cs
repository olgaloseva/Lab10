using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Angle
    {
        int gradus;   
        int min;
        int sec;

        public int Gradus    
        {
            get
            {
                return gradus;
            }
            set
            {
                gradus = value % 360;
            }
        }

        public int Min
        {
            get
            {
                return min;
            }
            set
            {
                Gradus += value / 60;
                min = value % 60;
            }
        }

        public int Sec
        {
            get
            {
                return sec;
            }
            set
            {
                Min += value / 60;
                sec = value % 60;
            }
        }
        public Angle(int gradus, int min, int sec)      //конструктор
        {
            this.Gradus = gradus;
            this.Min = min;
            this.Sec = sec;
        }
        //Метод перевода угла в радианы
        public double ToRadians()           
        {
            double angleDec = ((double)(sec + min * 60 + gradus * 60 * 60))/3600;
            return angleDec*Math.PI/180;
        }
    }
}
