using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Singing_animals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        System.Media.SoundPlayer player = new System.Media.SoundPlayer(); 
        Random r = new Random();

        Animal[] a = new Animal[2];
        

        private void Form1_Load(object sender, EventArgs e)
        {
            Image pandaimg = Image.FromFile(@"C:\Users\Pc\source\repos\Singing animals\Singing animals\panda.jpg");
            Image monkeyimg = Image.FromFile(@"C:\Users\Pc\source\repos\Singing animals\Singing animals\monkey.png");
            Width = 1000;
            Height = 1000;
            
            a[0] = new Panda(100, 0, pandaimg);
            a[1] = new Monkey(400, 0, monkeyimg);
            timer.Start();
            player.SoundLocation = @"C:\Users\Pc\source\repos\Singing animals\Singing animals\bin\Debug\muzika.wav";
           

        }
       

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush cetka= new SolidBrush(Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256)));
            SolidBrush cetka1 = new SolidBrush(Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256)));
            SolidBrush cetka2 = new SolidBrush(Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256)));
            for (int i = 0; i < 2; i++) a[i].Crtaj(e.Graphics);
            
           
            e.Graphics.FillRectangle(cetka,0,800,200,100);
            e.Graphics.FillRectangle(cetka1, 0 , 900, 200, 100);
            e.Graphics.FillRectangle(cetka2, 0 , 700, 200, 100);

            e.Graphics.FillRectangle(cetka1, 200, 800, 200, 100);
            e.Graphics.FillRectangle(cetka2, 200, 900, 200, 100);
            e.Graphics.FillRectangle(cetka, 200, 700, 200, 100);

            e.Graphics.FillRectangle(cetka, 400, 800, 200, 100);
            e.Graphics.FillRectangle(cetka1, 400, 900, 200, 100);
            e.Graphics.FillRectangle(cetka2, 400, 700, 200, 100);

            e.Graphics.FillRectangle(cetka1, 600, 800, 200, 100);
            e.Graphics.FillRectangle(cetka2, 600, 900, 200, 100);
            e.Graphics.FillRectangle(cetka, 600, 700, 200, 100);

            e.Graphics.FillRectangle(cetka, 800, 800, 200, 100);
            e.Graphics.FillRectangle(cetka1, 800, 900, 200, 100);
            e.Graphics.FillRectangle(cetka2, 800, 700, 200, 100);




        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            a[0].Igraj(r.Next(20, 33),timer);
            a[1].Igraj(r.Next(20, 35),timer);


            Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player.Play();
        }
    }
}
