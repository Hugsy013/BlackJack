namespace BlackJackGame
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.labelScorePlayer1 = new System.Windows.Forms.TextBox();
            this.btnEncerrarPlayer1 = new System.Windows.Forms.Button();
            this.btnPedirCartaPlayer1 = new System.Windows.Forms.Button();
            this.pictureBoxPlayer1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEncerrarPlayer2 = new System.Windows.Forms.Button();
            this.btnPedirCartaPlayer2 = new System.Windows.Forms.Button();
            this.labelScorePlayer2 = new System.Windows.Forms.TextBox();
            this.labelVencedor = new System.Windows.Forms.Label();
            this.pictureBoxPlayer2 = new System.Windows.Forms.PictureBox();
            this.panelVencedor = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnreiniciar = new System.Windows.Forms.Button();
            this.labelVencedor1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer2)).BeginInit();
            this.panelVencedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.labelScorePlayer1);
            this.panel1.Controls.Add(this.btnEncerrarPlayer1);
            this.panel1.Controls.Add(this.btnPedirCartaPlayer1);
            this.panel1.Controls.Add(this.pictureBoxPlayer1);
            this.panel1.Location = new System.Drawing.Point(1, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 424);
            this.panel1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(99, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Pontuação";
            // 
            // labelScorePlayer1
            // 
            this.labelScorePlayer1.BackColor = System.Drawing.Color.DarkGreen;
            this.labelScorePlayer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelScorePlayer1.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScorePlayer1.ForeColor = System.Drawing.Color.White;
            this.labelScorePlayer1.Location = new System.Drawing.Point(120, 293);
            this.labelScorePlayer1.Name = "labelScorePlayer1";
            this.labelScorePlayer1.ReadOnly = true;
            this.labelScorePlayer1.Size = new System.Drawing.Size(31, 16);
            this.labelScorePlayer1.TabIndex = 3;
            this.labelScorePlayer1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEncerrarPlayer1
            // 
            this.btnEncerrarPlayer1.BackColor = System.Drawing.Color.LightGreen;
            this.btnEncerrarPlayer1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEncerrarPlayer1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncerrarPlayer1.ForeColor = System.Drawing.Color.Black;
            this.btnEncerrarPlayer1.Location = new System.Drawing.Point(52, 361);
            this.btnEncerrarPlayer1.Name = "btnEncerrarPlayer1";
            this.btnEncerrarPlayer1.Size = new System.Drawing.Size(167, 35);
            this.btnEncerrarPlayer1.TabIndex = 2;
            this.btnEncerrarPlayer1.Text = "Encerrar Turno";
            this.btnEncerrarPlayer1.UseVisualStyleBackColor = false;
            this.btnEncerrarPlayer1.Click += new System.EventHandler(this.btnEncerrarPlayer1_Click);
            // 
            // btnPedirCartaPlayer1
            // 
            this.btnPedirCartaPlayer1.BackColor = System.Drawing.Color.Indigo;
            this.btnPedirCartaPlayer1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPedirCartaPlayer1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPedirCartaPlayer1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedirCartaPlayer1.ForeColor = System.Drawing.Color.White;
            this.btnPedirCartaPlayer1.Location = new System.Drawing.Point(52, 315);
            this.btnPedirCartaPlayer1.Name = "btnPedirCartaPlayer1";
            this.btnPedirCartaPlayer1.Size = new System.Drawing.Size(167, 31);
            this.btnPedirCartaPlayer1.TabIndex = 1;
            this.btnPedirCartaPlayer1.Text = "Oferta";
            this.btnPedirCartaPlayer1.UseVisualStyleBackColor = false;
            this.btnPedirCartaPlayer1.Click += new System.EventHandler(this.btnPedirCartaPlayer1_Click);
            // 
            // pictureBoxPlayer1
            // 
            this.pictureBoxPlayer1.Location = new System.Drawing.Point(52, 35);
            this.pictureBoxPlayer1.Name = "pictureBoxPlayer1";
            this.pictureBoxPlayer1.Size = new System.Drawing.Size(167, 233);
            this.pictureBoxPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPlayer1.TabIndex = 0;
            this.pictureBoxPlayer1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkRed;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnEncerrarPlayer2);
            this.panel2.Controls.Add(this.btnPedirCartaPlayer2);
            this.panel2.Controls.Add(this.labelScorePlayer2);
            this.panel2.Controls.Add(this.labelVencedor);
            this.panel2.Controls.Add(this.pictureBoxPlayer2);
            this.panel2.Location = new System.Drawing.Point(329, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 424);
            this.panel2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(143, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Pontuação";
            // 
            // btnEncerrarPlayer2
            // 
            this.btnEncerrarPlayer2.BackColor = System.Drawing.Color.LightGreen;
            this.btnEncerrarPlayer2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEncerrarPlayer2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncerrarPlayer2.ForeColor = System.Drawing.Color.Black;
            this.btnEncerrarPlayer2.Location = new System.Drawing.Point(94, 361);
            this.btnEncerrarPlayer2.Name = "btnEncerrarPlayer2";
            this.btnEncerrarPlayer2.Size = new System.Drawing.Size(167, 35);
            this.btnEncerrarPlayer2.TabIndex = 4;
            this.btnEncerrarPlayer2.Text = "Encerrar Turno";
            this.btnEncerrarPlayer2.UseVisualStyleBackColor = false;
            this.btnEncerrarPlayer2.Click += new System.EventHandler(this.btnEncerrarPlayer2_Click);
            // 
            // btnPedirCartaPlayer2
            // 
            this.btnPedirCartaPlayer2.BackColor = System.Drawing.Color.Indigo;
            this.btnPedirCartaPlayer2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPedirCartaPlayer2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPedirCartaPlayer2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedirCartaPlayer2.ForeColor = System.Drawing.Color.White;
            this.btnPedirCartaPlayer2.Location = new System.Drawing.Point(94, 315);
            this.btnPedirCartaPlayer2.Name = "btnPedirCartaPlayer2";
            this.btnPedirCartaPlayer2.Size = new System.Drawing.Size(167, 31);
            this.btnPedirCartaPlayer2.TabIndex = 4;
            this.btnPedirCartaPlayer2.Text = "Oferta";
            this.btnPedirCartaPlayer2.UseVisualStyleBackColor = false;
            this.btnPedirCartaPlayer2.Click += new System.EventHandler(this.btnPedirCartaPlayer2_Click);
            // 
            // labelScorePlayer2
            // 
            this.labelScorePlayer2.BackColor = System.Drawing.Color.DarkRed;
            this.labelScorePlayer2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelScorePlayer2.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScorePlayer2.ForeColor = System.Drawing.Color.White;
            this.labelScorePlayer2.Location = new System.Drawing.Point(166, 293);
            this.labelScorePlayer2.Name = "labelScorePlayer2";
            this.labelScorePlayer2.ReadOnly = true;
            this.labelScorePlayer2.Size = new System.Drawing.Size(31, 16);
            this.labelScorePlayer2.TabIndex = 4;
            this.labelScorePlayer2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelVencedor
            // 
            this.labelVencedor.AutoSize = true;
            this.labelVencedor.Location = new System.Drawing.Point(-32, 185);
            this.labelVencedor.Name = "labelVencedor";
            this.labelVencedor.Size = new System.Drawing.Size(35, 13);
            this.labelVencedor.TabIndex = 0;
            this.labelVencedor.Text = "label1";
            // 
            // pictureBoxPlayer2
            // 
            this.pictureBoxPlayer2.Location = new System.Drawing.Point(94, 35);
            this.pictureBoxPlayer2.Name = "pictureBoxPlayer2";
            this.pictureBoxPlayer2.Size = new System.Drawing.Size(167, 233);
            this.pictureBoxPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPlayer2.TabIndex = 0;
            this.pictureBoxPlayer2.TabStop = false;
            // 
            // panelVencedor
            // 
            this.panelVencedor.BackColor = System.Drawing.Color.White;
            this.panelVencedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelVencedor.Controls.Add(this.button1);
            this.panelVencedor.Controls.Add(this.btnreiniciar);
            this.panelVencedor.Controls.Add(this.labelVencedor1);
            this.panelVencedor.Location = new System.Drawing.Point(1, 127);
            this.panelVencedor.Name = "panelVencedor";
            this.panelVencedor.Size = new System.Drawing.Size(660, 438);
            this.panelVencedor.TabIndex = 4;
            this.panelVencedor.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(189, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnreiniciar
            // 
            this.btnreiniciar.BackColor = System.Drawing.Color.LightGreen;
            this.btnreiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnreiniciar.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreiniciar.Location = new System.Drawing.Point(189, 212);
            this.btnreiniciar.Name = "btnreiniciar";
            this.btnreiniciar.Size = new System.Drawing.Size(250, 36);
            this.btnreiniciar.TabIndex = 2;
            this.btnreiniciar.Text = "Jogar Novamente";
            this.btnreiniciar.UseVisualStyleBackColor = false;
            this.btnreiniciar.Click += new System.EventHandler(this.btnreiniciar_Click);
            // 
            // labelVencedor1
            // 
            this.labelVencedor1.AutoSize = true;
            this.labelVencedor1.BackColor = System.Drawing.Color.Transparent;
            this.labelVencedor1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelVencedor1.Font = new System.Drawing.Font("Calibri", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVencedor1.ForeColor = System.Drawing.Color.Black;
            this.labelVencedor1.Location = new System.Drawing.Point(188, 167);
            this.labelVencedor1.Name = "labelVencedor1";
            this.labelVencedor1.Size = new System.Drawing.Size(258, 40);
            this.labelVencedor1.TabIndex = 0;
            this.labelVencedor1.Text = "Jogador 1 Venceu";
            this.labelVencedor1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(259, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "BlackJack";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(577, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 37);
            this.button2.TabIndex = 6;
            this.button2.Text = "Ajuda?";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(660, 556);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelVencedor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.WhiteSmoke;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer2)).EndInit();
            this.panelVencedor.ResumeLayout(false);
            this.panelVencedor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPlayer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEncerrarPlayer1;
        private System.Windows.Forms.Button btnPedirCartaPlayer1;
        private System.Windows.Forms.PictureBox pictureBoxPlayer2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelVencedor;
        private System.Windows.Forms.Panel panelVencedor;
        private System.Windows.Forms.Label labelVencedor1;
        private System.Windows.Forms.TextBox labelScorePlayer1;
        private System.Windows.Forms.TextBox labelScorePlayer2;
        private System.Windows.Forms.Button btnEncerrarPlayer2;
        private System.Windows.Forms.Button btnPedirCartaPlayer2;
        private System.Windows.Forms.Button btnreiniciar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}

