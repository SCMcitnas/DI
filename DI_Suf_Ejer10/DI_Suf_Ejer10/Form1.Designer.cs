namespace DI_Suf_Ejer10
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_inicio = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_letrasUsadas = new System.Windows.Forms.Label();
            this.dibujoAhorcado1 = new Componente.DibujoAhorcado();
            this.lbl_Win = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_inicio
            // 
            this.btn_inicio.Location = new System.Drawing.Point(43, 118);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(75, 23);
            this.btn_inicio.TabIndex = 1;
            this.btn_inicio.Text = "Inicio";
            this.btn_inicio.UseVisualStyleBackColor = true;
            this.btn_inicio.Click += new System.EventHandler(this.btn_inicio_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 147);
            this.textBox1.MaxLength = 1;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_letrasUsadas
            // 
            this.lbl_letrasUsadas.AutoSize = true;
            this.lbl_letrasUsadas.Location = new System.Drawing.Point(13, 425);
            this.lbl_letrasUsadas.Name = "lbl_letrasUsadas";
            this.lbl_letrasUsadas.Size = new System.Drawing.Size(76, 13);
            this.lbl_letrasUsadas.TabIndex = 3;
            this.lbl_letrasUsadas.Text = "Letras usadas:";
            // 
            // dibujoAhorcado1
            // 
            this.dibujoAhorcado1.Errores = 0;
            this.dibujoAhorcado1.Location = new System.Drawing.Point(226, 12);
            this.dibujoAhorcado1.Name = "dibujoAhorcado1";
            this.dibujoAhorcado1.Size = new System.Drawing.Size(234, 154);
            this.dibujoAhorcado1.TabIndex = 0;
            this.dibujoAhorcado1.CambiaError += new System.EventHandler(this.dibujoAhorcado1_CambiaError);
            this.dibujoAhorcado1.Ahorcado += new System.EventHandler(this.dibujoAhorcado1_Ahorcado);
            // 
            // lbl_Win
            // 
            this.lbl_Win.AutoSize = true;
            this.lbl_Win.Location = new System.Drawing.Point(12, 94);
            this.lbl_Win.Name = "lbl_Win";
            this.lbl_Win.Size = new System.Drawing.Size(0, 13);
            this.lbl_Win.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 450);
            this.Controls.Add(this.lbl_Win);
            this.Controls.Add(this.lbl_letrasUsadas);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_inicio);
            this.Controls.Add(this.dibujoAhorcado1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ahorcado";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Componente.DibujoAhorcado dibujoAhorcado1;
		private System.Windows.Forms.Button btn_inicio;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label lbl_letrasUsadas;
        private System.Windows.Forms.Label lbl_Win;
    }
}

