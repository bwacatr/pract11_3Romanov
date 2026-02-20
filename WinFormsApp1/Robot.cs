using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class Robot
    {
     
        private int kollife;

        public int GetLife()
        {
            return kollife;
        }

        public void SetLife(int a)
        {
            kollife = a;
        }

        public void Kol(int start, Robot[] mod)
        {
            if (start <= 0)
                return;
            double diff = start - this.kollife;
            double percent = (diff / (double)start) * 100;

            if (percent >= 50)
            {
                foreach (var a in mod)
                {
                    a.kollife += 30;

                }

            }
            else if (percent >= 30)
            {
                foreach (var a in mod)
                {
                    a.kollife += 20;
                }
            }
        }

        public void min(int a)
        {
            kollife = a;
            kollife = (int)kollife / 2;
        }

    }

}
