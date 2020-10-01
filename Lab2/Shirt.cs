using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Lab2
{
    class Shirt
    {
        String color;
        int size;
        string pattren;
        string slevee;

        public Shirt(string color, int size, string pattren, string slevee)
        {
            this.color = color;
            this.size = size;
            this.pattren = pattren;
            this.slevee = this.slevee;
        }

        public string Color { get => color; set => color = value; }
        public int Size { get => size; set => size = value; }
        public string Pattren { get => pattren; set => pattren = value; }
        public string Selevee { get => slevee; set => slevee = value; }

        public override string ToString()
        {
            return String.Format(" The color is {0} \n {1}is size of the shirt \n it look{2}\n  its {3} slevee,", color,size,pattren,slevee);
        }
    }

}
