namespace Tanques
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelArea = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ficheiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuRedVida3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuRedVida4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuRedVida5 = new System.Windows.Forms.ToolStripMenuItem();
            this.velocidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuRedVelo1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuRedVelo2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuRedVelo3 = new System.Windows.Forms.ToolStripMenuItem();
            this.alcanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.vidaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.velocidadeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem18 = new System.Windows.Forms.ToolStripMenuItem();
            this.alcançeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem19 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem20 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem21 = new System.Windows.Forms.ToolStripMenuItem();
            this.obstaculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layout1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layout2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layout1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.layout1ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.layout1ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.timerAnima = new System.Windows.Forms.Timer(this.components);
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.checkBoxAlcance = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelArea
            // 
            this.panelArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelArea.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panelArea.Location = new System.Drawing.Point(12, 27);
            this.panelArea.Name = "panelArea";
            this.panelArea.Size = new System.Drawing.Size(1161, 446);
            this.panelArea.TabIndex = 0;
            this.panelArea.SizeChanged += new System.EventHandler(this.panelArea_SizeChanged);
            this.panelArea.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelArea_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheiroToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.obstaculosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1185, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ficheiroToolStripMenuItem
            // 
            this.ficheiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.ficheiroToolStripMenuItem.Name = "ficheiroToolStripMenuItem";
            this.ficheiroToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ficheiroToolStripMenuItem.Text = "Ficheiro";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vidaToolStripMenuItem,
            this.velocidadeToolStripMenuItem,
            this.alcanceToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(83, 20);
            this.toolStripMenuItem1.Text = "T Vermelhos";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // vidaToolStripMenuItem
            // 
            this.vidaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuRedVida3,
            this.toolStripMenuRedVida4,
            this.toolStripMenuRedVida5});
            this.vidaToolStripMenuItem.Name = "vidaToolStripMenuItem";
            this.vidaToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.vidaToolStripMenuItem.Text = "Vida";
            // 
            // toolStripMenuRedVida3
            // 
            this.toolStripMenuRedVida3.Name = "toolStripMenuRedVida3";
            this.toolStripMenuRedVida3.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuRedVida3.Text = "3";
            this.toolStripMenuRedVida3.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuRedVida4
            // 
            this.toolStripMenuRedVida4.Name = "toolStripMenuRedVida4";
            this.toolStripMenuRedVida4.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuRedVida4.Text = "4";
            this.toolStripMenuRedVida4.Click += new System.EventHandler(this.toolStripMenuRedVida4_Click);
            // 
            // toolStripMenuRedVida5
            // 
            this.toolStripMenuRedVida5.Name = "toolStripMenuRedVida5";
            this.toolStripMenuRedVida5.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuRedVida5.Text = "5";
            this.toolStripMenuRedVida5.Click += new System.EventHandler(this.toolStripMenuRedVida5_Click);
            // 
            // velocidadeToolStripMenuItem
            // 
            this.velocidadeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuRedVelo1,
            this.toolStripMenuRedVelo2,
            this.toolStripMenuRedVelo3});
            this.velocidadeToolStripMenuItem.Name = "velocidadeToolStripMenuItem";
            this.velocidadeToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.velocidadeToolStripMenuItem.Text = "Velocidade";
            // 
            // toolStripMenuRedVelo1
            // 
            this.toolStripMenuRedVelo1.Name = "toolStripMenuRedVelo1";
            this.toolStripMenuRedVelo1.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuRedVelo1.Text = "1";
            this.toolStripMenuRedVelo1.Click += new System.EventHandler(this.toolStripMenuRedVelo1_Click);
            // 
            // toolStripMenuRedVelo2
            // 
            this.toolStripMenuRedVelo2.Name = "toolStripMenuRedVelo2";
            this.toolStripMenuRedVelo2.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuRedVelo2.Text = "2";
            this.toolStripMenuRedVelo2.Click += new System.EventHandler(this.toolStripMenuRedVelo2_Click);
            // 
            // toolStripMenuRedVelo3
            // 
            this.toolStripMenuRedVelo3.Name = "toolStripMenuRedVelo3";
            this.toolStripMenuRedVelo3.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuRedVelo3.Text = "3";
            this.toolStripMenuRedVelo3.Click += new System.EventHandler(this.toolStripMenuRedVelo3_Click);
            // 
            // alcanceToolStripMenuItem
            // 
            this.alcanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem10,
            this.toolStripMenuItem11,
            this.toolStripMenuItem12});
            this.alcanceToolStripMenuItem.Name = "alcanceToolStripMenuItem";
            this.alcanceToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.alcanceToolStripMenuItem.Text = "Alcance";
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(92, 22);
            this.toolStripMenuItem10.Text = "400";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.toolStripMenuItem10_Click);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(92, 22);
            this.toolStripMenuItem11.Text = "500";
            this.toolStripMenuItem11.Click += new System.EventHandler(this.toolStripMenuItem11_Click);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(92, 22);
            this.toolStripMenuItem12.Text = "600";
            this.toolStripMenuItem12.Click += new System.EventHandler(this.toolStripMenuItem12_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vidaToolStripMenuItem1,
            this.velocidadeToolStripMenuItem1,
            this.alcançeToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(56, 20);
            this.toolStripMenuItem2.Text = "T Azuis";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // vidaToolStripMenuItem1
            // 
            this.vidaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem13,
            this.toolStripMenuItem14,
            this.toolStripMenuItem15});
            this.vidaToolStripMenuItem1.Name = "vidaToolStripMenuItem1";
            this.vidaToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.vidaToolStripMenuItem1.Text = "Vida";
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem13.Text = "3";
            this.toolStripMenuItem13.Click += new System.EventHandler(this.toolStripMenuItem13_Click);
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem14.Text = "4";
            this.toolStripMenuItem14.Click += new System.EventHandler(this.toolStripMenuItem14_Click);
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem15.Text = "5";
            this.toolStripMenuItem15.Click += new System.EventHandler(this.toolStripMenuItem15_Click);
            // 
            // velocidadeToolStripMenuItem1
            // 
            this.velocidadeToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem16,
            this.toolStripMenuItem17,
            this.toolStripMenuItem18});
            this.velocidadeToolStripMenuItem1.Name = "velocidadeToolStripMenuItem1";
            this.velocidadeToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.velocidadeToolStripMenuItem1.Text = "Velocidade";
            // 
            // toolStripMenuItem16
            // 
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            this.toolStripMenuItem16.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem16.Text = "1";
            this.toolStripMenuItem16.Click += new System.EventHandler(this.toolStripMenuItem16_Click);
            // 
            // toolStripMenuItem17
            // 
            this.toolStripMenuItem17.Name = "toolStripMenuItem17";
            this.toolStripMenuItem17.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem17.Text = "2";
            this.toolStripMenuItem17.Click += new System.EventHandler(this.toolStripMenuItem17_Click);
            // 
            // toolStripMenuItem18
            // 
            this.toolStripMenuItem18.Name = "toolStripMenuItem18";
            this.toolStripMenuItem18.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem18.Text = "3";
            this.toolStripMenuItem18.Click += new System.EventHandler(this.toolStripMenuItem18_Click);
            // 
            // alcançeToolStripMenuItem
            // 
            this.alcançeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem19,
            this.toolStripMenuItem20,
            this.toolStripMenuItem21});
            this.alcançeToolStripMenuItem.Name = "alcançeToolStripMenuItem";
            this.alcançeToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.alcançeToolStripMenuItem.Text = "Alcançe";
            // 
            // toolStripMenuItem19
            // 
            this.toolStripMenuItem19.Name = "toolStripMenuItem19";
            this.toolStripMenuItem19.Size = new System.Drawing.Size(92, 22);
            this.toolStripMenuItem19.Text = "400";
            this.toolStripMenuItem19.Click += new System.EventHandler(this.toolStripMenuItem19_Click);
            // 
            // toolStripMenuItem20
            // 
            this.toolStripMenuItem20.Name = "toolStripMenuItem20";
            this.toolStripMenuItem20.Size = new System.Drawing.Size(92, 22);
            this.toolStripMenuItem20.Text = "500";
            this.toolStripMenuItem20.Click += new System.EventHandler(this.toolStripMenuItem20_Click);
            // 
            // toolStripMenuItem21
            // 
            this.toolStripMenuItem21.Name = "toolStripMenuItem21";
            this.toolStripMenuItem21.Size = new System.Drawing.Size(92, 22);
            this.toolStripMenuItem21.Text = "600";
            this.toolStripMenuItem21.Click += new System.EventHandler(this.toolStripMenuItem21_Click);
            // 
            // obstaculosToolStripMenuItem
            // 
            this.obstaculosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.layout1ToolStripMenuItem,
            this.layout2ToolStripMenuItem,
            this.layout1ToolStripMenuItem1,
            this.layout1ToolStripMenuItem2,
            this.layout1ToolStripMenuItem3});
            this.obstaculosToolStripMenuItem.Name = "obstaculosToolStripMenuItem";
            this.obstaculosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.obstaculosToolStripMenuItem.Text = "Obstáculo";
            this.obstaculosToolStripMenuItem.Click += new System.EventHandler(this.obstaculosToolStripMenuItem_Click);
            // 
            // layout1ToolStripMenuItem
            // 
            this.layout1ToolStripMenuItem.Name = "layout1ToolStripMenuItem";
            this.layout1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.layout1ToolStripMenuItem.Text = "Arena 1";
            this.layout1ToolStripMenuItem.Click += new System.EventHandler(this.layout1ToolStripMenuItem_Click);
            // 
            // layout2ToolStripMenuItem
            // 
            this.layout2ToolStripMenuItem.Name = "layout2ToolStripMenuItem";
            this.layout2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.layout2ToolStripMenuItem.Text = "Arena 2";
            this.layout2ToolStripMenuItem.Click += new System.EventHandler(this.layout2ToolStripMenuItem_Click);
            // 
            // layout1ToolStripMenuItem1
            // 
            this.layout1ToolStripMenuItem1.Name = "layout1ToolStripMenuItem1";
            this.layout1ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.layout1ToolStripMenuItem1.Text = "Arena 3";
            this.layout1ToolStripMenuItem1.Click += new System.EventHandler(this.layout1ToolStripMenuItem1_Click);
            // 
            // layout1ToolStripMenuItem2
            // 
            this.layout1ToolStripMenuItem2.Name = "layout1ToolStripMenuItem2";
            this.layout1ToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.layout1ToolStripMenuItem2.Text = "Arena 4";
            this.layout1ToolStripMenuItem2.Click += new System.EventHandler(this.layout1ToolStripMenuItem2_Click);
            // 
            // layout1ToolStripMenuItem3
            // 
            this.layout1ToolStripMenuItem3.Name = "layout1ToolStripMenuItem3";
            this.layout1ToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.layout1ToolStripMenuItem3.Text = "Arena 5";
            this.layout1ToolStripMenuItem3.Click += new System.EventHandler(this.layout1ToolStripMenuItem3_Click);
            // 
            // timerAnima
            // 
            this.timerAnima.Enabled = true;
            this.timerAnima.Interval = 30;
            this.timerAnima.Tick += new System.EventHandler(this.TimerAnima_Tick);
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(84, 507);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(230, 39);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Começar";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonRestart
            // 
            this.buttonRestart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRestart.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestart.Location = new System.Drawing.Point(887, 507);
            this.buttonRestart.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(223, 39);
            this.buttonRestart.TabIndex = 3;
            this.buttonRestart.Text = "Parar";
            this.buttonRestart.UseVisualStyleBackColor = false;
            this.buttonRestart.Click += new System.EventHandler(this.Button1_Click);
            // 
            // checkBoxAlcance
            // 
            this.checkBoxAlcance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxAlcance.AutoSize = true;
            this.checkBoxAlcance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAlcance.Location = new System.Drawing.Point(513, 518);
            this.checkBoxAlcance.Name = "checkBoxAlcance";
            this.checkBoxAlcance.Size = new System.Drawing.Size(148, 28);
            this.checkBoxAlcance.TabIndex = 4;
            this.checkBoxAlcance.Text = "Alcance Tiro";
            this.checkBoxAlcance.UseVisualStyleBackColor = true;
            this.checkBoxAlcance.CheckedChanged += new System.EventHandler(this.checkBoxAlcance_CheckedChanged);
            this.checkBoxAlcance.CheckStateChanged += new System.EventHandler(this.checkBoxAlcance_CheckStateChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(394, 476);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "AZUIS  ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(554, 476);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 39);
            this.label2.TabIndex = 6;
            this.label2.Text = "VS";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(655, 476);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 39);
            this.label3.TabIndex = 7;
            this.label3.Text = "VERMELHO";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1185, 560);
            this.Controls.Add(this.checkBoxAlcance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.panelArea);
            this.Controls.Add(this.menuStrip1);
            this.Location = new System.Drawing.Point(960, 540);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1201, 599);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1201, 599);
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Batalha De Tanques";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelArea;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ficheiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Timer timerAnima;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem vidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuRedVida3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuRedVida4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuRedVida5;
        private System.Windows.Forms.ToolStripMenuItem velocidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuRedVelo1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuRedVelo2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuRedVelo3;
        private System.Windows.Forms.ToolStripMenuItem alcanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem vidaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem15;
        private System.Windows.Forms.ToolStripMenuItem velocidadeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem16;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem17;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem18;
        private System.Windows.Forms.ToolStripMenuItem alcançeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem19;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem20;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem21;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.CheckBox checkBoxAlcance;
        private System.Windows.Forms.ToolStripMenuItem obstaculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem layout1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem layout2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem layout1ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem layout1ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem layout1ToolStripMenuItem3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

