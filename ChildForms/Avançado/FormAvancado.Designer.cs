namespace JoKenPo
{
    partial class FormAvancado
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
            labelEscolha = new Label();
            labelTesoura = new Label();
            labelPapel = new Label();
            labelPedra = new Label();
            buttonTesoura = new Button();
            buttonPapel = new Button();
            buttonPedra = new Button();
            buttonLagarto = new Button();
            buttonSpock = new Button();
            labelLagarto = new Label();
            labelSpock = new Label();
            pictureResultado = new PictureBox();
            picturePC = new PictureBox();
            pictureJogador = new PictureBox();
            labelResposta = new Label();
            labelPC = new Label();
            labelJogador = new Label();
            labelIgual = new Label();
            labelVs = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureResultado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picturePC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureJogador).BeginInit();
            SuspendLayout();
            // 
            // labelEscolha
            // 
            labelEscolha.AutoSize = true;
            labelEscolha.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEscolha.Location = new Point(236, 9);
            labelEscolha.Name = "labelEscolha";
            labelEscolha.Size = new Size(89, 30);
            labelEscolha.TabIndex = 1;
            labelEscolha.Text = "Escolha:";
            // 
            // labelTesoura
            // 
            labelTesoura.AutoSize = true;
            labelTesoura.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTesoura.Location = new Point(430, 64);
            labelTesoura.Name = "labelTesoura";
            labelTesoura.Size = new Size(87, 30);
            labelTesoura.TabIndex = 9;
            labelTesoura.Text = "Tesoura";
            // 
            // labelPapel
            // 
            labelPapel.AutoSize = true;
            labelPapel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPapel.Location = new Point(248, 64);
            labelPapel.Name = "labelPapel";
            labelPapel.Size = new Size(64, 30);
            labelPapel.TabIndex = 8;
            labelPapel.Text = "Papel";
            // 
            // labelPedra
            // 
            labelPedra.AutoSize = true;
            labelPedra.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPedra.Location = new Point(57, 64);
            labelPedra.Name = "labelPedra";
            labelPedra.Size = new Size(67, 30);
            labelPedra.TabIndex = 7;
            labelPedra.Text = "Pedra";
            // 
            // buttonTesoura
            // 
            buttonTesoura.Image = Properties.Resources.tesoura;
            buttonTesoura.Location = new Point(410, 97);
            buttonTesoura.Name = "buttonTesoura";
            buttonTesoura.Size = new Size(120, 120);
            buttonTesoura.TabIndex = 12;
            buttonTesoura.TabStop = false;
            buttonTesoura.UseVisualStyleBackColor = true;
            buttonTesoura.Click += buttonTesoura_Click;
            // 
            // buttonPapel
            // 
            buttonPapel.Image = Properties.Resources.papel;
            buttonPapel.Location = new Point(220, 97);
            buttonPapel.Name = "buttonPapel";
            buttonPapel.Size = new Size(120, 120);
            buttonPapel.TabIndex = 11;
            buttonPapel.TabStop = false;
            buttonPapel.UseVisualStyleBackColor = true;
            buttonPapel.Click += buttonPapel_Click;
            // 
            // buttonPedra
            // 
            buttonPedra.Image = Properties.Resources.pedra;
            buttonPedra.Location = new Point(30, 97);
            buttonPedra.Name = "buttonPedra";
            buttonPedra.Size = new Size(120, 120);
            buttonPedra.TabIndex = 10;
            buttonPedra.TabStop = false;
            buttonPedra.UseVisualStyleBackColor = true;
            buttonPedra.Click += buttonPedra_Click;
            // 
            // buttonLagarto
            // 
            buttonLagarto.Image = Properties.Resources.lagarto;
            buttonLagarto.Location = new Point(127, 253);
            buttonLagarto.Name = "buttonLagarto";
            buttonLagarto.Size = new Size(120, 120);
            buttonLagarto.TabIndex = 13;
            buttonLagarto.TabStop = false;
            buttonLagarto.UseVisualStyleBackColor = true;
            buttonLagarto.Click += buttonLagarto_Click;
            // 
            // buttonSpock
            // 
            buttonSpock.Image = Properties.Resources.spock;
            buttonSpock.Location = new Point(313, 253);
            buttonSpock.Name = "buttonSpock";
            buttonSpock.Size = new Size(120, 120);
            buttonSpock.TabIndex = 14;
            buttonSpock.TabStop = false;
            buttonSpock.UseVisualStyleBackColor = true;
            buttonSpock.Click += buttonSpock_Click;
            // 
            // labelLagarto
            // 
            labelLagarto.AutoSize = true;
            labelLagarto.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLagarto.Location = new Point(144, 220);
            labelLagarto.Name = "labelLagarto";
            labelLagarto.Size = new Size(88, 30);
            labelLagarto.TabIndex = 15;
            labelLagarto.Text = "Lagarto";
            // 
            // labelSpock
            // 
            labelSpock.AutoSize = true;
            labelSpock.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSpock.Location = new Point(338, 220);
            labelSpock.Name = "labelSpock";
            labelSpock.Size = new Size(71, 30);
            labelSpock.TabIndex = 16;
            labelSpock.Text = "Spock";
            // 
            // pictureResultado
            // 
            pictureResultado.BorderStyle = BorderStyle.FixedSingle;
            pictureResultado.Location = new Point(410, 379);
            pictureResultado.Name = "pictureResultado";
            pictureResultado.Size = new Size(120, 120);
            pictureResultado.TabIndex = 19;
            pictureResultado.TabStop = false;
            // 
            // picturePC
            // 
            picturePC.BorderStyle = BorderStyle.FixedSingle;
            picturePC.Location = new Point(220, 379);
            picturePC.Name = "picturePC";
            picturePC.Size = new Size(120, 120);
            picturePC.TabIndex = 18;
            picturePC.TabStop = false;
            // 
            // pictureJogador
            // 
            pictureJogador.BorderStyle = BorderStyle.FixedSingle;
            pictureJogador.Location = new Point(30, 379);
            pictureJogador.Name = "pictureJogador";
            pictureJogador.Size = new Size(120, 120);
            pictureJogador.TabIndex = 17;
            pictureJogador.TabStop = false;
            // 
            // labelResposta
            // 
            labelResposta.AutoSize = true;
            labelResposta.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelResposta.Location = new Point(459, 426);
            labelResposta.Name = "labelResposta";
            labelResposta.Size = new Size(22, 30);
            labelResposta.TabIndex = 24;
            labelResposta.Text = "?";
            // 
            // labelPC
            // 
            labelPC.AutoSize = true;
            labelPC.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPC.Location = new Point(261, 426);
            labelPC.Name = "labelPC";
            labelPC.Size = new Size(38, 30);
            labelPC.TabIndex = 23;
            labelPC.Text = "PC";
            // 
            // labelJogador
            // 
            labelJogador.AutoSize = true;
            labelJogador.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelJogador.Location = new Point(61, 426);
            labelJogador.Name = "labelJogador";
            labelJogador.Size = new Size(58, 30);
            labelJogador.TabIndex = 22;
            labelJogador.Text = "você";
            // 
            // labelIgual
            // 
            labelIgual.AutoSize = true;
            labelIgual.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelIgual.Location = new Point(360, 426);
            labelIgual.Name = "labelIgual";
            labelIgual.Size = new Size(28, 30);
            labelIgual.TabIndex = 21;
            labelIgual.Text = "=";
            // 
            // labelVs
            // 
            labelVs.AutoSize = true;
            labelVs.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelVs.Location = new Point(168, 426);
            labelVs.Name = "labelVs";
            labelVs.Size = new Size(33, 30);
            labelVs.TabIndex = 20;
            labelVs.Text = "vs";
            // 
            // FormAvancado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 550);
            Controls.Add(labelResposta);
            Controls.Add(labelPC);
            Controls.Add(labelJogador);
            Controls.Add(labelIgual);
            Controls.Add(labelVs);
            Controls.Add(pictureResultado);
            Controls.Add(picturePC);
            Controls.Add(pictureJogador);
            Controls.Add(labelSpock);
            Controls.Add(labelLagarto);
            Controls.Add(buttonSpock);
            Controls.Add(buttonLagarto);
            Controls.Add(buttonTesoura);
            Controls.Add(buttonPapel);
            Controls.Add(buttonPedra);
            Controls.Add(labelTesoura);
            Controls.Add(labelPapel);
            Controls.Add(labelPedra);
            Controls.Add(labelEscolha);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAvancado";
            ((System.ComponentModel.ISupportInitialize)pictureResultado).EndInit();
            ((System.ComponentModel.ISupportInitialize)picturePC).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureJogador).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelEscolha;
        private Label labelTesoura;
        private Label labelPapel;
        private Label labelPedra;
        private Button buttonTesoura;
        private Button buttonPapel;
        private Button buttonPedra;
        private Button buttonLagarto;
        private Button buttonSpock;
        private Label labelLagarto;
        private Label labelSpock;
        private PictureBox pictureResultado;
        private PictureBox picturePC;
        private PictureBox pictureJogador;
        private Label labelResposta;
        private Label labelPC;
        private Label labelJogador;
        private Label labelIgual;
        private Label labelVs;
    }
}