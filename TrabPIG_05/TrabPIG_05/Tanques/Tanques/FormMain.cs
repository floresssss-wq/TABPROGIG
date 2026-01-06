using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tanques
{
    public partial class FormMain : Form
    {
        Arena arena;
        
        public FormMain()
        {
            InitializeComponent();
            arena = Arena.GetInstancia(panelArea.Size);
            
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PanelArea_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
                   
                desenhaArea(g);
            
        }

        private void desenhaArea(Graphics g)
        {
            if (arena.Start == true) { 
            g.Clear(panelArea.BackColor);

            arena.draw(g);
        }
          
        }

        private void panelArea_SizeChanged(object sender, EventArgs e)
        {
            if (arena != null) arena.Area = panelArea.Size;
            panelArea.Invalidate();
        }

        private void TimerAnima_Tick(object sender, EventArgs e)
        {
            if (arena.Start == true)
            {
                arena.checkVida();
                arena.move();
                arena.acao();

                redesenhaArea();
            }

        }

        private void redesenhaArea()
        {
            BufferedGraphicsContext currentContext;
            BufferedGraphics myBuffer;
            currentContext = BufferedGraphicsManager.Current;
            myBuffer = currentContext.Allocate(this.panelArea.CreateGraphics(),
                this.panelArea.DisplayRectangle);
            Graphics g = myBuffer.Graphics;

            desenhaArea(g);

            myBuffer.Render();
            myBuffer.Dispose();
        }


        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (arena.getOpcao() == 0)
            {
                string message = "Selecione um Layout de obstaculos";
                MessageBox.Show(message);
            }
            else {
                if (arena.Start == false)
                    arena.Start = true;
                else arena.Start = false;
            }
            
        }

        // daqui para baixo estao todos os comandos para o costumizar, So podem ser alterados no antes de o jogo começar

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (arena.Start == false)
                arena.setVidaVermelho(4);
        }

        private void toolStripMenuRedVida4_Click(object sender, EventArgs e)
        {
            if (arena.Start == false)
                arena.setVidaVermelho(5);
        }

        private void toolStripMenuRedVida5_Click(object sender, EventArgs e)
        {
            if (arena.Start == false)
                arena.setVidaVermelho(6);
        }

        private void toolStripMenuRedVelo1_Click(object sender, EventArgs e)
        {
            if (arena.Start == false)
                arena.setVelocidadeVermelho(4f);
        }

        private void toolStripMenuRedVelo2_Click(object sender, EventArgs e)
        {
            if (arena.Start == false)
                arena.setVelocidadeVermelho(5f);
        }

        private void toolStripMenuRedVelo3_Click(object sender, EventArgs e)
        {
            if (arena.Start == false)
                arena.setVelocidadeVermelho(6f);
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            if (arena.Start == false)
                arena.setAlcanceVermelho(500);
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            if (arena.Start == false)
                arena.setAlcanceVermelho(600);
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            if (arena.Start == false)
                arena.setAlcanceVermelho(700);
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            if (arena.Start == false)
                arena.setVidaAzul(4);
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            if (arena.Start == false)
                arena.setVidaAzul(5);
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            if (arena.Start == false)
                arena.setVidaAzul(6);
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            if (arena.Start == false)
                arena.setVelocidadeAzul(4f);
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            if (arena.Start == false)
                arena.setVelocidadeAzul(5f);
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            if (arena.Start == false)
                arena.setVelocidadeAzul(6f);
        }

        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            if (arena.Start == false)
                arena.setAlcanceAzul(500);
        }

        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        {
            if (arena.Start == false)
                arena.setAlcanceAzul(600);
        }

        private void toolStripMenuItem21_Click(object sender, EventArgs e)
        {
            if (arena.Start == false)
                arena.setAlcanceAzul(700);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            arena.restart();
            arena.Start = false;
        
        }

        private void checkBoxAlcance_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxAlcance.Checked)
                arena.setAlcanceVisivel(true);
            else arena.setAlcanceVisivel(false);

        }

        private void checkBoxAlcance_CheckStateChanged(object sender, EventArgs e)
        {
            
        }


        // abaixo estão os metodos para definir os layouts dos obstaculos
        private void layout1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (arena.Start == false)
                arena.defineArena(1);
            
        }

        private void layout2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (arena.Start == false)
                arena.defineArena(2);
            
        }

        private void layout1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (arena.Start == false)
                arena.defineArena(3);
        }

        private void layout1ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (arena.Start == false)
                arena.defineArena(4);
        }

        private void layout1ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (arena.Start == false)
                arena.defineArena(5);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void obstaculosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
