﻿namespace DI_Suf_Ejer4
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbSuma = new System.Windows.Forms.RadioButton();
            this.rdbResta = new System.Windows.Forms.RadioButton();
            this.rdbMulti = new System.Windows.Forms.RadioButton();
            this.rdbDivi = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(180, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "=";
            // 
            // rdbSuma
            // 
            this.rdbSuma.AutoSize = true;
            this.rdbSuma.Checked = true;
            this.rdbSuma.Location = new System.Drawing.Point(18, 132);
            this.rdbSuma.Name = "rdbSuma";
            this.rdbSuma.Size = new System.Drawing.Size(31, 17);
            this.rdbSuma.TabIndex = 5;
            this.rdbSuma.TabStop = true;
            this.rdbSuma.Text = "+";
            this.rdbSuma.UseVisualStyleBackColor = true;
            this.rdbSuma.CheckedChanged += new System.EventHandler(this.cambiarCheck);
            // 
            // rdbResta
            // 
            this.rdbResta.AutoSize = true;
            this.rdbResta.Location = new System.Drawing.Point(109, 132);
            this.rdbResta.Name = "rdbResta";
            this.rdbResta.Size = new System.Drawing.Size(28, 17);
            this.rdbResta.TabIndex = 6;
            this.rdbResta.Text = "-";
            this.rdbResta.UseVisualStyleBackColor = true;
            this.rdbResta.CheckedChanged += new System.EventHandler(this.cambiarCheck);
            // 
            // rdbMulti
            // 
            this.rdbMulti.AutoSize = true;
            this.rdbMulti.Location = new System.Drawing.Point(201, 132);
            this.rdbMulti.Name = "rdbMulti";
            this.rdbMulti.Size = new System.Drawing.Size(29, 17);
            this.rdbMulti.TabIndex = 7;
            this.rdbMulti.Text = "*";
            this.rdbMulti.UseVisualStyleBackColor = true;
            this.rdbMulti.CheckedChanged += new System.EventHandler(this.cambiarCheck);
            // 
            // rdbDivi
            // 
            this.rdbDivi.AutoSize = true;
            this.rdbDivi.Location = new System.Drawing.Point(293, 132);
            this.rdbDivi.Name = "rdbDivi";
            this.rdbDivi.Size = new System.Drawing.Size(30, 17);
            this.rdbDivi.TabIndex = 8;
            this.rdbDivi.Text = "/";
            this.rdbDivi.UseVisualStyleBackColor = true;
            this.rdbDivi.CheckedChanged += new System.EventHandler(this.cambiarCheck);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Operar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 9;
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 194);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdbDivi);
            this.Controls.Add(this.rdbMulti);
            this.Controls.Add(this.rdbResta);
            this.Controls.Add(this.rdbSuma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbSuma;
        private System.Windows.Forms.RadioButton rdbResta;
        private System.Windows.Forms.RadioButton rdbMulti;
        private System.Windows.Forms.RadioButton rdbDivi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
    }
}

