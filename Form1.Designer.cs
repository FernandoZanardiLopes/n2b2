namespace n2b2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btncarro = new System.Windows.Forms.Button();
            this.btnmoto = new System.Windows.Forms.Button();
            this.btnnavio = new System.Windows.Forms.Button();
            this.btnnaviog = new System.Windows.Forms.Button();
            this.btncaminhao = new System.Windows.Forms.Button();
            this.btnonibus = new System.Windows.Forms.Button();
            this.btnaviao = new System.Windows.Forms.Button();
            this.btnaviaog = new System.Windows.Forms.Button();
            this.btntrem = new System.Windows.Forms.Button();
            this.btnmarca = new System.Windows.Forms.Button();
            this.btnmodelo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncarro
            // 
            this.btncarro.Location = new System.Drawing.Point(13, 13);
            this.btncarro.Name = "btncarro";
            this.btncarro.Size = new System.Drawing.Size(246, 63);
            this.btncarro.TabIndex = 0;
            this.btncarro.Text = "Carro";
            this.btncarro.UseVisualStyleBackColor = true;
            this.btncarro.Click += new System.EventHandler(this.btncarro_Click);
            // 
            // btnmoto
            // 
            this.btnmoto.Location = new System.Drawing.Point(12, 82);
            this.btnmoto.Name = "btnmoto";
            this.btnmoto.Size = new System.Drawing.Size(246, 63);
            this.btnmoto.TabIndex = 1;
            this.btnmoto.Text = "Moto";
            this.btnmoto.UseVisualStyleBackColor = true;
            this.btnmoto.Click += new System.EventHandler(this.btnmoto_Click);
            // 
            // btnnavio
            // 
            this.btnnavio.Location = new System.Drawing.Point(13, 151);
            this.btnnavio.Name = "btnnavio";
            this.btnnavio.Size = new System.Drawing.Size(246, 63);
            this.btnnavio.TabIndex = 2;
            this.btnnavio.Text = "Navio";
            this.btnnavio.UseVisualStyleBackColor = true;
            this.btnnavio.Click += new System.EventHandler(this.btnnavio_Click);
            // 
            // btnnaviog
            // 
            this.btnnaviog.Location = new System.Drawing.Point(13, 220);
            this.btnnaviog.Name = "btnnaviog";
            this.btnnaviog.Size = new System.Drawing.Size(246, 63);
            this.btnnaviog.TabIndex = 3;
            this.btnnaviog.Text = "Navio de Guerra";
            this.btnnaviog.UseVisualStyleBackColor = true;
            this.btnnaviog.Click += new System.EventHandler(this.btnnaviog_Click);
            // 
            // btncaminhao
            // 
            this.btncaminhao.Location = new System.Drawing.Point(290, 12);
            this.btncaminhao.Name = "btncaminhao";
            this.btncaminhao.Size = new System.Drawing.Size(246, 63);
            this.btncaminhao.TabIndex = 4;
            this.btncaminhao.Text = "Caminhão";
            this.btncaminhao.UseVisualStyleBackColor = true;
            this.btncaminhao.Click += new System.EventHandler(this.btncaminhao_Click);
            // 
            // btnonibus
            // 
            this.btnonibus.Location = new System.Drawing.Point(290, 82);
            this.btnonibus.Name = "btnonibus";
            this.btnonibus.Size = new System.Drawing.Size(246, 63);
            this.btnonibus.TabIndex = 5;
            this.btnonibus.Text = "Onibus";
            this.btnonibus.UseVisualStyleBackColor = true;
            this.btnonibus.Click += new System.EventHandler(this.btnonibus_Click);
            // 
            // btnaviao
            // 
            this.btnaviao.Location = new System.Drawing.Point(290, 151);
            this.btnaviao.Name = "btnaviao";
            this.btnaviao.Size = new System.Drawing.Size(246, 63);
            this.btnaviao.TabIndex = 6;
            this.btnaviao.Text = "Avião";
            this.btnaviao.UseVisualStyleBackColor = true;
            this.btnaviao.Click += new System.EventHandler(this.btnaviao_Click);
            // 
            // btnaviaog
            // 
            this.btnaviaog.Location = new System.Drawing.Point(290, 220);
            this.btnaviaog.Name = "btnaviaog";
            this.btnaviaog.Size = new System.Drawing.Size(246, 63);
            this.btnaviaog.TabIndex = 7;
            this.btnaviaog.Text = "Avião de Guerra";
            this.btnaviaog.UseVisualStyleBackColor = true;
            this.btnaviaog.Click += new System.EventHandler(this.button8_Click);
            // 
            // btntrem
            // 
            this.btntrem.Location = new System.Drawing.Point(146, 289);
            this.btntrem.Name = "btntrem";
            this.btntrem.Size = new System.Drawing.Size(246, 63);
            this.btntrem.TabIndex = 8;
            this.btntrem.Text = "Trem";
            this.btntrem.UseVisualStyleBackColor = true;
            this.btntrem.Click += new System.EventHandler(this.btntrem_Click);
            // 
            // btnmarca
            // 
            this.btnmarca.Location = new System.Drawing.Point(12, 416);
            this.btnmarca.Name = "btnmarca";
            this.btnmarca.Size = new System.Drawing.Size(246, 63);
            this.btnmarca.TabIndex = 9;
            this.btnmarca.Text = "Marca";
            this.btnmarca.UseVisualStyleBackColor = true;
            // 
            // btnmodelo
            // 
            this.btnmodelo.Location = new System.Drawing.Point(290, 416);
            this.btnmodelo.Name = "btnmodelo";
            this.btnmodelo.Size = new System.Drawing.Size(246, 63);
            this.btnmodelo.TabIndex = 10;
            this.btnmodelo.Text = "Modelo";
            this.btnmodelo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 539);
            this.Controls.Add(this.btnmodelo);
            this.Controls.Add(this.btnmarca);
            this.Controls.Add(this.btntrem);
            this.Controls.Add(this.btnaviaog);
            this.Controls.Add(this.btnaviao);
            this.Controls.Add(this.btnonibus);
            this.Controls.Add(this.btncaminhao);
            this.Controls.Add(this.btnnaviog);
            this.Controls.Add(this.btnnavio);
            this.Controls.Add(this.btnmoto);
            this.Controls.Add(this.btncarro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Veiculos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncarro;
        private System.Windows.Forms.Button btnmoto;
        private System.Windows.Forms.Button btnnavio;
        private System.Windows.Forms.Button btnnaviog;
        private System.Windows.Forms.Button btncaminhao;
        private System.Windows.Forms.Button btnonibus;
        private System.Windows.Forms.Button btnaviao;
        private System.Windows.Forms.Button btnaviaog;
        private System.Windows.Forms.Button btntrem;
        private System.Windows.Forms.Button btnmarca;
        private System.Windows.Forms.Button btnmodelo;
    }
}

