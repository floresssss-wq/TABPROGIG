using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Tanques
{
    class Obstaculo
    {
        protected Point position;
        protected Size area;
        protected SolidBrush pincel;
        protected int rotation;
        protected List<Obstaculo> listaObstaculos;

        public Obstaculo()
        {
            position = new Point(0, 100);
            rotation = 0;
            area = new Size(200, 20);
            pincel = new SolidBrush(Color.Gray);
            listaObstaculos = new List<Obstaculo>();
        }

        // Métodos de seleção de layouts (mantidos os originais para não quebrar a lógica)
        public List<Obstaculo> getLista1()
        {
            listaObstaculos.Clear();
            listaObstaculos.Add(new Obstaculo { position = new Point(250, 130), area = new Size(20, 200) });
            listaObstaculos.Add(new Obstaculo { position = new Point(550, 250), area = new Size(20, 170) });
            listaObstaculos.Add(new Obstaculo { position = new Point(850, 150), area = new Size(150, 20) });
            listaObstaculos.Add(new Obstaculo { position = new Point(850, 350), area = new Size(400, 20) });
            return listaObstaculos;
        }

        public List<Obstaculo> getLista2()
        {
            listaObstaculos.Clear();
            this.position = new Point(100, 0); this.area = new Size(20, 150); listaObstaculos.Add(this);
            listaObstaculos.Add(new Obstaculo { position = new Point(50, 350), area = new Size(150, 20) });
            listaObstaculos.Add(new Obstaculo { position = new Point(550, 150), area = new Size(20, 150) });
            listaObstaculos.Add(new Obstaculo { position = new Point(700, 70), area = new Size(150, 20) });
            listaObstaculos.Add(new Obstaculo { position = new Point(900, 250), area = new Size(20, 150) });
            return listaObstaculos;
        }

        public List<Obstaculo> getLista3()
        {
            listaObstaculos.Clear();
            this.position = new Point(150, 0); this.area = new Size(20, 250); listaObstaculos.Add(this);
            listaObstaculos.Add(new Obstaculo { position = new Point(350, 200), area = new Size(20, 250) });
            listaObstaculos.Add(new Obstaculo { position = new Point(550, 0), area = new Size(20, 250) });
            listaObstaculos.Add(new Obstaculo { position = new Point(750, 200), area = new Size(20, 250) });
            listaObstaculos.Add(new Obstaculo { position = new Point(950, 0), area = new Size(20, 250) });
            return listaObstaculos;
        }

        public List<Obstaculo> getLista4()
        {
            listaObstaculos.Clear();
            this.position = new Point(150, 70); this.area = new Size(20, 300); listaObstaculos.Add(this);
            listaObstaculos.Add(new Obstaculo { position = new Point(350, 300), area = new Size(20, 150) });
            listaObstaculos.Add(new Obstaculo { position = new Point(350, 0), area = new Size(20, 150) });
            listaObstaculos.Add(new Obstaculo { position = new Point(550, 100), area = new Size(30, 250) });
            listaObstaculos.Add(new Obstaculo { position = new Point(750, 0), area = new Size(20, 150) });
            listaObstaculos.Add(new Obstaculo { position = new Point(750, 300), area = new Size(20, 150) });
            listaObstaculos.Add(new Obstaculo { position = new Point(950, 70), area = new Size(20, 300) });
            return listaObstaculos;
        }

        public List<Obstaculo> getLista5()
        {
            listaObstaculos.Clear();
            this.position = new Point(150, 90); this.area = new Size(20, 100); listaObstaculos.Add(this);
            listaObstaculos.Add(new Obstaculo { position = new Point(200, 250), area = new Size(20, 100) });
            listaObstaculos.Add(new Obstaculo { position = new Point(300, 350), area = new Size(100, 20) });
            listaObstaculos.Add(new Obstaculo { position = new Point(450, 100), area = new Size(20, 100) });
            listaObstaculos.Add(new Obstaculo { position = new Point(500, 30), area = new Size(100, 20) });
            listaObstaculos.Add(new Obstaculo { position = new Point(550, 250), area = new Size(100, 20) });
            listaObstaculos.Add(new Obstaculo { position = new Point(700, 300), area = new Size(20, 100) });
            listaObstaculos.Add(new Obstaculo { position = new Point(850, 150), area = new Size(20, 100) });
            listaObstaculos.Add(new Obstaculo { position = new Point(950, 300), area = new Size(100, 20) });
            listaObstaculos.Add(new Obstaculo { position = new Point(650, 100), area = new Size(100, 20) });
            listaObstaculos.Add(new Obstaculo { position = new Point(10, 350), area = new Size(100, 20) });
            listaObstaculos.Add(new Obstaculo { position = new Point(950, 100), area = new Size(100, 20) });
            listaObstaculos.Add(new Obstaculo { position = new Point(250, 100), area = new Size(100, 20) });
            return listaObstaculos;
        }

        public Point getPosition() => position;
        public void setPosition(Point p) => position = p;
        public Size getAreaDeParede() => area;
        public void setAreaDeParede(Size s) => area = s;

        public virtual void drawParedes(Graphics g)
        {
            foreach (Obstaculo o in listaObstaculos)
            {
                Rectangle rect = new Rectangle(o.position, o.area);
                // 1. Preenchimento principal
                g.FillRectangle(new SolidBrush(Color.DimGray), rect);
                // 2. Bordas de betão
                g.DrawRectangle(new Pen(Color.Black, 2), rect);
                // 3. Detalhe interno para parecer 3D
                g.DrawRectangle(new Pen(Color.Gray, 1), rect.X + 2, rect.Y + 2, rect.Width - 4, rect.Height - 4);
            }
        }
    }
}