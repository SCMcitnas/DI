namespace DI_Suf_Ejer6
{
    partial class Guardar
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
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.txtbNumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblFalloNombre = new System.Windows.Forms.Label();
            this.lblFalloNumero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(63, 32);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(133, 20);
            this.txtbNombre.TabIndex = 0;
            // 
            // txtbNumero
            // 
            this.txtbNumero.Location = new System.Drawing.Point(63, 99);
            this.txtbNumero.Name = "txtbNumero";
            this.txtbNumero.Size = new System.Drawing.Size(133, 20);
            this.txtbNumero.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(63, 154);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblFalloNombre
            // 
            this.lblFalloNombre.AutoSize = true;
            this.lblFalloNombre.ForeColor = System.Drawing.Color.Red;
            this.lblFalloNombre.Location = new System.Drawing.Point(60, 72);
            this.lblFalloNombre.Name = "lblFalloNombre";
            this.lblFalloNombre.Size = new System.Drawing.Size(0, 13);
            this.lblFalloNombre.TabIndex = 5;
            // 
            // lblFalloNumero
            // 
            this.lblFalloNumero.AutoSize = true;
            this.lblFalloNumero.ForeColor = System.Drawing.Color.Red;
            this.lblFalloNumero.Location = new System.Drawing.Point(66, 126);
            this.lblFalloNumero.Name = "lblFalloNumero";
            this.lblFalloNumero.Size = new System.Drawing.Size(0, 13);
            this.lblFalloNumero.TabIndex = 6;
            // 
            // Guardar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 358);
            this.Controls.Add(this.lblFalloNumero);
            this.Controls.Add(this.lblFalloNombre);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbNumero);
            this.Controls.Add(this.txtbNombre);
            this.Name = "Guardar";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Guardar_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblFalloNombre;
        private System.Windows.Forms.Label lblFalloNumero;
        public System.Windows.Forms.TextBox txtbNumero;
    }
}