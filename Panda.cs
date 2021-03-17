﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Singing_animals
{
    class Panda: Animal
    {
        public Panda (int x, int y,Image img):base(x,y,img)
        { }
        public override void Crtaj(Graphics g)
        {
            g.DrawImage(img, x, y);
        }
       

        public override void Igraj(int brzina, System.Windows.Forms.Timer timer)
        {
            if (y >= 220)
            {
              

                Start();


            }
            else
                y += brzina;
        }

        public override void Start()
        {
            x = 100; y = 0;
            img = Image.FromFile(@"C:\Users\Pc\source\repos\Singing animals\Singing animals\panda.jpg");
        }
    }
}
