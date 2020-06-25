namespace app_tempo_2as
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdata = new System.Windows.Forms.TextBox();
            this.txttemp = new System.Windows.Forms.TextBox();
            this.txttmax = new System.Windows.Forms.TextBox();
            this.txttmin = new System.Windows.Forms.TextBox();
            this.txtumd = new System.Windows.Forms.TextBox();
            this.txtuv = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtcity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcountry = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtwsp = new System.Windows.Forms.TextBox();
            this.limpar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Última atualização (hora local)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Última temperatura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Temperatura máxima";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Temperatura mínima";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Umidade média %";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Índice UV (última medida)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(293, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 26);
            this.label7.TabIndex = 6;
            this.label7.Text = "Velocidade do vento km/h \r\n(última medida)";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtdata
            // 
            this.txtdata.BackColor = System.Drawing.Color.LightGray;
            this.txtdata.Location = new System.Drawing.Point(294, 80);
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(154, 20);
            this.txtdata.TabIndex = 7;
            // 
            // txttemp
            // 
            this.txttemp.BackColor = System.Drawing.Color.LightGray;
            this.txttemp.Location = new System.Drawing.Point(294, 128);
            this.txttemp.Name = "txttemp";
            this.txttemp.Size = new System.Drawing.Size(154, 20);
            this.txttemp.TabIndex = 8;
            // 
            // txttmax
            // 
            this.txttmax.BackColor = System.Drawing.Color.LightGray;
            this.txttmax.Location = new System.Drawing.Point(294, 198);
            this.txttmax.Name = "txttmax";
            this.txttmax.Size = new System.Drawing.Size(154, 20);
            this.txttmax.TabIndex = 9;
            // 
            // txttmin
            // 
            this.txttmin.BackColor = System.Drawing.Color.LightGray;
            this.txttmin.Location = new System.Drawing.Point(294, 245);
            this.txttmin.Name = "txttmin";
            this.txttmin.Size = new System.Drawing.Size(154, 20);
            this.txttmin.TabIndex = 10;
            // 
            // txtumd
            // 
            this.txtumd.BackColor = System.Drawing.Color.LightGray;
            this.txtumd.Location = new System.Drawing.Point(294, 291);
            this.txtumd.Name = "txtumd";
            this.txtumd.Size = new System.Drawing.Size(154, 20);
            this.txtumd.TabIndex = 11;
            // 
            // txtuv
            // 
            this.txtuv.BackColor = System.Drawing.Color.LightGray;
            this.txtuv.Location = new System.Drawing.Point(294, 344);
            this.txtuv.Name = "txtuv";
            this.txtuv.Size = new System.Drawing.Size(154, 20);
            this.txtuv.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::app_tempo_2as.Properties.Resources.lupa;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.SkyBlue;
            this.button1.Location = new System.Drawing.Point(57, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 89);
            this.button1.TabIndex = 14;
            this.button1.Text = "Pesquisar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtcity
            // 
            this.txtcity.Location = new System.Drawing.Point(38, 124);
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(154, 20);
            this.txtcity.TabIndex = 16;
            this.txtcity.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 102);
            this.label8.TabIndex = 15;
            this.label8.Text = "Digite aqui o nome da cidade\r\nna sua gráfia original: \r\nMoscou=Moscow,\r\nNova Iorq" +
    "ue=New York,\r\nLondres=London\r\nSão Paulo=São Paulo";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtcountry
            // 
            this.txtcountry.BackColor = System.Drawing.Color.LightGray;
            this.txtcountry.Location = new System.Drawing.Point(294, 26);
            this.txtcountry.Name = "txtcountry";
            this.txtcountry.Size = new System.Drawing.Size(154, 20);
            this.txtcountry.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(291, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Pais";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::app_tempo_2as.Properties.Resources.sair;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(57, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 51);
            this.button2.TabIndex = 19;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtwsp
            // 
            this.txtwsp.BackColor = System.Drawing.Color.LightGray;
            this.txtwsp.Location = new System.Drawing.Point(294, 404);
            this.txtwsp.Name = "txtwsp";
            this.txtwsp.Size = new System.Drawing.Size(153, 20);
            this.txtwsp.TabIndex = 20;
            // 
            // limpar
            // 
            this.limpar.BackgroundImage = global::app_tempo_2as.Properties.Resources.limpar;
            this.limpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpar.Location = new System.Drawing.Point(57, 271);
            this.limpar.Name = "limpar";
            this.limpar.Size = new System.Drawing.Size(105, 47);
            this.limpar.TabIndex = 21;
            this.limpar.Text = "Limpar";
            this.limpar.UseVisualStyleBackColor = true;
            this.limpar.Click += new System.EventHandler(this.limpar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(293, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Previsão para hoje:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::app_tempo_2as.Properties.Resources.ceu2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(511, 440);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.limpar);
            this.Controls.Add(this.txtwsp);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtcountry);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtcity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtuv);
            this.Controls.Add(this.txtumd);
            this.Controls.Add(this.txttmin);
            this.Controls.Add(this.txttmax);
            this.Controls.Add(this.txttemp);
            this.Controls.Add(this.txtdata);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tempo em cidades do mundo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtdata;
        private System.Windows.Forms.TextBox txttemp;
        private System.Windows.Forms.TextBox txttmax;
        private System.Windows.Forms.TextBox txttmin;
        private System.Windows.Forms.TextBox txtumd;
        private System.Windows.Forms.TextBox txtuv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtcity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtcountry;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtwsp;
        private System.Windows.Forms.Button limpar;
        private System.Windows.Forms.Label label10;
    }
}

