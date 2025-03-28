﻿namespace JoKenPo
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            jogoClássicoToolStripMenuItem = new ToolStripMenuItem();
            clássicoToolStripMenuItem = new ToolStripMenuItem();
            avançadoToolStripMenuItem = new ToolStripMenuItem();
            reiniciarJogoToolStripMenuItem1 = new ToolStripMenuItem();
            fecharJogoToolStripMenuItem = new ToolStripSeparator();
            sairToolStripMenuItem = new ToolStripMenuItem();
            configuraçõesToolStripMenuItem = new ToolStripMenuItem();
            partidasToolStripMenuItem = new ToolStripMenuItem();
            partidaUnicaToolStripMenuItem = new ToolStripMenuItem();
            melhorDe3ToolStripMenuItem = new ToolStripMenuItem();
            melhorDe5ToolStripMenuItem = new ToolStripMenuItem();
            melhorDe10ToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            modoClássicoToolStripMenuItem = new ToolStripMenuItem();
            modoAvançadoToolStripMenuItem = new ToolStripMenuItem();
            panelPrincipal = new Panel();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabelPontuacao = new ToolStripStatusLabel();
            toolStripStatusLabelVoce = new ToolStripStatusLabel();
            toolStripStatusLabelVs = new ToolStripStatusLabel();
            toolStripStatusLabelPC = new ToolStripStatusLabel();
            toolStripStatusLabelPartida = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, configuraçõesToolStripMenuItem, sobreToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(564, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { jogoClássicoToolStripMenuItem, reiniciarJogoToolStripMenuItem1, fecharJogoToolStripMenuItem, sairToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(61, 20);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // jogoClássicoToolStripMenuItem
            // 
            jogoClássicoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clássicoToolStripMenuItem, avançadoToolStripMenuItem });
            jogoClássicoToolStripMenuItem.Name = "jogoClássicoToolStripMenuItem";
            jogoClássicoToolStripMenuItem.Size = new Size(180, 22);
            jogoClássicoToolStripMenuItem.Text = "Jogo";
            // 
            // clássicoToolStripMenuItem
            // 
            clássicoToolStripMenuItem.Name = "clássicoToolStripMenuItem";
            clássicoToolStripMenuItem.Size = new Size(127, 22);
            clássicoToolStripMenuItem.Text = "Clássico";
            clássicoToolStripMenuItem.Click += jogoClassicoToolStripMenuItem_Click;
            // 
            // avançadoToolStripMenuItem
            // 
            avançadoToolStripMenuItem.Name = "avançadoToolStripMenuItem";
            avançadoToolStripMenuItem.Size = new Size(127, 22);
            avançadoToolStripMenuItem.Text = "Avançado";
            avançadoToolStripMenuItem.Click += jogoAvançadoToolStripMenuItem_Click;
            // 
            // reiniciarJogoToolStripMenuItem1
            // 
            reiniciarJogoToolStripMenuItem1.Name = "reiniciarJogoToolStripMenuItem1";
            reiniciarJogoToolStripMenuItem1.Size = new Size(180, 22);
            reiniciarJogoToolStripMenuItem1.Text = "Reiniciar jogo";
            reiniciarJogoToolStripMenuItem1.Click += reiniciarJogoToolStripMenuItem1_Click;
            // 
            // fecharJogoToolStripMenuItem
            // 
            fecharJogoToolStripMenuItem.Name = "fecharJogoToolStripMenuItem";
            fecharJogoToolStripMenuItem.Size = new Size(177, 6);
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(180, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // configuraçõesToolStripMenuItem
            // 
            configuraçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { partidasToolStripMenuItem });
            configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            configuraçõesToolStripMenuItem.Size = new Size(96, 20);
            configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // partidasToolStripMenuItem
            // 
            partidasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { partidaUnicaToolStripMenuItem, melhorDe3ToolStripMenuItem, melhorDe5ToolStripMenuItem, melhorDe10ToolStripMenuItem });
            partidasToolStripMenuItem.Name = "partidasToolStripMenuItem";
            partidasToolStripMenuItem.Size = new Size(116, 22);
            partidasToolStripMenuItem.Text = "Partidas";
            // 
            // partidaUnicaToolStripMenuItem
            // 
            partidaUnicaToolStripMenuItem.Name = "partidaUnicaToolStripMenuItem";
            partidaUnicaToolStripMenuItem.Size = new Size(143, 22);
            partidaUnicaToolStripMenuItem.Text = "partida única";
            partidaUnicaToolStripMenuItem.Click += partidaUnicaToolStripMenuItem_Click;
            // 
            // melhorDe3ToolStripMenuItem
            // 
            melhorDe3ToolStripMenuItem.Name = "melhorDe3ToolStripMenuItem";
            melhorDe3ToolStripMenuItem.Size = new Size(143, 22);
            melhorDe3ToolStripMenuItem.Text = "melhor de 3";
            melhorDe3ToolStripMenuItem.Click += melhorDe3ToolStripMenuItem_Click;
            // 
            // melhorDe5ToolStripMenuItem
            // 
            melhorDe5ToolStripMenuItem.Name = "melhorDe5ToolStripMenuItem";
            melhorDe5ToolStripMenuItem.Size = new Size(143, 22);
            melhorDe5ToolStripMenuItem.Text = "melhor de 5";
            melhorDe5ToolStripMenuItem.Click += melhorDe5ToolStripMenuItem_Click;
            // 
            // melhorDe10ToolStripMenuItem
            // 
            melhorDe10ToolStripMenuItem.Name = "melhorDe10ToolStripMenuItem";
            melhorDe10ToolStripMenuItem.Size = new Size(143, 22);
            melhorDe10ToolStripMenuItem.Text = "melhor de 10";
            melhorDe10ToolStripMenuItem.Click += melhorDe10ToolStripMenuItem_Click;
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { modoClássicoToolStripMenuItem, modoAvançadoToolStripMenuItem });
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(49, 20);
            sobreToolStripMenuItem.Text = "Sobre";
            // 
            // modoClássicoToolStripMenuItem
            // 
            modoClássicoToolStripMenuItem.Name = "modoClássicoToolStripMenuItem";
            modoClássicoToolStripMenuItem.Size = new Size(160, 22);
            modoClássicoToolStripMenuItem.Text = "Modo clássico";
            modoClássicoToolStripMenuItem.Click += modoClassicoToolStripMenuItem_Click;
            // 
            // modoAvançadoToolStripMenuItem
            // 
            modoAvançadoToolStripMenuItem.Name = "modoAvançadoToolStripMenuItem";
            modoAvançadoToolStripMenuItem.Size = new Size(160, 22);
            modoAvançadoToolStripMenuItem.Text = "Modo avançado";
            modoAvançadoToolStripMenuItem.Click += modoAvançadoToolStripMenuItem_Click;
            // 
            // panelPrincipal
            // 
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(0, 24);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(564, 432);
            panelPrincipal.TabIndex = 1;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelPontuacao, toolStripStatusLabelVoce, toolStripStatusLabelVs, toolStripStatusLabelPC, toolStripStatusLabelPartida });
            statusStrip1.Location = new Point(0, 434);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(564, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelPontuacao
            // 
            toolStripStatusLabelPontuacao.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripStatusLabelPontuacao.Name = "toolStripStatusLabelPontuacao";
            toolStripStatusLabelPontuacao.Size = new Size(77, 17);
            toolStripStatusLabelPontuacao.Text = "Pontuação:";
            // 
            // toolStripStatusLabelVoce
            // 
            toolStripStatusLabelVoce.Name = "toolStripStatusLabelVoce";
            toolStripStatusLabelVoce.Size = new Size(52, 17);
            toolStripStatusLabelVoce.Text = "Você - ...";
            // 
            // toolStripStatusLabelVs
            // 
            toolStripStatusLabelVs.Name = "toolStripStatusLabelVs";
            toolStripStatusLabelVs.Size = new Size(18, 17);
            toolStripStatusLabelVs.Text = "vs";
            // 
            // toolStripStatusLabelPC
            // 
            toolStripStatusLabelPC.Name = "toolStripStatusLabelPC";
            toolStripStatusLabelPC.Size = new Size(42, 17);
            toolStripStatusLabelPC.Text = "PC - ...";
            // 
            // toolStripStatusLabelPartida
            // 
            toolStripStatusLabelPartida.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripStatusLabelPartida.Name = "toolStripStatusLabelPartida";
            toolStripStatusLabelPartida.Size = new Size(360, 17);
            toolStripStatusLabelPartida.Spring = true;
            toolStripStatusLabelPartida.Text = "Partida ?";
            toolStripStatusLabelPartida.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 456);
            Controls.Add(statusStrip1);
            Controls.Add(panelPrincipal);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "JoKenPo";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripSeparator fecharJogoToolStripMenuItem;
        private ToolStripMenuItem reiniciarJogoToolStripMenuItem1;
        private ToolStripMenuItem configuraçõesToolStripMenuItem;
        private ToolStripMenuItem partidasToolStripMenuItem;
        private ToolStripMenuItem partidaUnicaToolStripMenuItem;
        private ToolStripMenuItem melhorDe3ToolStripMenuItem;
        private ToolStripMenuItem melhorDe5ToolStripMenuItem;
        private ToolStripMenuItem melhorDe10ToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripMenuItem modoClássicoToolStripMenuItem;
        private ToolStripMenuItem modoAvançadoToolStripMenuItem;
        private ToolStripMenuItem jogoClássicoToolStripMenuItem;
        private ToolStripMenuItem clássicoToolStripMenuItem;
        private ToolStripMenuItem avançadoToolStripMenuItem;
        private Panel panelPrincipal;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabelPontuacao;
        private ToolStripStatusLabel toolStripStatusLabelVoce;
        private ToolStripStatusLabel toolStripStatusLabelVs;
        private ToolStripStatusLabel toolStripStatusLabelPC;
        private ToolStripStatusLabel toolStripStatusLabelPartida;
    }
}