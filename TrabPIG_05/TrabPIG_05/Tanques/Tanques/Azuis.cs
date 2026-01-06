using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Numerics;

namespace Tanques
{
    class Azuis : TanqueBase
    {
        public Vermelhos alvo;

        public Azuis() : base()
        {
            pincel = new SolidBrush(Color.Blue);
            pincel2 = new SolidBrush(Color.DarkBlue);
            pincel3 = new SolidBrush(Color.Black);
            lapis = new Pen(Color.Blue, 1);
            lapis2 = new Pen(Color.Transparent, 1);
            mass = 5;
        }

        public void Seekreds(Vermelhos tr)
        {
            if (Vivo && tr != null && tr.Vivo)
            {
                if (Vector2.Distance(this.position, tr.getPosition()) < alcance)
                {
                    alvo = tr; seek = true; Disparo = true;
                    return;
                }
            }
            alvo = null; seek = false; Disparo = false;
        }

        public bool LevouTiroBlue(Disparar t) => RegistrarDano(t, t.TiroBlue == false);

        public override void update()
        {
            if (seek && alvo != null && mass > 1) navigate.seek(alvo.getPosition());
            else if (mass <= 1 && alvo != null) navigate.flee(alvo.getPosition());
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