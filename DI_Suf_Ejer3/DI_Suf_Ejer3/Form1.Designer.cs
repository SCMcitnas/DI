namespace DI_Suf_Ejer3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSalir = new System.Windows.Forms.Button();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.textBoxG = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxImg = new System.Windows.Forms.TextBox();
            this.btnImagen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Location = new System.Drawing.Point(445, 279);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.toolTip1.SetToolTip(this.btnSalir, "Salir de la aplicacion");
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button1_Click);
            this.btnSalir.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.btnSalir.MouseLeave += new System.EventHandler(this.mouseLeave);
            this.btnSalir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.moveComponentes);
            // 
            // textBoxR
            // 
            this.textBoxR.Location = new System.Drawing.Point(67, 51);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(100, 20);
            this.textBoxR.TabIndex = 0;
            this.textBoxR.Tag = "Codigo R";
            this.toolTip1.SetToolTip(this.textBoxR, "Dato R del RGB");
            this.textBoxR.Enter += new System.EventHandler(this.enterTxtB);
            this.textBoxR.MouseMove += new System.Windows.Forms.MouseEventHandler(this.moveComponentes);
            // 
            // textBoxG
            // 
            this.textBoxG.Location = new System.Drawing.Point(243, 51);
            this.textBoxG.Name = "textBoxG";
            this.textBoxG.Size = new System.Drawing.Size(100, 20);
            this.textBoxG.TabIndex = 1;
            this.textBoxG.Tag = "Codigo G";
            this.toolTip1.SetToolTip(this.textBoxG, "Dato G del RGB");
            this.textBoxG.Enter += new System.EventHandler(this.enterTxtB);
            this.textBoxG.MouseMove += new System.Windows.Forms.MouseEventHandler(this.moveComponentes);
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(420, 51);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 20);
            this.textBoxB.TabIndex = 2;
            this.textBoxB.Tag = "Codigo B";
            this.toolTip1.SetToolTip(this.textBoxB, "Dato B del RGB");
            this.textBoxB.Enter += new System.EventHandler(this.enterTxtB);
            this.textBoxB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.moveComponentes);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(227, 80);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 23);
            this.btnColor.TabIndex = 3;
            this.btnColor.Text = "Color";
            this.toolTip1.SetToolTip(this.btnColor, "Cambia al color establecido");
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.cambioFondo);
            this.btnColor.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.btnColor.MouseLeave += new System.EventHandler(this.mouseLeave);
            this.btnColor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.moveComponentes);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.moveComponentes);
            // 
            // textBoxImg
            // 
            this.textBoxImg.Location = new System.Drawing.Point(110, 145);
            this.textBoxImg.Name = "textBoxImg";
            this.textBoxImg.Size = new System.Drawing.Size(329, 20);
            this.textBoxImg.TabIndex = 5;
            this.textBoxImg.Tag = "Path de la imagen";
            this.toolTip1.SetToolTip(this.textBoxImg, "Path de la imagen a mostrar");
            this.textBoxImg.Enter += new System.EventHandler(this.enterTxtB);
            this.textBoxImg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.moveComponentes);
            // 
            // btnImagen
            // 
            this.btnImagen.Location = new System.Drawing.Point(445, 143);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(75, 23);
            this.btnImagen.TabIndex = 6;
            this.btnImagen.Tag = "btnImagen";
            this.btnImagen.Text = "Imagen";
            this.toolTip1.SetToolTip(this.btnImagen, "Mostrar la imagen del path");
            this.btnImagen.UseVisualStyleBackColor = true;
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
            this.btnImagen.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.btnImagen.MouseLeave += new System.EventHandler(this.mouseLeave);
            this.btnImagen.MouseMove += new System.Windows.Forms.MouseEventHandler(this.moveComponentes);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(110, 180);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 97);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Imagen solicitada");
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.moveComponentes);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 9;
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.moveComponentes);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Codigo R";
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.moveComponentes);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Codigo G";
            this.label4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.moveComponentes);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(363, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Codigo B";
            this.label5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.moveComponentes);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Path de la imagen";
            this.label6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.moveComponentes);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(532, 314);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnImagen);
            this.Controls.Add(this.textBoxImg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxG);
            this.Controls.Add(this.textBoxR);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colores e Imagenes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.moveComponentes);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox textBoxR;
        private System.Windows.Forms.TextBox textBoxG;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxImg;
        private System.Windows.Forms.Button btnImagen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

