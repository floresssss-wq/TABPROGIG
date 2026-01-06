using System;
using System.Numerics;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Tanques
{
    class Disparar
    {
        public Vector2 Pos { get; set; }
        public Vector2 Velo { get; set; }
        public bool TiroBlue { get; set; }
        private SizeF dim = new SizeF(8, 8);

        public Disparar(bool b)
        {
            TiroBlue = b;
            Pos = new Vector2(0, 0);
            Velo = new Vector2(2);
        }

        public void DisparoContraVermelho(Vermelhos tr)
        {
            Vector2 d = tr.getPosition() - Pos;
            Velo = Vector2.Normalize(d) * 8f; // Velocidade constante e direta
        }

        public void DisparoContraAzul(Azuis tb)
        {
            Vector2 d = tb.getPosition() - Pos;
            Velo = Vector2.Normalize(d) * 8f;
        }

        public void move() { Pos += Velo; }

        public RectangleF getHitbox() => new RectangleF(Pos.X - dim.Width / 2, Pos.Y - dim.Height / 2, dim.Width, dim.Height);

        public void draw(Graphics g)
        {
            g.ResetTransform();
            g.TranslateTransform(Pos.X, Pos.Y);
            g.FillEllipse(Brushes.Black, -dim.Width / 2, -dim.Height / 2, dim.Width, dim.Height);
            g.ResetTransform();
        }
    }
}