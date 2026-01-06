using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Numerics;

namespace Tanques
{
    class Vermelhos : TanqueBase
    {
        public Azuis alvoB;

        public Vermelhos() : base()
        {
            pincel = new SolidBrush(Color.Red);
            pincel2 = new SolidBrush(Color.DarkRed);
            pincel3 = new SolidBrush(Color.IndianRed);
            lapis = new Pen(Color.Red, 1);
            lapis2 = new Pen(Color.Transparent, 1);
            mass = 5;
        }

        public void Seekblues(Azuis tb)
        {
            if (Vivo && tb != null && tb.Vivo)
            {
                if (Vector2.Distance(this.position, tb.getPosition()) < alcance)
                {
                    alvoB = tb; seek = true; Disparo = true;
                    return;
                }
            }
            alvoB = null; seek = false; Disparo = false;
        }

        public bool LevouTiroRed(Disparar t) => RegistrarDano(t, t.TiroBlue == true);

        public override void update()
        {
            if (seek && alvoB != null && mass > 1) navigate.seek(alvoB.getPosition());
            else if (mass <= 1 && alvoB != null) navigate.flee(alvoB.getPosition());
            else navigate.wander();

            navigate.update();
            hitbox = new Rectangle((int)position.X - hitSize.Width / 2, (int)position.Y - hitSize.Height / 2, hitSize.Width, hitSize.Height);
        }

        public override void draw(Graphics g)
        {
            if (!Vivo) return;
            rotation = (float)Math.Atan2(velocity.Y, velocity.X) * 180 / (float)Math.PI;

            g.ResetTransform();
            g.TranslateTransform(position.X, position.Y);
            g.RotateTransform(rotation);

            Brush cor = mass >= 4 ? pincel : (mass == 3 ? pincel2 : pincel3);
            g.FillRectangle(Brushes.Gray, 0, -tamanhoCanhao.Height / 2, tamanhoCanhao.Width + 5, tamanhoCanhao.Height);
            g.DrawRectangle(Pens.Black, 0, -tamanhoCanhao.Height / 2, tamanhoCanhao.Width + 5, tamanhoCanhao.Height);
            g.FillRectangle(cor, -tamanhoCorpo.Width / 2, -tamanhoCorpo.Height / 2, tamanhoCorpo.Width, tamanhoCorpo.Height);
            g.DrawRectangle(Pens.Black, -tamanhoCorpo.Width / 2, -tamanhoCorpo.Height / 2, tamanhoCorpo.Width, tamanhoCorpo.Height);

            g.ResetTransform();
            if (alcanceVisivel) g.DrawEllipse(lapis, position.X - alcance / 2, position.Y - alcance / 2, alcance, alcance);
            desenharBarraVida(g);
        }
    }
}