using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Drawing;

namespace Tanques
{
    class Arena
    {
        private Size area;
        public int numeroDeTanques, opcao;
        private bool start;
        private List<Azuis> tblues;
        private List<Vermelhos> treds;
        private List<Obstaculo> obstaculos;
        private Obstaculo paredes;
        private List<Disparar> tirosB, tirosR;
        private List<Region> listParedes;
        private static Arena instancia = null;

        private Arena(Size d)
        {
            opcao = 0; area = d;
            listParedes = new List<Region>();
            numeroDeTanques = 5;
            tirosB = new List<Disparar>(); tirosR = new List<Disparar>();
            tblues = new List<Azuis>(); treds = new List<Vermelhos>();
            paredes = new Obstaculo(); obstaculos = new List<Obstaculo>();
            criarTanque();
        }

        public static Arena GetInstancia(Size d) { if (instancia == null) instancia = new Arena(d); return instancia; }

        public void criarTanque()
        {
            tblues.Clear(); treds.Clear(); tirosB.Clear(); tirosR.Clear();
            for (int i = 1; i <= numeroDeTanques; i++)
            {
                Azuis b = new Azuis(); b.setPosition(new Vector2(area.Width - 100, 100 + (i * 70))); b.ID = i; tblues.Add(b);
                Vermelhos tr = new Vermelhos(); tr.setPosition(new Vector2(100, 100 + (i * 70))); tr.ID = i; treds.Add(tr);
            }
        }

        public void defineArena(int n)
        {
            opcao = n; CriarParedes(opcao);
            listParedes.Clear();
            foreach (Obstaculo o in obstaculos) listParedes.Add(new Region(new Rectangle(o.getPosition(), o.getAreaDeParede())));
        }

        public void draw(Graphics g)
        {
            g.Clear(Color.WhiteSmoke);
            Pen penGrade = new Pen(Color.FromArgb(20, Color.Black), 1);
            for (int x = 0; x < area.Width; x += 50) g.DrawLine(penGrade, x, 0, x, area.Height);
            for (int y = 0; y < area.Height; y += 50) g.DrawLine(penGrade, 0, y, area.Width, y);
            paredes.drawParedes(g);
            foreach (var tb in tblues) if (tb.Vivo) tb.draw(g);
            foreach (var tr in treds) if (tr.Vivo) tr.draw(g);
            foreach (var t in tirosB) t.draw(g);
            foreach (var t in tirosR) t.draw(g);
        }

        public void move()
        {
            foreach (var tb in tblues) if (tb.Vivo) { AplicarForcas(tb, tblues.Cast<Boid>().ToList(), true); tb.update(); }
            foreach (var tr in treds) if (tr.Vivo) { AplicarForcas(tr, treds.Cast<Boid>().ToList(), false); tr.update(); }

            // Atualizar e remover balas se baterem em paredes ou saírem do ecrã
            for (int i = tirosB.Count - 1; i >= 0; i--)
            {
                tirosB[i].move();
                if (BateuParede(tirosB[i].getHitbox()) || ForaDaTela(tirosB[i].Pos)) tirosB.RemoveAt(i);
            }
            for (int i = tirosR.Count - 1; i >= 0; i--)
            {
                tirosR[i].move();
                if (BateuParede(tirosR[i].getHitbox()) || ForaDaTela(tirosR[i].Pos)) tirosR.RemoveAt(i);
            }
        }

        private bool BateuParede(RectangleF hitbox) => listParedes.Any(p => p.IsVisible(hitbox));
        private bool ForaDaTela(Vector2 p) => p.X < 0 || p.X > area.Width || p.Y < 0 || p.Y > area.Height;

        private void AplicarForcas(TanqueBase t, List<Boid> equipa, bool ehAzul)
        {
            Vector2 vSeparacao = separacao(t) * 1.5f;
            // Força de avanço mais suave para permitir curvas aleatórias
            float alvoX = ehAzul ? area.Width * 0.3f : area.Width * 0.7f;
            Vector2 vAvanco = (new Vector2(alvoX, area.Height / 2) - t.getPosition()) / 150;

            t.setVelocity(t.getVelocity() + vSeparacao + vAvanco);
            ricochete(t);
            ricocheteParedes(t);
        }

        private Vector2 separacao(Boid boid)
        {
            Vector2 c = Vector2.Zero;
            foreach (Azuis b in tblues) if (boid != b && Vector2.Distance(boid.getPosition(), b.getPosition()) < 45) c -= (b.getPosition() - boid.getPosition());
            foreach (Vermelhos r in treds) if (boid != r && Vector2.Distance(boid.getPosition(), r.getPosition()) < 45) c -= (r.getPosition() - boid.getPosition());
            return c;
        }

        private bool TemLinhaDeVisao(Vector2 p1, Vector2 p2)
        {
            // Verifica 10 pontos entre o atirador e o alvo para ver se há paredes
            for (float i = 0.1f; i < 1.0f; i += 0.1f)
            {
                Vector2 check = Vector2.Lerp(p1, p2, i);
                if (listParedes.Any(r => r.IsVisible(check.X, check.Y))) return false;
            }
            return true;
        }

        public void acao()
        {
            foreach (var tb in tblues)
            {
                for (int i = tirosR.Count - 1; i >= 0; i--) if (tb.LevouTiroBlue(tirosR[i])) tirosR.RemoveAt(i);
                foreach (var tr in treds)
                {
                    tb.Seekreds(tr);
                    if (tb.Disparo && tr.Vivo && tb.PodeDisparar() && TemLinhaDeVisao(tb.getPosition(), tr.getPosition()))
                    {
                        tirosB.Add(new Disparar(true) { Pos = tb.getPosition() });
                        tirosB.Last().DisparoContraVermelho(tr);
                        tb.ResetRecarga();
                    }
                }
            }
            foreach (var tr in treds)
            {
                for (int i = tirosB.Count - 1; i >= 0; i--) if (tr.LevouTiroRed(tirosB[i])) tirosB.RemoveAt(i);
                foreach (var tb in tblues)
                {
                    tr.Seekblues(tb);
                    if (tr.Disparo && tb.Vivo && tr.PodeDisparar() && TemLinhaDeVisao(tr.getPosition(), tb.getPosition()))
                    {
                        tirosR.Add(new Disparar(false) { Pos = tr.getPosition() });
                        tirosR.Last().DisparoContraAzul(tb);
                        tr.ResetRecarga();
                    }
                }
            }
        }

        // Restantes métodos (restart, setVida, etc.) mantêm-se iguais...
        public void CriarParedes(int n) { switch (n) { case 1: obstaculos = paredes.getLista1(); break; case 2: obstaculos = paredes.getLista2(); break; case 3: obstaculos = paredes.getLista3(); break; case 4: obstaculos = paredes.getLista4(); break; case 5: obstaculos = paredes.getLista5(); break; default: obstaculos = paredes.getLista1(); break; } }
        private void ricochete(Boid tq) { Vector2 pos = tq.getPosition(), vel = tq.getVelocity(); if (pos.X > area.Width) { pos.X = area.Width; vel.X *= -1; } else if (pos.X < 0) { pos.X = 0; vel.X *= -1; } if (pos.Y > area.Height) { pos.Y = area.Height; vel.Y *= -1; } else if (pos.Y < 0) { pos.Y = 0; vel.Y *= -1; } tq.setPosition(pos); tq.setVelocity(vel); }
        private void ricocheteParedes(Boid boid) { foreach (Region o in listParedes) if (o.IsVisible(boid.getHitbox())) boid.setVelocity(boid.getVelocity() * -1.5f); }
        public void checkVida() { treds.RemoveAll(t => !t.Vivo); tblues.RemoveAll(t => !t.Vivo); }
        public void restart() { criarTanque(); start = false; }
        public void setAlcanceVisivel(bool b) { treds.ForEach(t => t.AlcanceVisivel = b); tblues.ForEach(t => t.AlcanceVisivel = b); }
        public bool Start { get => start; set => start = value; }
        public Size Area { get => area; set => area = value; }
    }
}